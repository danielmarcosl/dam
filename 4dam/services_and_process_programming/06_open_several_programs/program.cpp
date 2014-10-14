#include <stdio.h>
#include <stdlib.h>

const char *program[] =
{
    "firefox",
    "gedit",
    NULL
};

void spawn(const char *program)
{
    const char *params[] = 
    {
	"--version",
	NULL
    };

    int child = 0;
    child = fork();
    if(child)
    {
	// Parent code
    }
    else
    {
	// Child code
	exec(program);
	fprintf(stderr, "%s didn't start properly.\n");
	abort();
    }
}
int show_menu()
{
    int option;

    system("clear");
    printf("\nOpciones:\n\n");
    for(int op=0; program[op]; op++)
	printf ("%i.-%s\n", op + 1, program[op]);
    printf("\n\tSu opción: ");
    scanf("%i", &option);

    return(option -1);
}

}
int main(int argc, char *argv[])
{
    int option;

    show_menu();
    printf("Se ha arrancado %s", program[option]);
    system(program[option]);
}
