<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="person.aspx.cs" Inherits="web_form.person" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 0px">
        </div>
        <asp:TextBox ID="nameTxtBox" runat="server" placeholder="Name"></asp:TextBox>
        <asp:TextBox ID="cityTxtBox" runat="server" placeholder="City"></asp:TextBox>
        <asp:TextBox ID="contactTxtBox" runat="server" placeholder="Contact"></asp:TextBox>

        <asp:Button ID="insertBtn" runat="server" Text="Insert" OnClick="insertBtn_Click" />
        <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />
        <asp:Button ID="deleteBtn" runat="server" Text="Delete" OnClick="deleteBtn_Click" />

        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>

    </form>
</body>
</html>
