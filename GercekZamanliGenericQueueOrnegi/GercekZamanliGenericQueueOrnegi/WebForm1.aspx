<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GercekZamanliGenericQueueOrnegi.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-weight: 700">
    <form id="form1" runat="server">
        <div>
            <table style="border:1px solid black; font-family:Arial; text-align:center">
    <tr>
        <td>
            <b>Counter 1</b>
        </td>
        <td>
            <b>Counter 2</b>
        </td>
        <td>
            <b>Counter 3</b>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtCounter1" Width="150px" Font-Size="Large" runat="server"
                            BackColor="#000099" ForeColor="White">
            </asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtCounter2" Width="150px" Font-Size="Large" runat="server"
                            BackColor="#000099" ForeColor="White">
            </asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="txtCounter3" Width="150px" Font-Size="Large" runat="server"
                            BackColor="#000099" ForeColor="White">
            </asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnCounter1" Width="150px" runat="server" Text="Next" OnClick="btnCounter1_Click" 
                 />
        </td>
        <td>
            <asp:Button ID="btnCounter2" Width="150px" runat="server" Text="Next" OnClick="btnCounter2_Click" 
                 />
        </td>
        <td>
            <asp:Button ID="btnCounter3" Width="150px" runat="server" Text="Next" OnClick="btnCounter3_Click" 
                 />
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:TextBox ID="txtNextToken" Font-Size="Large" Width="500px" runat="server"
                        BackColor="#003300" ForeColor="White">
            </asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:ListBox ID="listTokens" Width="100px" Font-Size="Medium" runat="server">
            </asp:ListBox>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Button ID="btnPrintToken" runat="server" Text="Print Token" 
                onclick="btnPrintToken_Click" />
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Label ID="lblCurrentStatus" runat="server" Font-Size="Medium">
            </asp:Label>
        </td>
    </tr>
</table>
        </div>
    </form>
</body>
</html>
