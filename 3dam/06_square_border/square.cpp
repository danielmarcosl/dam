#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    /*
     *    Crear un numero igual de columnas que de filas
     *    Imprimir la primera y ultima linea llena de caracteres
     *    Las filas intermedias, poner un caracter al principio y al final
     *
     *    Ejemplo
     *
     *    *****
     *    *   *
     *    *   *
     *    *   *
     *    *****
     */

    int valor_lado;

    valor_lado = atoi(argv[1]);

    for(int col=0; col<valor_lado; col++){
	for(int fil=0; fil<valor_lado; fil++){
	    if(col == 0 || col == valor_lado - 1 || fil == 0 || fil == valor_lado -1)
		printf("*");
	    else
		printf(" ");
	}
	printf("\n");
    }

    return EXIT_SUCCESS;
}
