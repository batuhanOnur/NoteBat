window.addHoveredClass = function (id) {
    var element = document.getElementById(id);
    element.classList.remove("addSubIcon");
    element.classList.add("hoveredSubIcon");
}

window.removeHoveredClass = function (id) {
    var element = document.getElementById(id);
    element.classList.remove("hoveredSubIcon");
    element.classList.add("addSubIcon");
}
