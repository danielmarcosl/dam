#include <stdlib.h>
#include <stdio.h>

int main(int argc, char *argv[])
{
	// Reserva la dirección de memoria de un entero
	int *p = (int *) malloc(sizeof(int));

	// Mete un 4 en la dirección de memoria reservada
	*p = 4;

	// Valor de la dirección de memoria de P,
	// contiene la dirección de memoria que tienene un 4
	printf(“%p -> %p: %i\n”, &p, p, *p);

	// Libera la dirección de memoria reservada
	free(p);

	// Reserva la dirección de 2 enteros
	int *m = (int *) malloc(2 * sizeof(int));
	
	// Se declara un primer entero en la dirección de memoria
	*m = 5;

	// Se declara un segundo entero en la dirección de memoria
	*(m+1) = 6;

	
	printf("%p \n &p: %i \n %p: %i\n", &m, m, *m, m+1, *(m+1));

	//Libera la dirección de memoria reservada
	free(m);
	return EXIT_SUCCESS;
}