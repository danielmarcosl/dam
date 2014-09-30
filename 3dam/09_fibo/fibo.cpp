#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int terms[] = {1,1};
    int c_num;

    c_num = atoi(argv[1]);

    for(int cont=2; cont<c_num; cont++){
	int resultado = terms[0] + terms[1];
	printf("%i ", resultado);
	terms[cont%2] = resultado;
    }

    printf("\n");

    return EXIT_SUCCESS;
}
