#include "ce103-hw4-cpp-dll.h"

int ce103_fibonacciNumber_cpp(int fiIndex) {
	return ce103_fibonacciNumber(fiIndex);
}

char* ce103_strrev_cpp(char* fiStr) {
	return ce103_strrev(fiStr);
}

int ce103_strlen_cpp(const char* fiStr) {
	return ce103_strlen(fiStr);
}

char* ce103_strcat_cpp(char* fiDest, char* fiSrc) {
	return ce103_strcat(fiDest, fiSrc);
}

int ce103_strcmp_cpp(const char*fiLhs, const char* fiRhs) {
	return ce103_strcmp(fiLhs, fiRhs);
}

char* ce103_strcpy_cpp(char* foDestination, const char* fiSource) {
	return ce103_strcpy(foDestination, fiSource);
}

void ce103_hex2bin_cpp(char* fiHex, int fiHexlen, unsigned char* foBin) {
	ce103_hex2bin(fiHex, fiHexlen, foBin);

}

void ce103_bin2hex_cpp(unsigned char* fiBin, int fiBinlen, char* foHex) {
	ce103_bin2hex(fiBin, fiBinlen, foHex);
}