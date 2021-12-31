using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ce103_hw4_cs_dll2
{
    public class ce103ImportFunctions
    {

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_fibonacciNumber_cpp(int fiIndex);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ce103_strrev_cpp(char[] fiStr);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_strlen_cpp(string fiStr);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ce103_strcat_cpp(char[] fiDest, char[] fiSrc);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ce103_strcmp_cpp(string fiLhs, string fiRhs);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ce103_strcpy_cpp(char[] foDestination, char[] fiSource);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ce103_hex2bin_cpp(string fiHex, int fiHexLen, byte[] foBin);

        [DllImport("..\\..\\..\\x64\\Debug\\ce103-hw4-cpp-dll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ce103_bin2hex_cpp([In] byte[] fiBin, int fiBinLen, [Out] char[] foHex);



        public int ce103_fibonacciNumber_cs_import(int fiIndex)
        {
            return ce103_fibonacciNumber_cpp(fiIndex);
        }

        private static string PtrToStringUtf8(IntPtr Dyg) // aPtr is nul-terminated
        {
            if (Dyg == IntPtr.Zero)
                return "";
            int zt = 0;
            while (System.Runtime.InteropServices.Marshal.ReadByte(Dyg, zt) != 0)
                zt++;
            if (zt == 0)
                return "";
            byte[] r = new byte[zt];
            System.Runtime.InteropServices.Marshal.Copy(Dyg, r, 0, zt);
            return System.Text.Encoding.UTF8.GetString(r);
        }

        public string ce103_strrev_cs_import(string fiStr)
        {

            var k = fiStr.ToCharArray();
            var v = new char[fiStr.Length + 1];
            for (int w = 0; w < k.Length; w++)
            {
                v[w] = k[w];
            }
            v[fiStr.Length] = '\0';
            var x = ce103_strrev_cpp(v);
            return PtrToStringUtf8(x);
        }

        public int ce103_strlen_cs_import(string fiStr)
        {
            return ce103_strlen_cpp(fiStr);
        }

       

        public string ce103_strcat_cs_import(string fiDest, string fiSrc)
        {


            var b = fiDest.ToCharArray();
            var z = new char[fiDest.Length + 1];
            for (int f = 0; f < b.Length; f++)
            {
                z[f] = b[f];
            }
            z[fiDest.Length] = '\0';

            var q = fiSrc.ToCharArray();
            var l = new char[fiSrc.Length + 1];
            for (int f = 0; f < q.Length; f++)
            {
                l[f] = q[f];
            }
            l[fiSrc.Length] = '\0';





            var v = ce103_strcat_cpp(z, l);
            return PtrToStringUtf8(v);
        }

        public int ce103_strcmp_cs_import(string fiLhs, string fiRhs)
        {
            return ce103_strcmp_cpp(fiLhs, fiRhs);
        }

        public string ce103_strcpy_cs_import(string foDestination, string fiSource)
        {
            var dy = foDestination.ToCharArray();
            var oz = new char[foDestination.Length + 1];
            for (int tr = 0; tr < dy.Length; tr++)
            {
                oz[tr] = dy[tr];
            }
            oz[foDestination.Length] = '\0';

            var ln = fiSource.ToCharArray();
            var b = new char[fiSource.Length + 1];
            for (int ü = 0; ü < ln.Length; ü++)
            {
                b[ü] = ln[ü];
            }
            b[fiSource.Length] = '\0';

            var t = ce103_strcpy_cpp(ln, b);
            return PtrToStringUtf8(t);


        }

        public void ce103_hex2bin_cs_import(string fiHex, int fiHexlen, byte[] foBin)
        {
             ce103_hex2bin_cpp(fiHex, fiHexlen, foBin);
        }

        public void ce103_bin2hex_cs_import([In] byte[] fiBin, int fiBinLen, [Out] char[] foHex)
        {
             ce103_bin2hex_cpp(fiBin, fiBinLen, foHex);
        }


    }
}







