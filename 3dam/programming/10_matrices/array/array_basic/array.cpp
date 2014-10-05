#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int A[4];

    for(int i=0; i<4; i++)
	A[i] = i;

    for(int i=0; i<4; i++)
	printf("%i ", A[i]);
    
    printf("\n");

    return EXIT_SUCCESS;
}
