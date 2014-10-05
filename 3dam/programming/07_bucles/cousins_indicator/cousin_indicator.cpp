#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int num_output;

    printf("Introduce a number: ");
    scanf(" %i", &num_output);
    if(num_output == 2 || num_output == 3 || num_output == 5 ||
	    num_output == 7 || num_output == 11 || num_output == 13)
	printf("Yes\n");
    else
	if(	    num_output % 2 == 0 || num_output % 3 == 0 || num_output % 5 == 0 ||
		num_output % 7 == 0 || num_output % 11 == 0 || num_output % 13 == 0) 
	    printf("No\n");
	else
	    printf("Yes\n");
    return EXIT_SUCCESS;
}
