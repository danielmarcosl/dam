#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int A[3][3] = {
	{1, 2, 3},
	{5, -3, 2},
	{-1, 4, 1}
    };
    int B[3][3] = {
	{3, 1, 5},
	{7, 0, 1},
	{-2, 6, 3}
    };
    int R[3][3];

    for(int a=0; a<3; a++)
	for(int b=0; b<3; b++)
	    R[a][b] = A[a][b] + B[a][b];

    for(int a=0; a<3; a++){
	for(int b=0; b<3; b++){
	    printf("%i ", R[a][b]);
	}
	printf("\n");
    }


    return EXIT_SUCCESS;
}
