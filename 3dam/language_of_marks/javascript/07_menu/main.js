function enlight(element, event){
    event = event || window.event
	var header = element.getElementsByTagName("h1")[0]
	header.style.backgroundColor = "Cyan"
}

function vanish(element, event){
    event = event || window.event
	var header = element.getElementsByTagName("h1")[0]
	header.style.backgroundColor = "Black"
}


