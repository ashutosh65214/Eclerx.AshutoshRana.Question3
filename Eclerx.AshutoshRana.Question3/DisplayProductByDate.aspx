<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayProductByDate.aspx.cs" Inherits="Eclerx.AshutoshRana.Question3.DisplayProductByDate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <label>From date</label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtFromdate" runat="server" Type="Date"/>

                    </td>
                    <td>
                        <label>To date</label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtToDate" runat="server" Type="Date" />  
                    </td>
                    <td>
                        <asp:Button ID="btnFind" Text="Find" runat="server" OnClick="btnFind_Click" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="GridProduct" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
