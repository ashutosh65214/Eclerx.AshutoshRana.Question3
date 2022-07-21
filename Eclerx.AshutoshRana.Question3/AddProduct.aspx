<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="Eclerx.AshutoshRana.Question3.AddProduct" %>

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
                         <asp:ValidationSummary ForeColor="Red" ID="ValidationSummary1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Category Name</label>
                    </td>
                    <td>
                         <asp:DropDownList ID="DdlCategories" runat="server">
                            <asp:ListItem Value="-1">--Please select--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Product Name</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtProductName" runat="server" />
                        <asp:RegularExpressionValidator Text="*" ID="RfvProductName"  ErrorMessage="Please enter Product name" ControlToValidate="txtProductName" ForeColor="Red" runat="server" />

                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Price</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPrice" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Total Quantity</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtQuantity" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnInsert" runat="server" Text="Insert" OnClick="BtnInsert_Click" />
                        <asp:Button ID="BtnGoto" Text="Go to" runat="server" OnClick="BtnGoto_Click" />
                    </td>
                   
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
