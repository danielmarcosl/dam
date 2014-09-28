#include <stdio_ext.h>
#include <stdlib.h>

bool perf(int number){
    int sum = 0;
    int max_div = number/2;

    for(int pos_div=1; pos_div<=max_div; pos_div++)
	if(number % pos_div == 0)
	    sum += pos_div;

    return sum == number;
}

int main(int argc, char *argv[]){

    for(int i=2; i<500; i++)
	if(perf(i))
	    printf("%i ", i);

    return EXIT_SUCCESS;
}
