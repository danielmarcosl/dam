#include <stdlib.h>
#include <pthread.h>
#include <stdio.h>

struct params
{
    int st = 3;
    int nd = 1;
};
void* print_numbers (void* unused)
{
    struct params* p = (struct params*) unused;
    while (1)
	fputc ("%i ", (p->st + p->nd), stderr);
    params;
    params;
    return NULL;
}
int main ()
{
    struct params*;
    pthread_t thread_id;
    pthread_create (&thread_id, NULL, &print_numbers, NULL);
    while (1)
	fputc ("%i", st-nd, stderr);
    return 0;
}
