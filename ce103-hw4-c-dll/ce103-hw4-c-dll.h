/**
 * @file ce103-hw4-c-dll.h
 * @author Ugur CORUH
 * @date 20 December 2021
 *
 * @brief <b> HW-4 Functions </b>
 *
 * HW-4 Functions
 *
 * @see http://bilgisayar.mmf.erdogan.edu.tr/en/
 *
 */





#pragma once





#define WIN32_LEAN_AND_MEAN             // Exclude rarely-used stuff from Windows headers





#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
 //#include <winnt.h>
 //#include <wtypes.h>
 //#include <comdef.h>

#ifdef __cplusplus
extern "C" {  // only need to export C interface if
			  // used by C++ source code
#endif

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
	__declspec(dllexport) int ce103_fibonacciNumber(int fiIndex);


	/**
		@name   strrev (ce103_strrev)

		@brief \b Reverse char*

		Reverse given string

		@param [in] fiStr [\b char*] The given string which is needed to be reversed.

		@retval [\b char*] This function returns the string after reversing the given string
	**/
	__declspec(dllexport) char* ce103_strrev(char* fiStr);

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
	__declspec(dllexport) int ce103_strlen(const char* fiStr);

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
	__declspec(dllexport) char* ce103_strcat(char* fiDest, char* fiSrc);

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
	__declspec(dllexport) int ce103_strcmp(const char* fiLhs, const char* fiRhs);

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
	__declspec(dllexport) char* ce103_strcpy(char* foDestination, const char* fiSource);

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
	__declspec(dllexport) void ce103_hex2bin(char* fiHex, int fiHexLen, unsigned char* foBin);

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
	__declspec(dllexport) void ce103_bin2hex(unsigned char* fiBin, int fiBinLen, char* foHex);

#ifdef __cplusplus
}
#endif