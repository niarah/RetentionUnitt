// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var retention = {
    filterClick: function (elem) {
        let searchName = elem.val();
        let clName = elem.data("id");
        $(".clientsRows").removeClass('d-none')
        $.each($("." + clName), function (index, value) {
            console.log(searchName);
            console.log($(this).text());
            console.log(searchName != $(this).text());
            if (searchName != $(this).text()) {
                let elem = $(this);
                let divElem = elem[0].parentNode.parentNode;
                console.log(divElem);
                console.log(divElem.classList);
                divElem.classList.add('d-none');
                //elem[0].parentNode.parentNode.addClass('d-none');
            }
        });
    }
}

