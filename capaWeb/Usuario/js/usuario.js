$("#txtLogin").on('click', function () {
    var correo = $("#exampleInputEmail1").val();
    var clave = $("#exampleInputPassword1").val();
    var xml = '<Usuarios>'+
            '<Usuario>' + '<correo>' + correo + '</correo>' +
            '<clave>' +clave+ '</clave>'+
            '</Usuario>'+
            '</Usuarios>';
        $.ajax({
            type: "POST",
            url: "Login.aspx/buscaUsuario",
            data: JSON.stringify({ xml: xml }),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                alert(response.d);
                var obj = JSON.parse(response.d);
 
                if (obj.length > 0) {
                    $.each(obj, function (key, val) {
                        location.href = 'http://localhost:53002/Home/Home.aspx';
                    });
                } else {
                    location.href = 'http://localhost:53002/Usuario/Login.aspx';
                }
            },
            error: function (result) {
                alert('ERROR: ' + result.status + ' ' + result.statusText);
            }
        });
    
});