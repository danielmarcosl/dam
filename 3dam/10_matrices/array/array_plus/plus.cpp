#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int A[3][2] = {
	{1,2},
	{5, -3},
	{-1, 4}
    };
    int B[2][4] = {
	{3, 1, 5, 6},
	{7, 0, 1, 2}
    };
    int R[3][4];

    for(int a=0; a<3; a++){
	for(int b=0; b<4; b++){
	    R[a][b] = 0;
	    for(int c=0; c<2; c++)
		R[a][b] += A[a][c] * B[c][b];
	}
    }

    for(int a=0; a<3; a++){
	printf("\n\t");
	for(int b=0; b<4; b++)
	    printf("%3i ", R[a][b]);
	printf("\n");
    }


    return EXIT_SUCCESS;
}
