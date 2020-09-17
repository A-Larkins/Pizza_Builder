<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PizzaBuilder.aspx.cs" Inherits="PizzaBuilder.PizzaBuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #frmPizzaBuilder {
            height: 716px;
            width: 539px;
        }
    </style>
</head>
<body style="z-index: 1; left: -10px; top: 12px; position: absolute; height: 19px; width: 1234px">
    <form id="frmPizzaBuilder" runat="server">
        
        <p style="margin-left: 80px">
            Order:</p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblEnterName" runat="server" style="position: relative" Text="Enter Name:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblNameDisplay" runat="server" Text="(name)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblEnterPhoneNumber" runat="server" style="position: relative" Text="Enter Phone Number:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPhoneDisplay" runat="server" Text="(phone)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblEnterAddress" runat="server" style="position: relative" Text="Enter Address:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblAddressDisplay" runat="server" Text="(address)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblPickupOrDelivery" runat="server" Text="Pickup Or Delivery?"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPickupOrDeliveryDisplay" runat="server" Text="(pickup/delivery)"></asp:Label>
&nbsp;&nbsp;&nbsp;
            </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblReceipt" runat="server" Text="Receipt"></asp:Label>
            :</p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblSizeSelection" runat="server" Text="Size Selected:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSizeSelectedDisplay" runat="server" Text="(size selected)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblCrustSelected" runat="server" Text="Crust Selected:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCrustSelectedDisplay" runat="server" Text="(crust selected)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblSauceSelected" runat="server" Text="Sauce Selected:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSauceSelectedDisplay" runat="server" Text="(sauce selected)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblToppingsSelected" runat="server" Text="Toppings Cost:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblToppingsSelectedDisplay" runat="server" Text="(toppings selected)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblSelectedPremiums" runat="server" Text="Premium Toppings Cost:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPremiumToppingsSelectedDisplay" runat="server" Text="(extras selected)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblSelectedSide" runat="server" Text="Side Order Selected:"></asp:Label>
            &nbsp;&nbsp;
            <asp:Label ID="lblSideOrderSelectedDisplay" runat="server" Text="(sideOrderDisplay)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblSodaOrderSelected" runat="server" Text="Soda Selected:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSodaSelectedDisplay" runat="server" Text="(sodaOrderDisplay)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblSubtotal" runat="server" Text="Subtotal:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblSubtotalDisplay" runat="server" Text="(subtotal)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblTax" runat="server" Text="Tax:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblTaxDisplay" runat="server" Text="(tax selected)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblTipSelected" runat="server" Text="Tip Selected:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblTipSelectedDisplay" runat="server" Text="(tip selected)"></asp:Label>
        </p>
        <p style="margin-left: 80px">
            <asp:Label ID="lblGrandTotal" runat="server" Text="Grand Total:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblGrandTotalSelected" runat="server" Text="(total selected)"></asp:Label>
        </p>
        
    </form>
</body>
</html>
