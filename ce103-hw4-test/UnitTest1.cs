using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ce103_hw4_cs_dll1;
using ce103_hw4_cs_dll2;
using System.Text;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace ce103_hw4_test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ce103_fibonacciNumber_written_test_1()
        {

            ce103csfunctions fibo = new ce103csfunctions();
            int expected = fibo.ce103_fibonacciNumber_cs(6);

            Assert.AreEqual(expected, 8);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_test_2()
        {
            ce103csfunctions fibo = new ce103csfunctions();
            int expected = fibo.ce103_fibonacciNumber_cs(13);

            Assert.AreEqual(expected, 233);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_test_3()
        {
            ce103csfunctions fibo = new ce103csfunctions();
            int expected = fibo.ce103_fibonacciNumber_cs(20);

            Assert.AreEqual(expected, 6765);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_imported_test_1()
        {
            ce103ImportFunctions fibo = new ce103ImportFunctions();
            int expected = fibo.ce103_fibonacciNumber_cs_import(41);

            Assert.AreEqual(expected, 102334155);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_imported_test_2()
        {
            ce103ImportFunctions fibo = new ce103ImportFunctions();
            int expected = fibo.ce103_fibonacciNumber_cs_import(39);

            Assert.AreEqual(expected, 39088169);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_imported_test_3()
        {
            ce103ImportFunctions fibo = new ce103ImportFunctions();
            int expected = fibo.ce103_fibonacciNumber_cs_import(2);

            Assert.AreEqual(expected, 1);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_vs_imported_test_1()
        {
            ce103ImportFunctions importedFibo = new ce103ImportFunctions();
            ce103csfunctions writtenFibo = new ce103csfunctions();
            int written = writtenFibo.ce103_fibonacciNumber_cs(20);
            int imported = importedFibo.ce103_fibonacciNumber_cs_import(21);

            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_vs_imported_test_2()
        {
            ce103ImportFunctions importedFibo = new ce103ImportFunctions();
            ce103csfunctions writtenFibo = new ce103csfunctions();
            int written = writtenFibo.ce103_fibonacciNumber_cs(69);
            int imported = importedFibo.ce103_fibonacciNumber_cs_import(70);

            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_fibonacciNumber_written_vs_imported_test_3()
        {
            ce103ImportFunctions importedFibo = new ce103ImportFunctions();
            ce103csfunctions writtenFibo = new ce103csfunctions();
            int written = writtenFibo.ce103_fibonacciNumber_cs(60);
            int imported = importedFibo.ce103_fibonacciNumber_cs_import(61);

            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_strrev_written_test_1()
        {
            //  here we are creating an object, if we don't create it, we can't use the ce 103 cs functions class.
            ce103csfunctions reverse = new ce103csfunctions();

            string original = "Mountain";
            string reversed = "niatnuoM";

            Assert.AreEqual(reverse.ce103_strrev_cs(original), reversed);
        }

        [TestMethod]
        public void ce103_strrev_written_test_2()
        {
            //  here we are creating an object, if we don't create it, we can't use the ce 103 cs functions class.
            ce103csfunctions reverse = new ce103csfunctions();

            string original = "River";
            string reversed = "reviR";

            Assert.AreEqual(reverse.ce103_strrev_cs(original), reversed);
        }

        [TestMethod]
        public void ce103_strrev_written_test_3()
        {
            //  here we are creating an object, if we don't create it, we can't use the ce 103 cs functions class.
            ce103csfunctions reverse = new ce103csfunctions();

            string original = "Waterfall";
            string reversed = "llafretaW";

            Assert.AreEqual(reverse.ce103_strrev_cs(original), reversed);
        }


        [TestMethod]
        public void ce103_strrev_cs_import_test_1()
        {
            ce103ImportFunctions strrev = new ce103ImportFunctions();
            Assert.AreEqual(strrev.ce103_strrev_cs_import("Hiking"), "gnikiH");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_1()
        {
            ce103csfunctions strrev = new ce103csfunctions();
            ce103ImportFunctions Strrev = new ce103ImportFunctions();
            Assert.AreEqual(strrev.ce103_strrev_cs("Hiking"), "gnikiH", Strrev.ce103_strrev_cs_import("Hiking"), "gnikiH");
        }

        [TestMethod]
        public void ce103_strrev_cs_import_test_2()
        {
            ce103ImportFunctions strrev = new ce103ImportFunctions();
            Assert.AreEqual(strrev.ce103_strrev_cs_import("New Year"), "raeY weN");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_2()
        {
            ce103csfunctions strrev = new ce103csfunctions();
            ce103ImportFunctions Strrev = new ce103ImportFunctions();
            Assert.AreEqual(strrev.ce103_strrev_cs("New Year"), "raeY weN", Strrev.ce103_strrev_cs_import("New Year"), "raeY weN");
        }

        [TestMethod]
        public void ce103_strrev_cs_import_test_3()
        {
            ce103ImportFunctions strrev = new ce103ImportFunctions();
            Assert.AreEqual(strrev.ce103_strrev_cs_import("Snow Holidays"), "syadiloH wonS");
        }
        [TestMethod]
        public void ce103_strrev_importedcppcs_test_3()
        {
            ce103csfunctions strrev = new ce103csfunctions();
            ce103ImportFunctions Strrev = new ce103ImportFunctions();
            Assert.AreEqual(strrev.ce103_strrev_cs("Snow Holidays"), "syadiloH wonS", Strrev.ce103_strrev_cs_import("Snow Holidays"), "syadiloH wonS");
        }

        [TestMethod]
        public void ce103_strlen_written_test_1()
        {
            ce103csfunctions stringLength = new ce103csfunctions();
            string text = "Computer";

            int expected = stringLength.ce103_strlen_cs(text);
            Assert.AreEqual(expected, 8);
        }

        [TestMethod]
        public void ce103_strlen_written_test_2()
        {
            ce103csfunctions stringLength = new ce103csfunctions();
            string text = "Desktop Application";

            int expected = stringLength.ce103_strlen_cs(text);
            Assert.AreEqual(expected, 19);
        }

        [TestMethod]
        public void ce103_strlen_written_test_3()
        {
            ce103csfunctions stringLength = new ce103csfunctions();
            string text = "New Folder";

            int expected = stringLength.ce103_strlen_cs(text);
            Assert.AreEqual(expected, 10);
        }

        [TestMethod]
        public void ce103_strlen_imported_test_1()
        {
            ce103ImportFunctions stringLength = new ce103ImportFunctions();
            string text = "Speaker";

            int expected = stringLength.ce103_strlen_cs_import(text);
            Assert.AreEqual(expected, 7);
        }

        [TestMethod]
        public void ce103_strlen_imported_test_2()
        {
            ce103ImportFunctions stringLength = new ce103ImportFunctions();
            string text = "SoundSystem";

            int expected = stringLength.ce103_strlen_cs_import(text);
            Assert.AreEqual(expected, 11);
        }

        [TestMethod]
        public void ce103_strlen_imported_test_3()
        {
            ce103ImportFunctions stringLength = new ce103ImportFunctions();
            string text = "Phyton";

            int expected = stringLength.ce103_strlen_cs_import(text);
            Assert.AreEqual(expected, 6);
        }

        [TestMethod]
        public void ce103_strlen_written_vs_imported_test_1()
        {
            ce103ImportFunctions importedStrlen = new ce103ImportFunctions();
            ce103csfunctions writtenStrlen = new ce103csfunctions();
            string text = "Folder";

            int imported = importedStrlen.ce103_strlen_cs_import(text);
            int written = writtenStrlen.ce103_strlen_cs(text);
            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_strlen_written_vs_imported_test_2()
        {
            ce103ImportFunctions importedStrlen = new ce103ImportFunctions();
            ce103csfunctions writtenStrlen = new ce103csfunctions();
            string text = "analysis";

            int imported = importedStrlen.ce103_strlen_cs_import(text);
            int written = writtenStrlen.ce103_strlen_cs(text);
            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_strlen_written_vs_imported_test_3()
        {
            ce103ImportFunctions importedStrlen = new ce103ImportFunctions();
            ce103csfunctions writtenStrlen = new ce103csfunctions();
            string text = "command";

            int imported = importedStrlen.ce103_strlen_cs_import(text);
            int written = writtenStrlen.ce103_strlen_cs(text);
            Assert.AreEqual(written, imported);
        }

        [TestMethod]
        public void ce103_strcat_written_test_1()
        {
            // here we are creating an object, if we don't create it, we can't use the ce 103 cs functions class.
            ce103csfunctions reverse = new ce103csfunctions();
            string word1 = "Computer";
            string word2 = "Parts";

            string result = "ComputerParts";

            Assert.AreEqual(reverse.ce103_strcat_cs(word1, word2), result);
        }

        [TestMethod]
        public void ce103_strcat_written_test_2()
        {
            // here we are creating an object, if we don't create it, we can't use the ce 103 cs functions class.
            ce103csfunctions reverse = new ce103csfunctions();
            string word1 = "Happy";
            string word2 = "Day";

            string result = "HappyDay";

            Assert.AreEqual(reverse.ce103_strcat_cs(word1, word2), result);
        }

        [TestMethod]
        public void ce103_strcat_written_test_3()
        {
            // here we are creating an object, if we don't create it, we can't use the ce 103 cs functions class.
            ce103csfunctions reverse = new ce103csfunctions();
            string word1 = "Street";
            string word2 = "Light";

            string result = "StreetLight";

            Assert.AreEqual(reverse.ce103_strcat_cs(word1, word2), result);
        }
        [TestMethod]
        public void ce103_strcat_cs_import_test_1()
        {
            ce103ImportFunctions strcat = new ce103ImportFunctions();
            Assert.AreEqual(strcat.ce103_strcat_cs_import("Nice", "Day"), "NiceDay");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_1()
        {
            ce103csfunctions strcat = new ce103csfunctions();
            ce103ImportFunctions Strcat = new ce103ImportFunctions();
            Assert.AreEqual(strcat.ce103_strcat_cs("Nice", "Day"), "NiceDay", Strcat.ce103_strcat_cs_import("Nice", "Day"), "NiceDay");
        }

        [TestMethod]
        public void ce103_strcat_cs_import_test_2()
        {
            ce103ImportFunctions strcat = new ce103ImportFunctions();
            Assert.AreEqual(strcat.ce103_strcat_cs_import("Board", "Games"), "BoardGames");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_2()
        {
            ce103csfunctions strcat = new ce103csfunctions();
            ce103ImportFunctions Strcat = new ce103ImportFunctions();
            Assert.AreEqual(strcat.ce103_strcat_cs("Board", "Games"), "BoardGames", Strcat.ce103_strcat_cs_import("Board", "Games"), "BoardGames");
        }

        [TestMethod]
        public void ce103_strcat_cs_import_test_3()
        {
            ce103ImportFunctions strcat = new ce103ImportFunctions();
            Assert.AreEqual(strcat.ce103_strcat_cs_import("Sound", "System"), "SoundSystem");
        }
        [TestMethod]
        public void ce103_strcat_importedcppcs_test_3()
        {
            ce103csfunctions strcat = new ce103csfunctions();
            ce103ImportFunctions Strcat = new ce103ImportFunctions();
            Assert.AreEqual(strcat.ce103_strcat_cs("Sound", "System"), "SoundSystem", Strcat.ce103_strcat_cs_import("Sound", "System"), "SoundSystem");
        }




        
        [TestMethod]
        public void ce103_strcmp_written_test1()
        {
            ce103csfunctions strcmp = new ce103csfunctions();
            const string str1 = "people";
            const string str2 = "people";
            Assert.AreEqual(strcmp.ce103_strcmp_cs(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_written_test2()
        {
            ce103csfunctions strcmp = new ce103csfunctions();
            const string str1 = "good";
            const string str2 = "well";
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_written_test3()
        {
            ce103csfunctions strcmp = new ce103csfunctions();
            const string str1 = "other";
            const string str2 = "other";
            Assert.AreEqual(strcmp.ce103_strcmp_cs(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_imported_test1()
        {
            ce103ImportFunctions strcmp = new ce103ImportFunctions();
            const string str1 = "people";
            const string str2 = "people";
            Assert.AreEqual(strcmp.ce103_strcmp_cs_import(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_imported_test2()
        {
            ce103ImportFunctions strcmp = new ce103ImportFunctions();
            const string str1 = "good";
            const string str2 = "well";
            Assert.AreNotEqual(strcmp.ce103_strcmp_cs_import(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_imported_test3()
        {
            ce103ImportFunctions strcmp = new ce103ImportFunctions();
            const string str1 = "other";
            const string str2 = "other";
            Assert.AreEqual(strcmp.ce103_strcmp_cs_import(str1, str2), 0);
        }

        [TestMethod]
        public void ce103_strcmp_written_vs_imported_test1()
        {
            ce103ImportFunctions importedStrcmp = new ce103ImportFunctions();
            ce103csfunctions writtenStrcmp = new ce103csfunctions();
            const string str1 = "whatisthematter";
            const string str2 = "whatisthematter";
            Assert.AreEqual(importedStrcmp.ce103_strcmp_cs_import(str1, str2), writtenStrcmp.ce103_strcmp_cs(str1, str2));
        }

        [TestMethod]
        public void ce103_strcmp_written_vs_imported_test2()
        {
            ce103ImportFunctions importedStrcmp = new ce103ImportFunctions();
            ce103csfunctions writtenStrcmp = new ce103csfunctions();
            const string str1 = "haveaniceday";
            const string str2 = "haveaniceday";
            Assert.AreEqual(importedStrcmp.ce103_strcmp_cs_import(str1, str2), writtenStrcmp.ce103_strcmp_cs(str1, str2));
        }

        [TestMethod]
        public void ce103_strcmp_written_vs_imported_test3()
        {
            ce103ImportFunctions importedStrcmp = new ce103ImportFunctions();
            ce103csfunctions writtenStrcmp = new ce103csfunctions();
            const string str1 = "lookatthebook";
            const string str2 = "lookatthebook";
            Assert.AreEqual(importedStrcmp.ce103_strcmp_cs_import(str1, str2), writtenStrcmp.ce103_strcmp_cs(str1, str2));
        }

        [TestMethod]
        public void ce103_strcpy_written_test1()
        {
            ce103csfunctions strcpy = new ce103csfunctions();
            string str1 = "success";
            string str2 = "congratulations";
            string expectedStr = "congratulations";
            Assert.AreEqual(strcpy.ce103_strcpy_cs(str1, str2), expectedStr);
        }

        [TestMethod]
        public void ce103_strcpy_written_test2()
        {
            ce103csfunctions strcpy = new ce103csfunctions();
            string str1 = "Summer";
            string str2 = "Winter";
            string expectedStr = "Winter";
            Assert.AreEqual(strcpy.ce103_strcpy_cs(str1, str2), expectedStr);
        }

        [TestMethod]
        public void ce103_strcpy_written_test3()
        {
            ce103csfunctions strcpy = new ce103csfunctions();
            string str1 = "Sunny";
            string str2 = "Cloudy";
            string expectedStr = "Cloudy";
            Assert.AreEqual(strcpy.ce103_strcpy_cs(str1, str2), expectedStr);
        }
        [TestMethod]
        public void ce103_strcpy_cs_imported_test_1()
        {
            ce103ImportFunctions strcpy = new ce103ImportFunctions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_import("Construction", "Technician"), "Technician");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_1()
        {
            ce103csfunctions strcpy = new ce103csfunctions();
            ce103ImportFunctions Strcpy = new ce103ImportFunctions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Construction", "Technician"), "Technician", Strcpy.ce103_strcpy_cs_import("Construction", "Technician"), "Technician");
        }

        [TestMethod]
        public void ce103_strcpy_cs_imported_test_2()
        {
            ce103ImportFunctions strcpy = new ce103ImportFunctions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_import("New", "Student"), "Student");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_2()
        {
            ce103csfunctions strcpy = new ce103csfunctions();
            ce103ImportFunctions Strcpy = new ce103ImportFunctions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("New", "Student"), "Student", Strcpy.ce103_strcpy_cs_import("New", "Student"), "Student");
        }

        [TestMethod]
        public void ce103_strcpy_cs_imported_test_3()
        {
            ce103ImportFunctions strcpy = new ce103ImportFunctions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs_import("Hardware", "Hello"), "Hello");
        }
        [TestMethod]
        public void ce103_strcpy_importedcppcs_test_3()
        {
            ce103csfunctions strcpy = new ce103csfunctions();
            ce103ImportFunctions Strcpy = new ce103ImportFunctions();
            Assert.AreEqual(strcpy.ce103_strcpy_cs("Great", "Shot"), "Shot", Strcpy.ce103_strcpy_cs_import("Great", "Shot"), "Shot");
        }
     

        [TestMethod]
        public void ce103_hex2bin_written_test1()
        {
            ce103csfunctions hex2bin = new ce103csfunctions();
            string hexstring = "1616161616161616";
            byte[] expectedArr = { 0x16, 0x16, 0x16, 0x16, 0x16, 0x16, 0x16, 0x16 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_written_test2()
        {
            ce103csfunctions hex2bin = new ce103csfunctions();
            string hexstring = "616161616161616161";
            byte[] expectedArr = { 0x61, 0x61, 0x61, 0x61, 0x61, 0x61, 0x61, 0x61, 0x61 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_written_test3()
        {
            ce103csfunctions hex2bin = new ce103csfunctions();
            string hexstring = "DEDEDEDE";
            byte[] expectedArr = { 0xDE, 0xDE, 0xDE, 0xDE };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_imported_test1()
        {
            ce103ImportFunctions hex2bin = new ce103ImportFunctions();
            string hexstring = "F63BD1889438";
            byte[] expectedArr = { 0xF6, 0x3B, 0xD1, 0x88, 0x94, 0x38 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_import(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_imported_test2()
        {
            ce103ImportFunctions hex2bin = new ce103ImportFunctions();
            string hexstring = "1867356347251772748246";
            byte[] expectedArr = { 0x18, 0x67, 0x35, 0x63, 0x47, 0x25, 0x17, 0x72, 0x74, 0x82, 0x46 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_import(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_imported_test3()
        {
            ce103ImportFunctions hex2bin = new ce103ImportFunctions();
            string hexstring = "A4A4A4A4A4A4A4A4A4A4A4";
            byte[] expectedArr = { 0xA4, 0xA4, 0xA4, 0xA4, 0xA4, 0xA4, 0xA4, 0xA4, 0xA4, 0xA4, 0xA4 };
            byte[] hexArr = new byte[hexstring.Length / 2];
            hex2bin.ce103_hex2bin_cs_import(hexstring, hexstring.Length, hexArr);

            // assert by sequence
            CollectionAssert.AreEqual(expectedArr, hexArr);
        }

        [TestMethod]
        public void ce103_hex2bin_written_vs_imported_test1()
        {
            ce103ImportFunctions imported = new ce103ImportFunctions();
            ce103csfunctions written = new ce103csfunctions();
            string hexstring = "FFFFFFFFFF";

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_import(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            written.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }

        [TestMethod]
        public void ce103_hex2bin_written_vs_imported_test2()
        {
            ce103ImportFunctions imported = new ce103ImportFunctions();
            ce103csfunctions written = new ce103csfunctions();
            string hexstring = "DFCBFAEB";
            byte[] expectedArr = { 0xDF, 0xCB, 0xFA, 0xEB };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_import(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            written.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }

        [TestMethod]
        public void ce103_hex2bin_written_vs_imported_test3()
        {
            ce103ImportFunctions imported = new ce103ImportFunctions();
            ce103csfunctions written = new ce103csfunctions();
            string hexstring = "13245A88D6DC9C78EB91BB";
            byte[] expectedArr = { 0x13, 0x24, 0x5A, 0x88, 0xD6, 0xDC, 0x9C, 0x78, 0xEB, 0x91, 0xBB };

            byte[] hexArr = new byte[hexstring.Length / 2];
            imported.ce103_hex2bin_cs_import(hexstring, hexstring.Length, hexArr);

            byte[] hexArr2 = new byte[hexstring.Length / 2];
            written.ce103_hex2bin_cs(hexstring, hexstring.Length, hexArr2);

            
            CollectionAssert.AreEqual(hexArr, hexArr2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_test1()
        {
            ce103csfunctions written = new ce103csfunctions();
            byte[] bin = { 0xFD, 0x61, 0xE8, 0x5A, 0x34, 0xC8, 0x41 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'F', 'D', '6', '1', 'E', '8', '5', 'A', '3', '4', 'C', '8', '4', '1' };

            written.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_test2()
        {
            ce103csfunctions written = new ce103csfunctions();
            byte[] bin = { 0x22, 0x33, 0x88, 0x99, 0x66, 0x77 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '2', '2', '3', '3', '8', '8', '9', '9', '6', '6', '7', '7' };

            written.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_test3()
        {
            ce103csfunctions written = new ce103csfunctions();
            byte[] bin = { 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '5', '5', '5', '5', '5', '5', '5', '5', '5', '5', '5', '5', };

            written.ce103_bin2hex_cs(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_imported_test1()
        {
            ce103ImportFunctions imported = new ce103ImportFunctions();
            byte[] bin = { 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA, 0xAA };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A' };

            imported.ce103_bin2hex_cs_import(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_imported_test2()
        {
            ce103ImportFunctions imported = new ce103ImportFunctions();
            byte[] bin = { 0x61, 0x61, 0x61, 0x61, 0x61 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { '6', '1', '6', '1', '6', '1', '6', '1', '6', '1' };

            imported.ce103_bin2hex_cs_import(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_imported_test3()
        {
            ce103ImportFunctions imported = new ce103ImportFunctions();
            byte[] bin = { 0xA6, 0xB7, 0xC8, 0xD9, 0x12, 0x14 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring = { 'A', '6', 'B', '7', 'C', '8', 'D', '9', '1', '2', '1', '4' };

            imported.ce103_bin2hex_cs_import(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_vs_imported_test1()
        {
            ce103csfunctions written = new ce103csfunctions();
            ce103ImportFunctions imported = new ce103ImportFunctions();
            byte[] bin = { 0xDD, 0xBC, 0xAD, 0x58, 0x28, 0x38 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            written.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_import(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_vs_imported_test2()
        {
            ce103csfunctions written = new ce103csfunctions();
            ce103ImportFunctions imported = new ce103ImportFunctions();
            byte[] bin = { 0xDA, 0xDF, 0xDD, 0x21, 0x71, 0x41 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            written.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_import(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }

        [TestMethod]
        public void ce103_bin2hex_written_vs_imported_test3()
        {
            ce103csfunctions written = new ce103csfunctions();
            ce103ImportFunctions imported = new ce103ImportFunctions();
            byte[] bin = { 0xDD, 0xBB, 0xCC, 0xAA, 0xEE, 0xFF, 0x88, 0x99, 0x11 };
            char[] hexstring2 = new char[bin.Length * 2];
            char[] hexstring1 = new char[bin.Length * 2];
            written.ce103_bin2hex_cs(bin, bin.Length, hexstring1);
            imported.ce103_bin2hex_cs_import(bin, bin.Length, hexstring2);

            CollectionAssert.AreEqual(hexstring1, hexstring2);
        }
    }
}
