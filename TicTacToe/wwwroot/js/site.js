// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.



var selectedChecker

function onClickChecker(event) {
    if (selectedChecker) {
        selectedChecker.setAttribute("stroke", "gold")
    }
    selectedChecker = event.target;
    event.target.setAttribute("stroke", "green");
  
}

function onClickSquare(event) {
    if (selectedChecker) {
        document.getElementById("cx").value = selectedChecker.x % 100;
        document.getElementById("cy").value = selectedChecker.y % 100;
        document.getElementById("sx").value = target.x % 100;
        document.getElementById("sy").value = target.y % 100;

     
    }
}

var checkers = document.getElementsByTagName("circle")
for (var i = 0; i < checkers.length; i++) {
    checkers[i].addEventListener('click', onClick);
}

var squares = document.getElementsByTagName("rect")
for (var j = 0; j < squares.length; j++) {
    squares[j].addEventListener('click', onClickSquare);
}
