<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ha.aspx.cs" Inherits="Ha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>我为长者续一秒</title>
    <style type="text/css">
        .auto-style1 {
            width: 300px;
        }
        table{
            background-color:black;
        }
        h5{color:darkgray}
        .auto-style2 {
            width: 273px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="ImageButton2" runat="server" ImageUrl="image/title.jpg" Height="179px" style="margin-right: 0px" Width="1351px" />
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
        <asp:ImageButton ID="ImageButton1" runat="server" Height="300px" OnClick="ImageButton1_Click" Width="312px" />
                    </td>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" BackColor="Black" ForeColor="#CC0000" Height="300px" Width="1008px" BorderColor="Black" BorderStyle="None" BorderWidth="0px" Font-Size="XX-Large" ></asp:Label>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Label" Width="312px" style="margin-bottom: 0px"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <audio id="audio" autoplay="autoplay" runat="server"></audio>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        &nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
    </form>
    <hr>
    <h5></h5>
</body>
</html>
