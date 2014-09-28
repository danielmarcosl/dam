#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    /*
     *   Crear un número igual de columnas que de filas
     *   Imprimir tantos caracteres como numero de fila sea
     *   (fil1 = 1 char; fil2 = 2 char)
     *
     *   Introducir el valor del lado mediante argv
     *
     *   Ejemplo:
     *
     *   *
     *   **
     *   ***
     *   ****
     */

    int valor_lado;

    valor_lado = atoi(argv[1]);

    for(int col=0; col<valor_lado+1; col++){
	for(int fil=0; fil<col; fil++)
	    printf("*");
	printf("\n");
    }

    return EXIT_SUCCESS;
}
