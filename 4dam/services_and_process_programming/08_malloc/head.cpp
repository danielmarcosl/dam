#include <stdlib.h>
#include <stdio.h>

int main(int argc, char *argv[])
{
	// Reserva la direcci�n de memoria de un entero
	int *p = (int *) malloc(sizeof(int));

	// Mete un 4 en la direcci�n de memoria reservada
	*p = 4;

	// Valor de la direcci�n de memoria de P,
	// contiene la direcci�n de memoria que tienene un 4
	printf(�%p -> %p: %i\n�, &p, p, *p);

	// Libera la direcci�n de memoria reservada
	free(p);

	// Reserva la direcci�n de 2 enteros
	int *m = (int *) malloc(2 * sizeof(int));
	
	// Se declara un primer entero en la direcci�n de memoria
	*m = 5;

	// Se declara un segundo entero en la direcci�n de memoria
	*(m+1) = 6;

	
	printf("%p \n &p: %i \n %p: %i\n", &m, m, *m, m+1, *(m+1));

	//Libera la direcci�n de memoria reservada
	free(m);
	return EXIT_SUCCESS;
}