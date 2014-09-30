#include <stdio.h>
#include <stdlib.h>
#include <sys/types.h>
#include <unistd.h>

int main(){

	int uno, dos, tres, cuatro;
	for(int i=1; i>0; i++){
		printf("Primero");
		uno = fork();
		printf("Segundo");
		dos = fork();
		printf("Tercero");
		tres = fork();
		printf("Cuarto");
		cuatro = fork();
		printf("Quinto");
	}
	return EXIT_SUCCESS;
}
