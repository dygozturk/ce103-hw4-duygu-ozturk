/****************************************************************************
 * Copyleft (L) 2021 CENG - All Rights Not Reserved
 * You may use, distribute and modify this code.
 ****************************************************************************/

 /**
  * @file CE103-HW2-Lib.c
  * @author Duygu Ozturk
  * @date 31 December 2021
  *
  * @brief <b> HW-2 Functions </b>
  *
  * HW-2 Sample Lib Functions
  *
  * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
  *
  */

#include "ce103-hw4-c-dll.h"

  /**
   @name TestFunction(fnCE103HW2Lib)
	  @brief \b Auto Generated Test Function

	  Auto Generated Test Function Has Doxygen and Plantuml Integration

   Sample Web Page Link
   @see https://www.cplusplus.com/reference/cstring/strcpy/

   Sample Image AES Block Decryption Operation

   @image html aes_enc_dec.png
   @image rtf aes_enc_dec.png
   @image latex aes_enc_dec.png

   Sample Related Function Link
   @see TestFunction (fnCE103HW2Lib)
   <b> Plant UML Sample </b> <BR>
   @image html fnCE103HW2Lib.png
   @image rtf fnCE103HW2Lib.png
   @image latex fnCE103HW2Lib.png

   <!--

	  @startuml fnCE103HW2Lib.png

	  title Servlet Container

	  (*) --> "ClickServlet.handleRequest()"
	  --> "new Page"

	  if "Page.onSecurityCheck" then
		->[true] "Page.onInit()"

		if "isForward?" then
		 ->[no] "Process controls"

		 if "continue processing?" then
		   -->[yes] ===RENDERING===
		 else
		   -->[no] ===REDIRECT_CHECK===
		 endif

		else
		 -->[yes] ===RENDERING===
		endif

		if "is Post?" then
		  -->[yes] "Page.onPost()"
		  --> "Page.onRender()" as render
		  --> ===REDIRECT_CHECK===
		else
		  -->[no] "Page.onGet()"
		  --> render
		endif

	  else
		-->[false] ===REDIRECT_CHECK===
	  endif

	  if "Do redirect?" then
	   ->[yes] "redirect request"
	   --> ==BEFORE_DESTROY===
	  else
	   if "Do Forward?" then
		-left->[yes] "Forward request"
		--> ==BEFORE_DESTROY===
	   else
		-right->[no] "Render page template"
		--> ==BEFORE_DESTROY===
	   endif
	  endif

	  --> "Page.onDestroy()"
	  -->(*)
	  @enduml

   -->

	 @param [in] fia	[\b unsigned char*] Binary Data Input
	 @param [in] fib	[\b int] Binary Data Input Length
	 @param [out] fic	[\b char*] Hex String Output Array

	  @retval [\b int] operation result success 0 fail 1

	  Example Usage :

	   @code
		#include <stdio.h>
		#include <string.h>

		int main (){
		  unsigned char data[]="\x13\x13\x13x\13";
		 int dataLength = 4;
		  char dataHex[40];

		  if(fnCE103HW2Lib(data,dataLength,dataHex)!=0)
		 {
		   printf("Operation Failed!");
		   return -1;
		 }

		printf("Converted Data [%s]",dataHex);

		  return 0;
	   }
	  @endcode
  **/
int fnCE103HW2Lib(unsigned char* fia, int fib, char* fic)
{
	//Empty Body...
	return -1;
}

/**
*
*	  @name   fibonacciNumber (ce103_fibonacciNumber)
*
*	  @brief Fibonacci Number Calculator
*
*	  Calculates the fibonacci number in the given index and return as output
*
*	  @param  [in] fiIndex [\b int]  index of fibonacci number in the serie
*
*	  @retval [\b int] calculated fibonacci number
**/
int ce103_fibonacciNumber(int fiIndex)
{
	//TODO:Start from Here...
	int first = 0, second = 1, third;
	for (int i = 1; i < fiIndex; i++)
	{
		third = first + second;
		first = second;
		second = third;
	}
	return first;
}
/*      the i value is incremented from 0 to fiIndex.
		the third value is the sum of first and second.
		the first value is equal to the second.
		the second value is equal to the third. */

		/**
			@name   strrev (ce103_strrev)

			@brief \b Reverse String

			Reverse given string

			@param [in] fiStr [\b char*] The given string which is needed to be reversed.

			@retval [\b char*] This function returns the string after reversing the given string
		**/
