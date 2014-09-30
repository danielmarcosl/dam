#include <stdio_ext.h>
#include <stdlib.h>

#define M 4
#define N 3

int main(int argc, char *argv[]){

    int A[M][N];
    int count = 0;

    for(int vert=0; vert<M; vert++)
	for(int hori=0; hori<N; hori++){
	    A[vert][hori] = count;
	    count++;
	}

    for(int vert=0; vert<M; vert++){
	for(int hori=0; hori<N; hori++)
	    printf("%i ", A[vert][hori]);
	printf("\n");
    }


    return EXIT_SUCCESS;
}
