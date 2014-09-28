#include <stdio_ext.h>
#include <stdlib.h>
#include <unistd.h>

int main(int argc, char *argv[]){

    for(int i=0; i<3; i++){
	printf("HelloWorld\n");
	fork();
	printf("Hi ");
    }
    printf("\n");
    return EXIT_SUCCESS;
}
