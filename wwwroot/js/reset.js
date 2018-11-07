$(document).ready(function () {
    $('.pass_show').append('<span class="ptxt">Mostrar</span>');
});


$(document).on('click', '.pass_show .ptxt', function () {

    $(this).text($(this).text() == "Show" ? "Ocultar" : "Mostrar");

    $(this).prev().attr('type', function (index, attr) { return attr == 'password' ? 'text' : 'password'; });

});  