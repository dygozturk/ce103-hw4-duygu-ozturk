using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw4_cs_dll1
{
    public class ce103csfunctions
    {

        public int ce103_fibonacciNumber_cs(int fiIndex)
        {
            int first = 1, second = 1, third = 0;
            
            for (int i = 2; i < fiIndex; i++)
            {

                third = first + second;  
                first = second; 
                second = third; 
                
            }

            return third;
        }
        /*      the i value is incremented from 2 to fiIndex.
        the third value is the sum of first and second.
        the first value is equal to the second.
        the second value is equal to the third. */


        public string ce103_strrev_cs(string stringInput)
        {
             
            string reverse_string = "";
            int length;

            length = stringInput.Length - 1;

            while (length >= 0)
            {
                reverse_string = reverse_string + stringInput[length];
                length--;
            }
            return reverse_string;


        }
        /*  we have created an empty string named ch.
        the values of p and q are equal to the given fiStr.
        we increase the q value so that the q value is not empty.
        as long as the value of p is less than the value of q, p+1 gets the value of q-1.
        if ch is equal to the value of p, then p is equal to the value of q, and q is equal to ch again.
        The fiStr that was given at the beginning is returned in its new form. (An entire word is displaced from beginning to end.)
        For example; ABCDEFGH - HGFEDCBA*/

        public int ce103_strlen_cs(string fiStr)
        {
            int m = 0;  

            while (m != fiStr.Length)
            {
                m++;
            }

            return m;
        }
        /*      if m = 0, then,
        we equate the ptr value to the FISTR given to us.
        we increase m and increase the number of characters so that ptr is not empty.
		the  m returns as the number of characters in the word given to us.*/

        public string ce103_strcat_cs(string fiDest, string fiSrc)
        {
            string m = string.Empty;
            int k, x, L1, L2;
            L1 = fiDest.Length;
            L2 = fiSrc.Length;
            for (k = 0; k < L1; k++)
            {
                m = m + fiDest[k];
            }
            for (x = 0; x < L2; x++)
            {
                m = m + fiSrc[x];
            }
            return m;
        }
        /*      we equated the cp value to the fiDest given to us.
        as long as there is a cp value, we increase the cp value and increase the cp and fiScr.
        In this way, the first string and the second string (fiDest) are copied.*/

        public int ce103_strcmp_cs(string fiLhs, string fiRhs)
        {
            int str1 = 0, str2 = 0;
            for (int k = 0; k < (fiLhs.Length > fiRhs.Length ? fiLhs.Length : fiRhs.Length); k++)
            {
                str1 += (k >= fiLhs.Length ? 0 : fiLhs[k]) - (k >= fiRhs.Length ? 0 : fiRhs[k]);
                if (str2 < 0)
                {
                    if (str1 < 0)          
                        str2 += str1;          
                    if (str1 > 0)            
                        str2 += -str1;      
                }
                else
                {
                    str2 += str1;
                }
            }
            return str2;
        }
        /*      As long as there are fiLhs, and as long as fiLhs characters are equal to fiRhs,
        so if the words are the same as each other, we increase them both. (returns 1.)
        On the way back, the fiLhs are taken out of the fiRhs. (returns 0 - 0 = 0.) The words are not the same.*/
        public string ce103_strcpy_cs(string foDestination, string fiSource)
        {
            char[] destArr = new char[fiSource.Length];

            char[] srcArr = fiSource.ToCharArray();

            for (int k = 0; k < fiSource.Length; k++)
            {
                destArr[k] = srcArr[k];
            }
            string tempDest = new string(destArr);

            foDestination = tempDest;

            return foDestination;
        }
        /*      we have equated the variable p to foDestination.
        If the fiSource value is given, the foDestination is synchronized to all characters of the fiSource.
        As a result, foDestination will return exactly the same as fiSource as a string.*/
        public void ce103_hex2bin_cs(string fiHex, int fiHexLen, byte[] foBin)
        {
            //char[] foBinArr = new char[fiHexLen / 2];

            int[] count = { 0, 0 };  // we counted array for storing ascii and hex value of choosen element 
            for (int k = 0; k < fiHexLen; k += 2)
            {  // array for assigning foBin value elements
                char[] temp = new char[2];  // store two character from fiHex func
                int hexint = 0;  // hexint stores sum of two ascii values created from hex base
                for (int x = 0; x < 2; x++)
                {  // for loop is calculating sum of ascii values
                    temp[x] = (char)fiHex[k + x];  // we assigned first fiHex element to temp
                    if (x == 0)
                    {  // if x == 0 meaning first element of temp
                       // if and else if code snippet is taken from below website and fixed
                       // https://nachtimwald.com/2017/09/24/hex-encode-and-decode-in-c/
                        if (temp[x] >= '0' && temp[x] <= '9')
                        {  
                            count[x] = temp[x] - '0';  // we find int value of nibble
                            count[x] *= 16;  // multiply by 16 because of 16^1*hex digit
                        }
                        else if (temp[x] >= 'A' && temp[x] <= 'F')
                        {  
                            count[x] = temp[x] - 'A' + 10;  // get difference between temp and 'A' then add plus 10
                            count[x] *= 16;
                        }
                    }
                    else
                    {  
                        if (temp[x] >= '0' && temp[x] <= '9')
                        {
                            count[x] = temp[x] - '0';  // we're not multiplying by 16 because it's 16^0 digit
                        }
                        else if (temp[x] >= 'A' && temp[x] <= 'F')
                        {
                            count[x] = temp[x] - 'A' + 10;
                        }
                    }
                    hexint += count[x];  // get two digit value's sum and assign it to hexint
                }
                foBin[k / 2] = (byte)hexint;  // assigning summed values to foBin
            }
        }

        public void ce103_bin2hex_cs(byte[] fiBin, int fiBinLen, char[] foHex)
        {
            //char[] foHexArr = new char[fiBinLen * 2];
            //foHexArr = foHex.ToCharArray();
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            // below code snippet is taken from
            // https://nachtimwald.com/2017/09/24/hex-encode-and-decode-in-c/
            // basically this for loop gets hex number's right or left nibble and finds which character is this
            for (int k = 0; k < fiBinLen; k++)
            {
                foHex[k * 2] = arr[fiBin[k] >> 4];  // it means divide by 16. arr[fiBin[i] / 16] is true also
                foHex[k * 2 + 1] = arr[fiBin[k] & 0x0F];  // if i = 0 then fiBin[0] & 0x0f Note: fiBin[0] = 0x13
            }                                             // 0001 0011 & 0000 1111 = 3 basically it means
                                                          // take hexnumber's second 
        }
    }
}
