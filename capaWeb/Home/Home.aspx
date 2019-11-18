<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Home.aspx.vb" Inherits="capaWeb.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <table>
        <tr>
            <td>TIPO COMPROBANTE</td>
            <td>
                <input type="radio" name="radioTipo" value="Factura" /><label>Factura</label></td>
            <td>
                <input type="radio" name="radioTipo" value="Boleta" /><label>Boleta</label></td>
        </tr>
        <tr>
            <td>RUC CLIENTE</td>
            <td><input type="text" id="txtRuc" value="" class="form-control"/></td>
        </tr>
        <tr>
            <td>CLIENTE</td>
            <td><input type="text" id="txtCliente" value="" class="form-control"/></td>
        </tr>
        <tr>
            <td>TIPO DE AFECTACION IGV</td>
            <td>
                <select id="cbTipo">
                    <option value="0">--Selecciona--</option>
                    <option value="1">Con IGV</option>
                    <option value="2">Sin IGV</option>
                </select>

            </td>
        </tr>
        <tr>
            <td>VENDEDOR</td>
            <td><input type="text" id="txtVendedor" value="" class="form-control" list="listademodelos"/><div id="listaVendedor"></div></td>
        </tr>
    </table>
    <button type="button" id="btnProducto" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
  Productos
</button>
    <table class="table">
        <thead class="thead-dark">
            <th>Codigo Producto</th>
            <th>Nombre Producto</th>
            <th>Precio</th>
            <th>Cantidad</th>
            <th>Importe</th>
        </thead>
        <tbody id="tbDetalle">

        </tbody>
        <tfoot>
            <tr><td colspan="4" class="txt-right">total</td><td>0.00</td></tr>
        </tfoot>
    </table>


    <!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Lista Productos</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
          <table class="table">
              <thead class="thead-dark">
                  <th>Codigo Producto</th>
                  <th>Nombre Producto</th>
                  <th>Precio</th>
                  <th>Stock</th>
                  <th>/</th>
              </thead>
              <tbody id="tbProducto">
              </tbody>
          </table>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Agregar</button>
      </div>
    </div>
  </div>
</div>
    <script src="../scripts/jquery-3.4.1.js"></script>
    <script src="../scripts/bootstrap.js"></script>
    <script src="../Modulos/documento.js"></script>
</body>
</html>
