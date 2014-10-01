#include <stdio_ext.h>
#include <stdlib.h>
#include <unistd.h>

int main(int argc, char *argv[]){

    printf("Este proceso es %d.\n", getpid());
    printf("El proceso padre es %d.\n", getppid());

    return EXIT_SUCCESS;
}
