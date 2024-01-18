function handleFilters(ids) {
    for (var i = 0; i < ids.length; i++) {
        console.log(ids[i])
        var element = document.getElementById(ids[i]);
        element.style.display = "flex";
    }
}
