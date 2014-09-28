#include <stdio_ext.h>
#include <stdlib.h>

#define rojo "\x1b[31m"
#define verde "\x1b[32m"
#define amarillo "\x1b[33m"
#define azul "\x1b[34m"
#define magenta "\x1b[35m"
#define cyan "\x1b[36m"
#define blanco "\x1b[37m"
#define resetcolor "\x1b[0m"

int main(int argc, char *argv[]){

    if (argc<2){
	fprintf(stderr "Usage: %s <>\n", argv[1]);
	return EXIT_FAILURE;
    } 

    = atoi(argv[1]);

    return EXIT_SUCCESS;
}