char* ce103_strrev(char* fiStr)
{
	//TODO:Start from Here...
	char ch;
	char* p = fiStr;
	char* q = fiStr;

	for (; *q != '\0'; q++);
	;
	q--;
	for (; p < q; p++, q--) {
		ch = *p;
		*p = *q;
		*q = ch;
	}
	return fiStr;
}
/*  we have created an empty string named ch.
	the values of p and q are equal to the given fiStr.
	we increase the q value so that the q value is not empty.
	as long as the value of p is less than the value of q, p+1 gets the value of q-1.
	if ch is equal to the value of p, then p is equal to the value of q, and q is equal to ch again.
	The fiStr that was given at the beginning is returned in its new form. (An entire word is displaced from beginning to end.)
	For example; ABCDEFGH - HGFEDCBA*/


	/**
		@name   strlen (ce103_strlen)
		@brief \b Get string length

		Returns the length of the C string str.

		The length of a C string is determined by the terminating null-character:
		A C string is as long as the number of characters between the beginning of
		the string and the terminating null character
		(without including the terminating null character itself).

		see more <a href="https://en.cppreference.com/w/c/string/byte/strlen">strlen reference 1</a>
		see more <a href="https://www.programiz.com/c-programming/library-function/string.h/strlen">strlen reference 2</a>
		see more <a href="https://www.cplusplus.com/reference/cstring/strlen/">strlen reference 3</a>

		@param [in] fiStr [\b const char*] pointer to the null-terminated byte string to be examined

		@retval [\b int] The length of the null-terminated byte string str.
	**/
int ce103_strlen(const char* fiStr)
{
	//TODO:Start from Here...

	int i = 0;
	char* ptr = fiStr;
	while (*ptr != '\0')
	{
		++i;
		++ptr;
	}
	return i;

}
/*      if i = 0, then,
		we equate the ptr value to the FISTR given to us.
		we increase i and increase the number of characters so that ptr is not empty.
		the  i returns as the number of characters in the word given to us.*/

		/**
			@name   strcat (ce103_strcat)
			@brief \b Concatenate strings

			Appends a copy of the null-terminated byte string pointed to by src to the end of the null-terminated byte string pointed to by dest

			The character src[0] replaces the null terminator at the end of dest. The resulting byte string is null-terminated.

			The behavior is undefined if the destination array is not large enough for the contents of
			both src and dest and the terminating null character. The behavior is undefined if the strings overlap.
			The behavior is undefined if either dest or src is not a pointer to a null-terminated byte string.

			see more <a href="https://en.cppreference.com/w/c/string/byte/strcat">strcat reference</a>
			see more <a href="https://www.cplusplus.com/reference/cstring/strcat/">strcat reference</a>

			@param  [in] fiDest [\b char*] pointer to the null-terminated byte string to append to
			@param  [in] fiSrc  [\b char*] pointer to the null-terminated byte string to copy from

			@retval [\b char*] returns a copy of dest
		**/
char* ce103_strcat(char* fiDest, char* fiSrc)
{
	//TODO:Start from Here...
	char* cp = fiDest;

	while (*cp)

		cp++;

	while (*cp++ = *fiSrc++);

	return(fiDest);
}
/*      we equated the cp value to the fiDest given to us.
		as long as there is a cp value, we increase the cp value and increase the cp and fiScr.
		In this way, the first string and the second string (fiDest) are copied.*/


		/**
			@name   strcmp (ce103_strcmp)
			@brief  \b Compare two strings

			Compares two null-terminated byte strings lexicographically.

			The sign of the result is the sign of the difference between
			the values of the first pair of characters (both interpreted as unsigned char)
			that differ in the strings being compared.The behavior is undefined
			if lhs or rhs are not pointers to null-terminated byte strings.

			see more <a href="https://en.cppreference.com/w/c/string/byte/strcmp">strcmp reference</a>
			see more <a href="https://www.cplusplus.com/reference/cstring/strcmp/">strcmp reference</a>

			@param  [in] fiLhs [\b const char*] pointers to the null-terminated byte strings to compare
			@param  [in] fiRhs [\b const char*] pointers to the null-terminated byte strings to compare

			@retval [\b int] Negative value if lhs appears before rhs in lexicographical order.
					Zero if lhs and rhs compare equal.
					Positive value if lhs appears after rhs in lexicographical order.
		**/
