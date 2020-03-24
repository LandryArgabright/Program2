<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainUser.aspx.cs" Inherits="Program2_Argabright.MainUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Main User Interface
            </h1>
        </div>
        <p>
            <asp:Button ID="ProfessorButton" Text="Professor Information" runat="server" OnClick="ProfessorButton_Click" />
            &nbsp&nbsp&nbsp&nbsp
            <asp:Button ID="StudentButton" Text="Student Information" runat="server" OnClick="StudentButton_Click" />
        </p>
    </form>
</body>
</html>
