<%@ Page Language="C#" AutoEventWireup="true" CodeFile="intArray.aspx.cs" Inherits="Linq_intArray" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button id="btnResult" runat ="server" Text="Result" OnClick="GetResult_Click"/>
            <asp:Label runat="server" id ="lblResult"></asp:Label>
        </div>
    </form>
</body>
</html>
