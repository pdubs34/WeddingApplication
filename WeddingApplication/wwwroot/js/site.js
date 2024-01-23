var FilterManager = {
    filters: {
        category: 'All',
        price: 'All',
        availability: 'All'
    },

    setFilter: function (filterName, filter) {
        if (filterName === 'price' || filterName === 'category' || filterName === 'availability') {
            this.filters[filterName] = filter;
            document.getElementById("dropdownMenuLink").textContent = filter;
            this.selectOption();
        } else {
            console.error('Invalid filter name:', filterName);
        }
    },

    selectOption: function () {
        $('.item').css('display', 'none');
        $.ajax({
            type: 'GET',
            url: apiUrl,
            data: this.filters,
            success: function (ids) {
                FilterManager.handleFilters(ids);
            },
            error: function (xhr, status, error) {
                console.error('Failed to get items:', error);
                alert('Failed to get items, displaying all!');
            }
        });
    },

    handleFilters: function (ids) {
        for (var i = 0; i < ids.length; i++) {
            console.log(ids[i]);
            var element = document.getElementById(ids[i]);
            if (element) {
                element.style.display = 'flex';
            }
        }
    }
};

function toggleOptions() {
    var options = document.getElementById('options');
    options.style.display = options.style.display === 'block' ? 'none' : 'block';
}

