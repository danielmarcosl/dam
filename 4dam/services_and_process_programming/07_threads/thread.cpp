#include <stdio_ext.h>
#include <stdlib.h>
#include <pthread.h>

struct operar
{
    int st;
    int nd;
    int count;
};

void* printres(void* params)
{
    struct operar* p = (struct counts*) params;
    int i;
    //int ress;
    //int resr;

    for(i=0; i<p->count;i++)
    {
	//if(i == p)
	//{
	//    ress = sst + snd;
	//    resturn ress;
	//}
	//if(i == q)
	//{
	//    resr = rst + rnd;
	//    return resr;
	//}
	if(i % 10 == 0)
	    fputc(p->(st-nd), stderr);
	else
	    fputc(p->(st+nd), stderr);
    }
    return NULL;
}

int main(int argc, char *argv[]){

    pthread_t thread1_id;
    ptherad_t thread2_id;
    struct suma thread1_args;
    struct resta thread2_args;

    thread1_args.st = 10;
    thread1_args.nd = 20;
    thread1_args.count = 20000;
    pthread_create (&thread1_id, NULL, &printres, &thread1_args);

    thread2_args.st = 2;
    thread2_args.nd = 1;
    thread1_args.count = 30000;
    pthread_create (&thread2_id, NULL, &printres, &thread2_args);

    return EXIT_SUCCESS;
}
