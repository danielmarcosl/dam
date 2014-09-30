#include <stdio_ext.h>
#include <stdlib.h>
#include <unistd.h>

int main(int argc, char *argv[]){

    int variable;

    for(int i=0; i<2; i++){
	printf("Padre %d.\n", getpid());
	variable = fork();
	printf("Hijo %d.\n", getpid());
    }
    printf("\n");
    return EXIT_SUCCESS;
}
