#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    /*
     *    Escribir lista de 4 palabras
     *    Imprimir el numero de palabras
     */

    const char *list[] = {
	"bread",
	"toast",
	"bacon",
	"jam",
	"sausage",
	"pie"
    };

    printf("Número de palabras %zu\n", sizeof(*list));

    return EXIT_SUCCESS;
}
