function increment(){

   do{
       document.write("<br><br>Increase X");
       x++;
       document.write("<br>X = "+x);
       
       if(x<y)
	   document.write("<br>X is lower than Y");
       else
	   document.write("<br>X is not lower than Y");
   }while(x<=y);
}

function decrease(){

    do{
	document.write("<br><br>Decrease Y");
	y--;
	document.write("<br>Y = "+y);

	if(y>x)
	    document.write("<br>Y is higher than X");
	else
	    document.write("<br>Y is not lower higher X");
    }while(y>=x);
}

