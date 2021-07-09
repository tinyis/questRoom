var rooms = document.getElementById('mainDiv').children;

var roomFirst = rooms[0].children;

for (var i = 0; i < roomFirst.length; i++) {

    var roomPartFirst = roomFirst[i];

    if (roomPartFirst.className == "picDiv") {
        roomPartFirst.style.backgroundColor = "#fecc50";
    }

    else if (roomPartFirst.className == "titleDiv") {
        roomPartFirst.style.backgroundColor = "#1e0521";
    }

    else if (roomPartFirst.className == "descriptionDiv") {
        roomPartFirst.style.backgroundColor = "#1e0521";
    }

    else if (roomPartFirst.className == "moreDiv") {
        roomPartFirst.style.backgroundColor = "#fecc50";
    }
}

for (var i = 0; i < rooms.length; i+=1) {

    rooms[i].style.borderRight = "2px solid #0be7fb";
}


for (var i = 1; i < rooms.length; i += 2) {

    var roomViolet = rooms[i].children;

    if (i + 1 < rooms.length)
        var roomViolet1 = rooms[i+1].children;

    for (var i = 0; i < roomViolet.length; i++) {

        var roomPart1 = roomViolet[i];
        if (roomPart1.className == "picDiv") {
            roomPart1.style.backgroundColor = "#ff6d69";    
        }

        else if (roomPart1.className == "titleDiv") {
            roomPart1.style.backgroundColor = "#010b8b";
        }

        else if (roomPart1.className == "descriptionDiv") {
            roomPart1.style.backgroundColor = "#010b8b";
        }

        else if (roomPart1.className == "moreDiv") {
            roomPart1.style.backgroundColor = "#ff6d69";
        }
    }

    for (var i = 0; i < roomViolet1.length; i++) {

        var roomPart2 = roomViolet1[i];
        if (roomPart2.className == "picDiv") {
            roomPart2.style.backgroundColor = "#ff6d69";
        }

        else if (roomPart2.className == "titleDiv") {
            roomPart2.style.backgroundColor = "#010b8b";
        }

        else if (roomPart2.className == "descriptionDiv") {
            roomPart2.style.backgroundColor = "#010b8b";
        }

        else if (roomPart2.className == "moreDiv") {
            roomPart2.style.backgroundColor = "#ff6d69";
        }
    }
}

for (var i = 3; i < rooms.length; i += 2) {

    var roomBlue = rooms[i].children;

    if (i + 1 < rooms.length)
        var roomBlue1 = rooms[i + 1].children;

    for (var i = 0; i < roomBlue.length; i++) {

        var roomPart3 = roomBlue[i];
        if (roomPart3.className == "picDiv") {
            roomPart3.style.backgroundColor = "#fecc50";
        }

        else if (roomPart3.className == "titleDiv") {
            roomPart3.style.backgroundColor = "#1e0521";
        }

        else if (roomPart3.className == "descriptionDiv") {
            roomPart3.style.backgroundColor = "#1e0521";
        }

        else if (roomPart3.className == "moreDiv") {
            roomPart3.style.backgroundColor = "#fecc50";
        }

    }

    for (var i = 0; i < roomBlue1.length; i++) {

        var roomPart4 = roomBlue1[i];
        if (roomPart4.className == "picDiv") {
            roomPart4.style.backgroundColor = "#fecc50";
        }

        else if (roomPart4.className == "titleDiv") {
            roomPart4.style.backgroundColor = "#1e0521";
        }

        else if (roomPart4.className == "descriptionDiv") {
            roomPart4.style.backgroundColor = "#1e0521";
        }

        else if (roomPart4.className == "moreDiv") {
            roomPart4.style.backgroundColor = "#fecc50";
        }

    }
}



