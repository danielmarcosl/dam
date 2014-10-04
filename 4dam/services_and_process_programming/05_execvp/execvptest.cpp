#include<iostream>
#include<stdlib.h>
#include<unistd.h>
using namespace std;
int spawn(char *,char**);

int main(int argc,char** argv){
    //We are making use of both, command line arguments and user-defined array for demonstration purpose
    char* arg_list[]={"firefox","-l","/",NULL};
    int id=spawn(argv[1],&argv[2]);
    int id1=spawn("firefox",arg_list);
    cout<<"Child Spawned "<<id<<endl;

    return 0;
}

//The function accepts the program name, arguments to be passed to the program
int spawn(char *program,char** arg_list){
    pid_t child_pid;
    child_pid = fork();    //Creates a child process
    if(child_pid!=0){
	return child_pid;    //The parent process terminates here after returning child process id
    }
    else{
	if(arg_list[0]!=NULL)
	    execvp(program,arg_list); // The child process executes the program leave the main parent thread unoccupied
	//execvp accepts two argument, first the name of the program to be executed and second list of arguments to be passed to the program
	else system(program); // In case there are no arguments, we are simply using system function call here. With execvp, passing arg_list as NULL(i.e. no arguments) usually return with an error
	exit(0);
    }
}
