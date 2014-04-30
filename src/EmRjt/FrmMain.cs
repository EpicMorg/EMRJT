using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;

namespace EmRjt {
    public partial class FrmMain : Form {
        public FrmMain() { InitializeComponent(); }

        private void button1_Click( object sender, System.EventArgs e ) {
            if ( ofdSourceImg.ShowDialog() == DialogResult.OK )
                txtImg.Text = ofdSourceImg.FileName;
        }

        private void button2_Click( object sender, System.EventArgs e ) {
            if ( ofdSourceFile.ShowDialog() == DialogResult.OK )
                txtData.Text = ofdSourceFile.FileName;
        }

        private void button3_Click( object sender, System.EventArgs e ) {
            if ( fbdSourceDir.ShowDialog() == DialogResult.OK )
                txtData.Text = fbdSourceDir.SelectedPath;
        }

        private void button5_Click( object sender, System.EventArgs e ) {
            if ( sfdDestImg.ShowDialog() == DialogResult.OK )
                txtOut.Text = sfdDestImg.FileName;
        }

        private void checkBox1_CheckedChanged( object sender, System.EventArgs e ) {
            txtImg.Enabled = btnBrowseImg.Enabled = chkBuiltinImg.Checked;
        }

        private async void button4_Click( object sender, System.EventArgs e ) {
            var mergeParams = new MergeParams {
                BuiltInImg = chkBuiltinImg.Checked,
                DataSource = txtData.Text,
                DestImg = txtOut.Text,
                SourceImg = txtImg.Text
            };
            {
                string errorMessage = null;
                var error = false;
                if ( !File.Exists( mergeParams.SourceImg ) && !mergeParams.BuiltInImg ) {
                    error = true;
                    errorMessage = "Source image not found";
                }
                else if ( !File.Exists( mergeParams.DataSource ) && !Directory.Exists( mergeParams.DataSource ) ) {
                    error = true;
                    errorMessage = "Source file/directory not found";
                }
                if ( error ) {
                    MessageBox.Show( errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    return;
                }
            }
            this.Enabled = false;
            await this.Merge( mergeParams );
            MessageBox.Show( "Merge complete!", "EMRJT", MessageBoxButtons.OK, MessageBoxIcon.Information );
            this.Enabled = true;
        }

        private async Task Merge( MergeParams p ) {
            if ( File.Exists( p.DestImg ) )
                File.Delete( p.DestImg );
            if ( p.BuiltInImg )
                File.WriteAllBytes( p.DestImg, Properties.Resources.pixel );
            else
                File.Copy( p.SourceImg, p.DestImg );
            var dir = Directory.Exists( p.DataSource );
            if ( dir )
                await MergeDirectory( p );
            else {
                var fn = Path.GetExtension( p.DataSource );
                await ( ( new[] { ".rar", ".zip," }.Any( a => a == fn ) ) ? MergeFile( p ) : MergeArchive( p ) );
            }
        }

        private async Task MergeFile( MergeParams p ) {
            var zf = new FastZip();
            using ( var s = File.OpenWrite( p.DestImg ) ) {
                s.Seek( 0, SeekOrigin.End );
                zf.CreateZip( s, Path.GetDirectoryName( p.DataSource ), false, Path.GetFileName( p.DataSource ), "" );
            }
        }

        private static async Task MergeArchive( MergeParams p ) {
            using ( var s = File.OpenRead( p.DataSource ) ) {
                var buf = new byte[s.Length];
                await s.ReadAsync( buf, 0, buf.Length );
                using ( var s2 = File.OpenWrite( p.DestImg ) ) {
                    s2.Seek( 0, SeekOrigin.End );
                    await s2.WriteAsync( buf, 0, buf.Length );
                }
            }
        }

        private static async Task MergeDirectory( MergeParams p ) {
            using ( var s = File.OpenWrite( p.DestImg ) ) {
                s.Seek( 0, SeekOrigin.End );
                var zf = new FastZip { CreateEmptyDirectories = true };
                zf.CreateZip( s, Path.GetDirectoryName( p.DataSource ), true, "*", Path.GetFileName( p.DataSource ) );
            }
        }
    }

    internal class MergeParams {
        public string SourceImg { get; set; }
        public string DestImg { get; set; }
        public bool BuiltInImg { get; set; }
        public string DataSource { get; set; }
    }
}