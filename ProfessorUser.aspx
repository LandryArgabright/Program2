<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfessorUser.aspx.cs" Inherits="Program2_Argabright.ProfessorUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Professors
            </h1>
            <p>
                <asp:ListBox ID="ListBox1" runat="server" Height="200px" Width="900px"></asp:ListBox>
            </p>
            <p>
                <asp:Button ID="ReturnButton" Text="Return" runat="server" OnClick="ReturnButton_Click" />
            </p>
        </div>
    </form>
</body>
</html>