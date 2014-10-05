#include <stdio_ext.h>
#include <stdlib.h>

int main(){

    int nh = 10,
	nv = 12,
	nh2 = 0,
	nv2 = 0;

    system("clear");
    for(int vert=0; vert<nv; vert++){
	for(int hori=0; hori<nh; hori++){
	    if(vert == 0)
		printf("_");
	    else
		if(vert == nv -1)
		    printf("‾");
		else
		    if(hori == 0 || hori == nh -1)
			printf("|");
		    else
			if(vert == nv/2 -1)
			    printf("‒");
			else
			    if(vert <= nv/2 -1)
				printf("/");
			    else
				if(vert == (nv/2) + (nv/5) && hori == (nh/2 -1) + (nh/5))
				    printf("B");
				else
				    if(vert == (nv/2 -1) + (nv/5) && hori == (nh/2) + (nh/5))
					printf("A");
				    else
					if(vert == (nv/2) + (nv/5) -1 && hori == (nh/2) - (nh/5) -1)
					    printf("+");
					else
					    if(vert == nv - 2 && hori == nh/2 -1)
						printf("-");
					    else
						if(vert == nv - 2 && hori == nh/2 +1)
						    printf("-");
						else
						    printf(" ");
	}//for hori
	printf("\n");
    }//for vert

    printf("Horizontal -> ");
    scanf(" %i", &nh2);
    printf("Vertical   -> ");
    scanf(" %i", &nv2);

    system("clear");
    for(int vert=0; vert<nv2; vert++){
	for(int hori=0; hori<nh2; hori++){
	    if(vert == 0)
		printf("_");
	    else
		if(vert == nv2 -1)
		    printf("‾");
		else
		    if(hori == 0 || hori == nh2 -1)
			printf("|");
		    else
			if(vert == nv2/2 -1)
			    printf("‒");
			else
			    if(vert <= nv2/2 -1)
				printf("/");
			    else
				if(vert == (nv2/2) + (nv2/5) && hori == (nh2/2 -1) + (nh2/5))
				    printf("B");
				else
				    if(vert == (nv2/2 -1) + (nv2/5) && hori == (nh2/2) + (nh2/5))
					printf("A");
				    else
					if(vert == (nv2/2) + (nv2/5) -1 && hori == (nh2/2) - (nh2/5) -1)
					    printf("+");
					else
					    if(vert == nv2 - 2 && hori == nh2/2 -1)
						printf("-");
					    else
						if(vert == nv2 - 2 && hori == nh2/2 +1)
						    printf("-");
						else
						    printf(" ");
	}//for hori
	printf("\n");
    }//for vert

    return EXIT_SUCCESS;
}
