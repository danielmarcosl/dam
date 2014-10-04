#include <stdio_ext.h>
#include <stdlib.h>
int main(int argc, char *argv[]){
    int child_status;
    char arg_list[3];
    arg_list = {"ls", "-l", "/", NULL};
    spawn ("ls", arg_list);
    wait (&child_status);
    if(WIFEXITED (child_status))
	printf("the child process exited normally, with xode %d\n", WIXITSTATUS (child_status));
    else
	printf("the child process exited abnormally\n");
    return 0;
}
