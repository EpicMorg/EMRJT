/*
*************************************************************************************
Tis file is distributed under MIT license:
*************************************************************************************
The MIT License (MIT)
Copyright © 2013-2017 EpicMorg
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
using EMGRJT.Resources;

namespace EMGRJT
{
    public partial class FrmMain : Form {
        public FrmMain() { InitializeComponent(); }

        private void Add( Panel panel, PictureBox status, string[] extensions, string errorMessage, DragEventArgs e ) {
            if ( !e.Data.GetDataPresent( DataFormats.FileDrop )
                 || e.Effect != DragDropEffects.Move )
                return;
            var objects = (string[]) e.Data.GetData( DataFormats.FileDrop );
            status.Image = Properties.Resources.wait;
            panel.Text = string.Empty;
            if ( !objects.Any() )
                return;
            var obj = objects.Last();
            var ext = Path.GetExtension( obj ).TrimStart( '.' );
            panel.Tag = obj;
            var ok = !extensions.Any() || extensions.Contains( ext );
            if ( !ok )
                MessageBox.Show( errorMessage, Translation.msgError, MessageBoxButtons.OK, MessageBoxIcon.Error );
            status.Image = GetDone( ok );
            status.Tag = ok;
        }

        private Image GetDone( bool ok ) {
            return ok ? Properties.Resources.done : Properties.Resources.cancel;
        }

        private bool CheckInput( bool repaint = true ) {
            var ok = s1.Tag != null && s2.Tag != null && (bool) s1.Tag && (bool) s2.Tag;
            if ( repaint )
                pOS.Image = GetDone( ok );
            return ok;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            msgArchHelp.Text = Translation.msgArchHelp;
            msgPicHelp.Text = Translation.msgPicHelp;
            msgRarJpegHelp.Text = Translation.msgRarJpegHelp;
        }

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
            Add( p1, s1, new[] {
                "rar", "zip", "jar", "7z"
            }, Translation.msgSelectArchive, e );

            CheckInput();
        }

        private void panel_input2_DragDrop( object sender, DragEventArgs e ) {
            Add( p2, s2, new[] {
                "j","jfif","j2k","jp2","jpe", "jpg", "jpeg", "bmp", "png", "gif", "tiff"
            }, Translation.msgSelectPic, e );

            CheckInput();
        }

        private void FrmMain_Click( object sender, EventArgs e ) {
            var frmabout = new FrmAbout();
            frmabout.ShowDialog();
        }

        private async void panel_output_Click( object sender, EventArgs e ) {
            if ( !CheckInput( false ) )
                return;
            sfdOut.DefaultExt = p1.Tag as string;
            if ( sfdOut.ShowDialog() != DialogResult.OK )
                return;
            SetLocked( false );
            SetStatusImage( false );
            await Merger.Merge( new MergeParams {
                BuiltInImg = false, DataSource = p1.Tag as string, DestImg = sfdOut.FileName, SourceImg = p2.Tag as string
            } );
            SetStatusImage(true);
            SetLocked( true );
        }

        private void SetStatusImage( bool ok ) {
            pOS.Image = ok ? Properties.Resources.done : Properties.Resources.wait;
            
        }

        private void SetLocked( bool state ) {
            p1.Enabled = p2.Enabled = panel_output.Enabled = state;
        }
    }
}