#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int A[5][8];

    for(int f=0; f<5; f++)
	for(int c=0; c<8; c++)
	    A[f][c] = f+c;

    for(int f=0;  f<5; f++){
	for(int c=0; c<8; c++)
	    printf("%i", A[f][c]);
	printf("\n");
    }

    return EXIT_SUCCESS;
}
