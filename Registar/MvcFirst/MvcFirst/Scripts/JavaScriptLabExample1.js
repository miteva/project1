

function convertFromFeetToMetersJS() {
    var side1 = parseInt(document.getElementById("side1").value);
    var side2 = parseInt(document.getElementById("side2").value);
    

        var result = (2 * side1) + (2 * side2)
        var resultInMeters = result * 1.5;
        document.getElementById("result").innerHTML = result;
        
        var side11 = $("side1").value;
        var side21 = $("side2").value;
}

