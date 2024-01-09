//window.onhashchange = Scroll;
//window.onload = Scroll;

function ToggleNav() {
	var navbarDiv = $("#navbarDiv")[0];
	var navarrow = $("#navarrow")[0];

	if (navbarDiv.style.display == 'none') { 
		navbarDiv.style.display = 'inline';
		navbarDiv.style.overflowY = 'scroll';
		navbarDiv.className = 'shouldShow';
		navarrow.src = ".\\Resource\\left.jpg";
	} else {
		navbarDiv.style.display = 'none';
		navbarDiv.style.overflowY = 'hidden';
		navbarDiv.className = 'shouldRemainHidden';
		navarrow.src = ".\\Resource\\right.jpg";
	}

	return false;
}

function Filter() {
	var input = $("#filter")[0].value.toLowerCase();
	var apis = $("ul#navUL li");

	for (var k = 0; k < apis.length; k++) {
		if(apis[k].innerText.toLowerCase().indexOf(input) != -1)
			apis[k].style.display = null;
		else
			apis[k].style.display = "none";
    }

}

function Print() {
	var shouldToggle = false;

	var navbarDiv = $("#navbarDiv")[0];
	var navarrow = $("#navarrow")[0];

	if (navbarDiv.className == 'shouldShow') {
		ToggleNav();
		shouldToggle = true;
    }

	var section = $("#section1")[0];
	section.style.overflow = 'visible';

	window.print();

	if (shouldToggle){
		ToggleNav();
    }

	section.style.overflowY = 'scroll';
}

function Scroll() {
	//$("#section1")[0].scrollTop = document.getElementById(decodeURI(document.location.hash.substring(1))).offsetTop - 80;
}