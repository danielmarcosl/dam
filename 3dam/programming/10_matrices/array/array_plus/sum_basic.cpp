#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int A[3] = {1, 2, 3};
    int B[4] = {-1, 6, 3, 9};
    int R[4];

    for(int a=0; a<4; a++)
	R[a] = A[a] + B[a];

    for(int a=0; a<4; a++)
	printf("%i ", R[a]);

    printf("\n");

    return EXIT_SUCCESS;
}
