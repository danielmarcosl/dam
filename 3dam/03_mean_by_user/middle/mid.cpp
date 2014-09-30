#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int divisor;
    double output = 0;
    double total = 0;
    double media;

    printf("How many numbers are you going to introduce?: ");
    scanf(" %i", &divisor);

    for(int i=0; i<divisor; i++){
	printf("Introduce the %iº number: ", i+1);
	scanf(" %lf", &output);
	total = total + output;
	output = 0;
    }

    media = total / divisor;

    printf("The middle of the %i numbers is %lf\n", divisor, media);

    return EXIT_SUCCESS;
}
