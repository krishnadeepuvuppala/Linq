<%@ Page Language="C#" AutoEventWireup="true" CodeFile="filters.aspx.cs" Inherits="Linq_filters" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $("#anButton").on('click', function () {
                var popupWin = window.open('', '_blank');
                popupWin.document.write('<html><head></head><body onload="window.focus(); window.print(); window.close()"">' + "yo" + '</body></html>');
            });
        });
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnResult" runat="server" Text="Result" OnClick="btnResult_Click" />
            <asp:Label runat="server" ID="lblResult"></asp:Label>
            <a id="anButton" href="#">boom</a>
        </div>
    </form>
</body>
</html>
