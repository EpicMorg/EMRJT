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

using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Zip;

namespace EMGRJT
{
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
                    ".rar", ".zip", ".jar", ".7z"
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