#include <stdio_ext.h>
#include <stdlib.h>

int main(int argc, char *argv[]){

    int vout = 0;
    int hout = 0;

    printf("Introduce el valor vertical: ");
    scanf(" %i", &vout);
    printf("Introduce el valor horizontal: ");
    scanf(" %i", &hout);

    for(int vert=0; vert<vout; vert++){
	for(int hori=0; hori<hout; hori++){
	    printf("*");
	}
	printf("\n");
    }
    return EXIT_SUCCESS;
}
