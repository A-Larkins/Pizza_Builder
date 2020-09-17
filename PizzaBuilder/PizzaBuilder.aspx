<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PizzaBuilder.aspx.cs" Inherits="PizzaBuilder.PizzaBuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #frmPizzaBuilder {
            height: 716px;
            width: 1148px;

        }
        .theTable {
            width: 80%;
            font-family: "Trebuchet MS", Arial, Helvetica, sans-serif;
            border-collapse: collapse;
            margin: auto;
            font-size: 36px;
        }
        
        #theTable td, #theTable th {
            border: 1px solid #ddd;
            padding: 20px;
            border-width: thick;
            border-color: #66ff00;
        }
        
        #theTable tr {
            background-color: #00c4de;
        }
        
            #theTable tr:hover {
                background-color: #0089de;
            }
        
        #theTable th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #4CAF50;
            color: white;
        }
        
        body {
            background-color: #510061;
        }
    </style>
</head>
<body style="z-index: 1; left: -10px; top: 12px; position: absolute; height: 19px; width: 1234px" >
    <form id="frmPizzaBuilder" runat="server" >
        
        <table align="center" class="theTable" id="theTable">
            <tr>
                <td>
            <asp:Label ID="lblReceipt" runat="server" Text="Your Receipt" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblEnterName" runat="server" style="position: relative" Text="Name:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblNameDisplay" runat="server" Text="(name)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblEnterPhoneNumber" runat="server" style="position: relative" Text="Phone Number:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblPhoneDisplay" runat="server" Text="(phone)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
            <asp:Label ID="lblEnterAddress" runat="server" style="position: relative" Text="Address:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style2">
            <asp:Label ID="lblAddressDisplay" runat="server" Text="(address)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblPickupOrDelivery" runat="server" Text="Service" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblPickupOrDeliveryDisplay" runat="server" Font-Bold="True" Font-Size="Large" Text="(service)"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblSizeSelection" runat="server" Text="Size:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblSizeSelectedDisplay" runat="server" Text="(size selected)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblCrustSelected" runat="server" Text="Crust:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblCrustSelectedDisplay" runat="server" Text="(crust selected)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblSauceSelected" runat="server" Text="Sauce:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblSauceSelectedDisplay" runat="server" Text="(sauce selected)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblToppingsSelected" runat="server" Text="Toppings:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblToppingsSelectedDisplay" runat="server" Text="(toppings selected)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblSelectedPremiums" runat="server" Text="Premium Toppings:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblPremiumToppingsSelectedDisplay" runat="server" Text="(extras selected)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblSelectedSide" runat="server" Text="Side Order:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblSideOrderSelectedDisplay" runat="server" Text="(sideOrderDisplay)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblSodaOrderSelected" runat="server" Text="Soda:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblSodaSelectedDisplay" runat="server" Text="(sodaOrderDisplay)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblSubtotal" runat="server" Text="Subtotal:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblSubtotalDisplay" runat="server" Text="(subtotal)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblTax" runat="server" Text="Tax:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblTaxDisplay" runat="server" Text="(tax selected)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblTipSelected" runat="server" Text="Tip Selected:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblTipSelectedDisplay" runat="server" Text="(tip selected)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
            <asp:Label ID="lblGrandTotal" runat="server" Text="Grand Total:" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td>
            <asp:Label ID="lblGrandTotalSelected" runat="server" Text="(total selected)" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
            </tr>
        </table>
        
    </form>
</body>
</html>
