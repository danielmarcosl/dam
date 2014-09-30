#include <stdio_ext.h>
#include <stdlib.h>

#define N 50

int main(int argc, char *argv[]){

    int cousins[N];
    int count = 0;
    int possible_cousin;

    cousins[0] = 2;

    for(int w=3; w<N; w++){
	bool can_be_cousin = true;
	for(int x=0; x<count+1; x++){
	    if(w % cousins[x] == 0)
		can_be_cousin = false;
	}

	if(can_be_cousin){
	    count++;
	    cousins[count] = w;
	}
    }

    for(int print=0; print<count; print++)
	printf("%i ", cousins[print]);

    printf("\n");

    return EXIT_SUCCESS;
}
