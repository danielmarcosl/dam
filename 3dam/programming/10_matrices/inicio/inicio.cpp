#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int matriz[4];
    int num_out;

    for(int i=0; i<4; i++){
	printf("Introduce el %iº valor: ", i+1);
	scanf("%i", &matriz[i]);
    }

    printf("Introduce qué valor quieres mostrar: ");
    scanf("%i", &num_out);
    printf("El %iº valor es %i.\n", num_out, matriz[num_out-1]);

    return EXIT_SUCCESS;
}
