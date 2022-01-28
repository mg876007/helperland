// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(window).scroll(
    function () {
        if ($(document).scrollTop() > 100) {
            $("#layout-1 nav").css('background', 'rgb(0,0,0,0.6)');
        }
        else {
            $("#layout-1 nav").css('background', 'rgb(0,0,0,0)');
        }
    }
);
$(window).on('resize', function () {
    var win = $(this);
    if (win.width() >= 1280) {
        $("#intro").css({ "display": "block" });
        $(".main").css({ "background": "none" });
    }
    if (win.width() <= 1280) {
        $("#intro").css({ "display": "none" });
        $(".main").css({ "background": "grey" });
    }
});