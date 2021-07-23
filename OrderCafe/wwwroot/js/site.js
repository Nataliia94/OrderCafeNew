// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
    // for details on configuring this project to bundle and minify static web assets.
    // Write your JavaScript code.
function check() {
    var fname = $('#fdish').val();
    var lname = $('#sdish').val();
    if (fname == "" && lname == "") {
        alert("Потрібно вибрати одну із позицій FirstDish або SecondDish");
        return false;
    }
}