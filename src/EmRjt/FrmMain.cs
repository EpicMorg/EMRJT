/*
*************************************************************************************
Tis file is distributed under MIT license:
*************************************************************************************
The MIT License (MIT)
Copyright © 2013-2014 EpicMorg
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ''Software''), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED ''AS IS'', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.", @"The MIT License (MIT)
*************************************************************************************
*/

using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EmRjt.Properties;
using ICSharpCode.SharpZipLib.Zip;

namespace EmRjt {
    public partial class FrmMain : Form {
        public FrmMain() { this.InitializeComponent(); }

        private void Add( Panel panel, PictureBox status, string[] extensions, string errorMessage, DragEventArgs e ) {
            if ( !e.Data.GetDataPresent( DataFormats.FileDrop )
                 || e.Effect != DragDropEffects.Move )
                return;
            var objects = (string[]) e.Data.GetData( DataFormats.FileDrop );
            status.Image = Resources.wait;
            panel.Text = string.Empty;
            if ( !objects.Any() )
                return;
            var obj = objects.Last();
            var ext = Path.GetExtension( obj ).TrimStart( '.' );
            panel.Tag = obj;
            var ok = !extensions.Any() || extensions.Contains( ext );
            if ( !ok )
                MessageBox.Show( errorMessage, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            status.Image = this.GetDone( ok );
            status.Tag = ok;
        }

        private Image GetDone( bool ok ) {
            return ok ? Resources.done : Resources.cancel;
        }

        private bool CheckInput( bool repaint = true ) {
            var ok = this.s1.Tag != null && this.s2.Tag != null && (bool) this.s1.Tag && (bool) this.s2.Tag;
            if ( repaint )
                this.pOS.Image = this.GetDone( ok );
            return ok;
        }

        private void FrmMain_Load( object sender, EventArgs e ) { }

        private void panel_input1_DragEnter( object sender, DragEventArgs e ) {
            if ( e.Data.GetDataPresent( DataFormats.FileDrop )
                 && ( ( e.AllowedEffect & DragDropEffects.Move ) == DragDropEffects.Move ) )
                e.Effect = DragDropEffects.Move;
        }

        private void panel_input2_DragEnter( object sender, DragEventArgs e ) {
            if ( e.Data.GetDataPresent( DataFormats.FileDrop )
                 && ( ( e.AllowedEffect & DragDropEffects.Move ) == DragDropEffects.Move ) )
                e.Effect = DragDropEffects.Move;
        }

        private void panel_input1_DragDrop( object sender, DragEventArgs e ) {
            this.Add( this.p1, this.s1, new[] {
                "rar", "zip", "jar", "7zip"
            }, @"Please, drag valid archive file!", e );

            this.CheckInput();
        }

        private void panel_input2_DragDrop( object sender, DragEventArgs e ) {
            this.Add( this.p2, this.s2, new[] {
                "jpg", "jpeg", "bmp", "png", "gif"
            }, @"Please, drag valid image file!", e );

            this.CheckInput();
        }

        private void FrmMain_Click( object sender, EventArgs e ) {
            var frmabout = new FrmAbout();
            frmabout.ShowDialog();
        }

        private async void panel_output_Click( object sender, EventArgs e ) {
            if ( !this.CheckInput( false ) )
                return;
            this.sfdOut.DefaultExt = this.p1.Tag as string;
            if ( this.sfdOut.ShowDialog() != DialogResult.OK )
                return;
            this.SetLocked( false );
            this.SetStatusImage( false );
            await Merger.Merge( new MergeParams {
                BuiltInImg = false, DataSource = this.p1.Tag as string, DestImg = this.sfdOut.FileName, SourceImg = this.p2.Tag as string
            } );
            this.SetStatusImage(true);
            this.SetLocked( true );
        }

        private void SetStatusImage( bool ok ) {
            this.pOS.Image = ok ? Resources.done : Resources.wait;
            
        }

        private void SetLocked( bool state ) {
            this.p1.Enabled = this.p2.Enabled = this.panel_output.Enabled = state;
        }
    }
}