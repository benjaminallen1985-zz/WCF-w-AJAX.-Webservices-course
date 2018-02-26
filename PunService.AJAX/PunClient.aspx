<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PunClient.aspx.cs" Inherits="PunService.AJAX.PunClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server">
            <Services>
                <asp:ServiceReference Path="~/PunService.svc" />
            </Services>
        </asp:ScriptManager>
        <script type="text/javascript">
            var service = new PunService();
            service.GetPuns(function(puns) {
                var table = document.getElementById("punlist");
                var output = "fasd";
                for (var i = 0; i < puns.length; i++) {
                    output += "<tr><td>" + puns[i].PunID + "</td><td>" +
                        puns[i].PunID + "</td></tr>";
                }
                table.innerHTML = output;
            }, function () {
                alert("success");
            }, function (error) {
                alert("An error occured: " + error._message);
            }); 
        </script>
        <div>
            <table id="punlist"></table>
        </div>
    </form>
</body>
</html>
