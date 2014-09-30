var cousins = [2]

for(var candidate = 3; cousins.length<100; candidate++){
    var is_prime = true

	for(var count=0; is_prime && count<primes.length; count++){
	    if(candidate % primes[count] == 0)
		is_prime = false
	}
    if(is_prime)
	primes.push(candidate)
}
