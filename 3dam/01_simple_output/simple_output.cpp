#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    char nombre_introducido[50];

    printf("Introduce un nombre: ");
    scanf(" %s", nombre_introducido);
    for(int repeat=0; repeat<10; repeat++)
	printf("%s\n", nombre_introducido);

    return EXIT_SUCCESS;
}
