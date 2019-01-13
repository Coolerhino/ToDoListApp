// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    $.fn.datetimepicker.Constructor.Default.icons = {
        time: 'far fa-clock',
        date: 'far fa-calendar-alt',
        up: 'fas fa-arrow-up',
        down: 'fas fa-arrow-down',
        previous: 'fas fa-chevron-left',
        next: 'fas fa-chevron-right',
        today: 'far fa-calendar-check',
        clear: 'fas fa-trash-alt',
        close: 'fas fa-times'
    };
    $('#datetimepicker5').datetimepicker({ 'format': "DD-MM-YYYY HH:mm" });
    $('#datetimepicker5').datetimepicker();

});
