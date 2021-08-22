var id = null;

function myMove() {
    console.log("got here")
    var elem = document.getElementById("myAnimation");
    var xpos = 0
    var ypos = 0
    var xvel = 1
    var yvel = 1
    clearInterval(id)
    id = setInterval(frame, 10)
    function frame() {
        if (xpos >= 350) {
            xpos = 350
            xvel = -1 * Math.floor(Math.random()*5)
        }
        if (ypos >= 350) {
            ypos = 350
            yvel = -1 * Math.floor(Math.random()*5)
        }
        if (xpos <= 0) {
            xpos = 0
            xvel = Math.floor(Math.random() * 5)
        }
        if (ypos <= 0) {
            ypos = 0
            yvel = Math.floor(Math.random() * 5)
        }
        xpos += xvel
        ypos += yvel
        console.log(xpos, xvel, ypos, yvel)
        elem.style.top = ypos + 'px'
        elem.style.left = xpos + 'px'
    }
}

document.getElementsByTagName("body")[0].addEventListener("load", myMove())