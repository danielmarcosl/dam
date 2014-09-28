#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int numero_media;

    double numeros_introducidos = 0,
	   suma = 0,
	   media = 0;

    printf("¿Con cuántos números quieres hacer la media? ");
    scanf(" %i", &numero_media);

    printf("\n");

    printf("Introduce los números\n");

    for(int repeat=0; repeat<numero_media; repeat++){
	printf("Número: ");
	scanf(" %lf", &numeros_introducidos);
	suma += numeros_introducidos;
    }

    printf("\n");

    media = suma/numero_media;
    printf("La media es %lf\n", media);

    printf("\n");

    return EXIT_SUCCESS;
}
