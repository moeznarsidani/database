<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dbweb.aspx.cs" Inherits="database.dbweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 668px;
        }
    </style>
</head>
<body style="height: 710px">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            
         
            ID<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            FirstName<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            LastName<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Contact<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:SqlDataSource ID="SqlDataSource3" runat="server"></asp:SqlDataSource>
            <br />
            Email<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            Adress<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click1" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="update" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="delete" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="select" />
            <br />
            <br />
            <asp:TextBox ID="TextBox7" runat="server" Height="207px" TextMode="MultiLine" Width="532px"></asp:TextBox>
        </div>
    </form>
</body>
</html>
