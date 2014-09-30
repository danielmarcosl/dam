#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int vout = 0;
    int hout = 0;

    printf("Introduce the vertical: ");
    scanf(" %i", &vout);
    printf("Introduce the horizontal: ");
    scanf(" %i", &hout);

    for(int vert=0; vert<vout; vert++){
	for(int hori=0; hori<hout; hori++){
	    if(vert == (vout /2) -1 || vert == (vout/2))
		printf("*");
	    else
		if(hori == (hout /2) -1 || hori == (hout/2))
		    printf("*");
		else
		    printf(" ");
	}
	printf("\n");
    }
    return EXIT_SUCCESS;
}
