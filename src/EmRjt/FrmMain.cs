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
using System.Windows.Forms;

namespace EmRjt
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
           InitializeComponent();
           panel_input1.AllowDrop = true;
           panel_input1.DragEnter += this.panel_input1_DragEnter;
           panel_input1.DragDrop += this.panel_input1_DragDrop;
           panel_input2.DragEnter += this.panel_input2_DragEnter;
           panel_input2.DragDrop += this.panel_input2_DragDrop;
        }
  
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void panel_input1_DragEnter(object sender, DragEventArgs e)
        {
            if ( e.Data.GetDataPresent( DataFormats.FileDrop )
                 && ( ( e.AllowedEffect & DragDropEffects.Move ) == DragDropEffects.Move ) ) 
                e.Effect = DragDropEffects.Move;
           
        }

        private void panel_input1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                pic_input_status1.Image = Properties.Resources.done;
                // В objects хранятся пути к папкам и файлам
                panel_input1.Text = null;
                for (int i = 0; i < objects.Length; i++)
                    panel_input1.Text += objects[i] + "\r\n";
            }   
            else { pic_input_status1.Image = Properties.Resources.cancel; }
        }

        private void panel_input2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)
                 && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;

        }

        private void panel_input2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                pic_input_status2.Image = Properties.Resources.done;
                // В objects хранятся пути к папкам и файлам
                panel_input2.Text = null;
                for (int i = 0; i < objects.Length; i++)
                    panel_input2.Text += objects[i] + "\r\n";
            }
            else { pic_input_status2.Image = Properties.Resources.cancel; }
        }


        private void FrmMain_Click( object sender, EventArgs e ) {
            var frmabout = new FrmAbout();
            frmabout.ShowDialog();
        }
         
    }
}
