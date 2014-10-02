#include <stdio_ext.h>
#include <stdlib.h>
#include <unistd.h>

int main(int argc, char *argv[]){

	int variable = 0, count = 0;

	for(int i=0; i<4; i++){
		printf(">>>>%i ->> %d.\n", count, variable);
		count++;
		printf(">%i\n", count);
		fork();
		printf(">>%i\n", count);
		variable++;
	}
	return EXIT_SUCCESS;
}
