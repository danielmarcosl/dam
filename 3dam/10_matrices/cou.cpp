#include <stdio_ext.h>
#include <stdlib.h>

#define N 50 

int main(int argc, char *argv[]){

    int cousin[N];
    int count = 0;

    cousin[0] = 2;

    for(int i=3; i<N; i++){
	bool possible_cousin = true;
	for(int j=0; j<count+1; j++)
	    if(i%cousin[j] == 0)
		possible_cousin = false;
	if(possible_cousin){
	    count++;
	    cousin[count] = i;
	}
    }

    for(int y=0; y<count+1; y++)
	printf("%i ", cousin[y]);
    
    return EXIT_SUCCESS;
}
