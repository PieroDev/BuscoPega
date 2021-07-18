$(document).ready(function () {
    $('.descriEmpleo').on("click", function () {
        alert('Se ha clickeado este parrafo');
    });
    $('.descriEmpleo').each(function () {
        let texto = $(this).text();
        let textoSalida = texto.substring(0, 100);
        $(this).html(textoSalida + "...");
        console.log(textoSalida);
    })

    $('.confiContra').focusout(function () {
        console.log('Se apreto un boton')
        let contra1 = $('.textcontra').val();
        let contra2 = $(this).val();
        console.log(contra1 + '   ' + contra2);
        if (contra1 === contra2) {
            $('.lbl-msj').html('Contraseña correcta');
            $('.lbl-msj').removeClass('error');
            $('.lbl-msj').addClass('correcto');
            
        }
        else {
            $('.lbl-msj').html('Contraseña incorrecta');
            $('.lbl-msj').removeClass('correcto');
            $('.lbl-msj').addClass('error');
        }





        



    })




   
});