int ce103_strcmp(const char* fiLhs, const char* fiRhs)
{
	//TODO:Start from Here...

	while (fiLhs && (fiLhs == *fiRhs)) {
		fiLhs++;
		fiRhs++;
	}
	return *fiLhs - *fiRhs;
}
/*      As long as there are fiLhs, and as long as fiLhs characters are equal to fiRhs,
		so if the words are the same as each other, we increase them both. (returns 1.)
		On the way back, the fiLhs are taken out of the fiRhs. (returns 0 - 0 = 0.) The words are not the same.*/


		/**
		*
			@name  strcpy (ce103_strcpy)
			@brief \b Copy string

			Copies the C string pointed by source into the array pointed by destination,
			including the terminating null character (and stopping at that point).

			To avoid overflows, the size of the array pointed by destination shall be long enough to contain
			the same C string as source (including the terminating null character),
			and should not overlap in memory with source.

			see more <a href="https://en.cppreference.com/w/c/string/byte/strcpy">strcpy reference 1</a>
			see more <a href="https://www.cplusplus.com/reference/cstring/strcpy/">strcpy reference 2</a>

			@param [out] foDestination	[\b char*]			Pointer to the destination array where the content is to be copied.
			@param [in]  fiSource		[\b const char*]	C string to be copied.

			@retval returns a copy of dest
		**/
char* ce103_strcpy(char* foDestination, const char* fiSource)
{
	//TODO:Start from Here...
	char* ret = foDestination;
	while ((*foDestination++ = *fiSource++) != '\0');
	return ret;
}
/*      we have equated the variable p to foDestination.
		If the fiSource value is given, the foDestination is synchronized to all characters of the fiSource.
		As a result, foDestination will return exactly the same as fiSource as a string.*/
		/**
		 * @name    hex2bin (ce103_hex2bin)
		 * @brief   \b Hexadecimal to Binary (BCD)  Conversion
		 *
		 * Hexadecimal to Binary (BCD)  Conversion
		 * Packs hexadecimal string to packed binary array, Example: "AB1234" => 0xAB 0x12 0x34
		 * If length of the input string is less than the fiHexLen,remaining bytes is not filled.
		 * If odd number of characters processed, last nibble is padded with 0
		 *
		 * @param   [in]  fiHex    [\b unsigned char*] Ascii hex string.
		 * @param   [in]  fiHexLen [\b int]     Ascii data length.
		 * @param  [out]  foBin    [\b char*]   Convertion result as binary.
		 */
void ce103_hex2bin(char* fiHex, int fiHexLen, unsigned char* foBin)
{
	//TODO:Start from Here...
	int c, d;
	for (;;) {
		c = *fiHex++; if (c == 0) break;
		if (c > 96) c -= 87;
		else if (c > 64) c -= 55;
		else c -= 48;
		d = *fiHex++; if (d == 0) { *foBin = c << 4; break; }
		if (d > 96) d -= 87;
		else if (d > 64) d -= 55;
		else d -= 48;
		*foBin++ = (c << 4) | d;
	}
	return fiHex;
}
/*    you will be given 16 letters/numbers/numbers/characters.
	  You will group them into 2 groups. And it will be added to their heads (0x).
	  For example: The value for "ABCDEFGH" should be: 0xAB, 0xCD, 0xDE.
	  We tested it the easy way by repeating the value of 13 in 1 and adding 0x per.
	  In Test 2, we also did a letter check and solved it a long way.*/

	  /**
	  * @name    bin2hex (ce103_bin2hex)
	  * @brief   \b Binary (BCD) to Hexadecimal Conversion
	  *
	  * Unpacks alpha numeric value, Example: 0x12 0x34 = "1234".
	  *
	  * @param [in]  fiBin      [\b unsigned char*]    Binary data to be converted.
	  * @param [in]  fiBinLen   [\b int]				 Binary data length.
	  * @param [out] foHex      [\b char*]			 Convertion result as ascii. Doubles the binary length.
	  *
	  */
void ce103_bin2hex(unsigned char* fiBin, int fiBinLen, char* foHex)
{
	//TODO:Start from Here...
	int c, d, * end = fiBin + fiBinLen;
	while (fiBin < end) {
		c = *(fiBin++);
		d = c >> 4;
		*(foHex++) = d + (d > 9 ? 55 : 48);
		d = c & 15;
		*(foHex++) = d + (d > 9 ? 55 : 48);
	}
	*foHex = 0;
	return fiBin;
}
/*      It will extract numbers from the given array.
		For example: we will take 0x12 from the string and use it as += 12 in a string.
		The value it returns must be a combination of all these given numbers in a string.
		returns (0x12, 0x34) --> (1234).*/