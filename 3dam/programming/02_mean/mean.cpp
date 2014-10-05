#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    double numero = 0,
	   suma = 0,
	   media = 0;

    printf("Introduce 10 números\n");

    for(int repeat=0; repeat<10; repeat++){
	printf("Número: ");
	scanf(" %lf", &numero);
	suma += numero;
    }

    media = suma/10;
    printf("La media es %lf\n", media);

    return EXIT_SUCCESS;
}
