#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int A[3][2] = {{3,4},{-1,8},{2,1}};
    int B[2][4] = {{3,-2,2,5},{1,-5,-3,3}};
    int C[3][4];

    for(int a=0; a<3; a++)
	for(int b=0; b<4; b++)
	    for(int c=0; c<2; c++)
		C[a][b] = A[a][c] + B[c][b];

    for(int vert=0; vert<3; vert++){
	for(int hori=0; hori<4; hori++)
	    printf("%i ", C[vert][hori]);
	printf("\n");
    }
    return EXIT_SUCCESS;
}
