$("#txtRuc").on('change', function () {
    var txtRuc = $("#txtRuc").val();
    var xml = '<Clientes>' +
            '<Cliente>' + '<ruc>' + txtRuc + '</ruc>' +
            '</Cliente>' +
            '</Clientes>';
    $.ajax({
        type: "POST",
        url: "Home.aspx/buscaClientePorRuc",
        data: JSON.stringify({ xml: xml }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert(response.d);
            var obj = JSON.parse(response.d);

            if (obj.length > 0) {
                $.each(obj, function (key, val) {
                    $("#txtCliente").val(val.nombre);
                });
            } else {
                
            }
        },
        error: function (result) {
            alert('ERROR: ' + result.status + ' ' + result.statusText);
        }
    });

});



$("#txtVendedor").on('keypress', function () {
    var txtVendedor = $("#txtVendedor").val();
    var xml = '<Vendedores>' +
            '<Vendedor>' + '<vendedor>' + txtVendedor + '</vendedor>' +
            '</Vendedor>' +
            '</Vendedores>';
    $.ajax({
        type: "POST",
        url: "Home.aspx/buscaVendedorPorNombre",
        data: JSON.stringify({ xml: xml }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            alert(response.d);
            var obj = JSON.parse(response.d);

            if (obj.length > 0) {
                var vend = $('#listaVendedor').html('');
                var datalista = $('<datalist id="listademodelos">');
                $.each(obj, function (key, val) {

                    datalista.append('<option value="' + val.nombre + '">');

                })
                vend.html(datalista);
            } else {

            }
        },
        error: function (result) {
            alert('ERROR: ' + result.status + ' ' + result.statusText);
        }
    });

});

$("#btnProducto").on('click', function () {
    $('#tbProducto').html('');
    $.ajax({
        type: "POST",
        url: "Home.aspx/listarProducto",
        data: '',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {
            
            var obj = JSON.parse(response.d);

            if (obj.length > 0) {
               
                $.each(obj , function(key, val){
                    var tr=$("<tr>");
                    tr.html("<td>" + val.codigo + "</td>" +
                    "<td>" + val.producto + "</td>" +
                    "<td>" + val.precio + "</td>" +
                    "<td>" + val.stock + "</td>"+
                    "<td><button class='productoLista' id='btnAgregarProducto" + val.codigo + "' data-codigo='" + val.codigo + "' data-producto='" + val.producto + "' data-precio='" + val.precio + "' data-stock='" + val.stock + "'>Agregar</button></td>"
                    );
                    
                    $('#tbProducto').append(tr);
                });
            } else {

            }
        },
        error: function (result) {
            alert('ERROR: ' + result.status + ' ' + result.statusText);
        }
    });

});


$(document).on('click', '.productoLista', function () {
    var codigo = $(this).attr('data-codigo');
    var producto = $(this).attr('data-producto');
    var precio = $(this).attr('data-precio');
    var count = $("#tbDetalle tr").length;
    var arreglo = [];
    var bandera = false;
    if (count>0) {
        $('#tbDetalle tr').each(function () {
            alert($(this).find("td").eq(0).html());
            if (codigo == $(this).find("td").eq(0).html()) {
                bandera = true;
                return;
            }
            // arreglo.push({ codigo: $('#txtCodigo' + x).val(), producto: $(this).find("td").eq(1).html(), precio: $(this).find("td").eq(2).html(), cantidad: $('#txtCantidad' + x).val(), importe: $(this).find("td").eq(5).html() });
        });

        if (bandera==false) {
            arreglo.push({ codigo: codigo, producto: producto, precio: precio, cantidad: 1, importe: parseFloat(precio * 1) });
            var tr = $("<tr>");
            tr.html("<td>" + codigo + "</td>" +
            "<td>" + producto + "</td>" +
            "<td>" + precio + "</td>" +
            "<td>" + 1 + "</td>" +
            "<td>" + parseFloat(precio * 1) + "</td>"
             );

            $('#tbDetalle').append(tr);
        }
    } else {
        $('#tbDetalle').html('');
        arreglo.push({ codigo: codigo, producto: producto, precio: precio, cantidad:1, importe: parseFloat(precio*1) });
        var tr = $("<tr>");
        tr.html("<td>" + codigo + "</td>" +
        "<td>" + producto + "</td>" +
        "<td>" + precio + "</td>" +
        "<td>" + 1 + "</td>" +
        "<td>" + parseFloat(precio* 1) + "</td>"
         );

        $('#tbDetalle').append(tr);
    }




});