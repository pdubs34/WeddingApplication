function handleFilters(ids) {
    for (var i = 0; i < ids.length; i++) {
        console.log(ids[i])
        var element = document.getElementById(ids[i]);
        element.style.display = "flex";
    }
}
function toggleOptions() {
    var options = document.getElementById('options');
    options.style.display = options.style.display === 'block' ? 'none' : 'block';
}

function selectOption(option) {
    var selectedOption = document.getElementById('customSelect').getElementsByClassName('selected-option')[0];
    selectedOption.textContent = option;
    document.getElementById('options').style.display = 'none';
}

function toggleOptions2(selectId) {
    var options = document.getElementById('options' + selectId);
    options.style.display = options.style.display === 'block' ? 'none' : 'block';
}

function selectOption2(option) {
    var selectedOption = document.getElementById('customSelectPrice').getElementsByClassName('selected-option')[0];
    selectedOption.textContent = option;
    document.getElementById('optionsPrice').style.display = 'none';
}