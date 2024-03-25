// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(() => {
    $("input.lingo-inp").on("input", elem => {
        elem.currentTarget.nextElementSibling?.focus();
    }).focusin(elem => $(elem.currentTarget).val(""));
    $("input.lingo-inp:first").focus();
});
