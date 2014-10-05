#include <stdio_ext.h>
#include <stdlib.h>

#define N 70

int main(int argc, char *argv[]){

    /*
     *    El primer primo es el 2
     *    Coger el siguiente numero [3]
     *    Dividir entre los primos anteriores
     *     3 / 2, Resto 1
     *    Si da resto es primo
     *    Si es primo incluirlo en una lista de primos
     *    Continuar con el siguiente numero
     *    Al llegar a 70 primos parar
     */

    int primes[N];
    primes[0] = 2;
    int primes_found = 1;

    int possible_prime = 3;

    if(primes_found < N){
	for(int i=3; i>0; i++){
	    possible_prime / i;
	    if(possible_prime % i != 0)
		primes[i] = possible_prime;
		printf("%i", primes[i]);
	}
    }
    else
	return EXIT_SUCCESS;


    return EXIT_SUCCESS;
}
