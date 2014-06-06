using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Zip;

namespace EmRjt {
    internal static class Merger {
        public static async Task Merge( MergeParams p ) {
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
                await ( ( new[] {
                    ".rar", ".zip,"
                }.Any( a => a == fn ) ) ? MergeFile( p ) : MergeArchive( p ) );
            }
        }

        private static async Task MergeFile( MergeParams p ) {
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
                var zf = new FastZip {
                    CreateEmptyDirectories = true
                };
                zf.CreateZip( s, Path.GetDirectoryName( p.DataSource ), true, "*", Path.GetFileName( p.DataSource ) );
            }
        }
    }
}