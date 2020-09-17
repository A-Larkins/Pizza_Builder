/*
Andrew Larkins
09/07/20
CIS3342-1
Pizza Builder Project - ASPX code behind page
*/

using PizzaBuilder.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaBuilder
{
    public partial class PizzaBuilder : System.Web.UI.Page
    {

        // object to easily calculate things.
        CalculatePizzaOrder calc = new CalculatePizzaOrder();


        protected void Page_Load(object sender, EventArgs e)
        {
            // Use request object to get input
            String name = Request.Form["txtName"];
            String number = Request.Form["txtPhoneNumber"];
            String address = Request.Form["txtAddress"];
            String serviceType = Request.Form["serviceType"];
            String size = Request.Form["pizzaSize"];
            String crust = Request.Form["pizzaCrust"];
            String sauce = Request.Form["sauceType"];
            String toppings = Request.Form["toppings"];
            String premiumToppings = Request.Form["premiumToppings"];
            String sideOrder = Request.Form["sideOrder"];
            String sodaOrder = Request.Form["sodaOrder"];
            String tip = Request.Form["txtTip"];

            // Create a pizza order
            PizzaOrder order = new PizzaOrder(name, number, address, serviceType,
                size, crust, sauce, toppings, premiumToppings, sideOrder, sodaOrder,
                tip);

            // Display info
            lblNameDisplay.Text = order.Name;
            lblPhoneDisplay.Text = order.Number;
            lblAddressDisplay.Text = order.Address;

            // Check that the inputs are correct
            
            if(Request.Form["serviceType"] == null)
            {
                // set default service type to pickup
                order.ServiceType = "Pickup";
                // display
                lblPickupOrDeliveryDisplay.Text = order.ServiceType;
            }
            else
            {
                lblPickupOrDeliveryDisplay.Text = order.ServiceType.ToString();
            }

            if(Request.Form["sauceType"] == null)
            {
                // set default sauce to red
                order.Sauce = "Red";
                lblSauceSelectedDisplay.Text = order.Sauce.ToString();
            }
            else
            {
                lblSauceSelectedDisplay.Text = order.Sauce.ToString();
            }

            // see if no checkboxes were clicked on, set count to 0
            // if not null then count toppings and store in order object.
            if(Request.Form["toppings"] == null)
            {
                order.CountToppings = "0";
            }
            else
            {
                // count toppings so they can be calculated
                String toppingsTemp = order.Toppings;
                String[] countToppings = toppingsTemp.Split(',');
                order.CountToppings = countToppings.Count().ToString();
            }

            if (Request.Form["premiumToppings"] == null)
            {
                order.CountPremiumToppings = "0";
            }
            else
            {
                // count toppings so they can be calculated
                String premiumToppingsTemp = order.PremiumToppings;
                String[] countPremiumToppings = premiumToppingsTemp.Split(',');
                order.CountPremiumToppings = countPremiumToppings.Count().ToString();
            }

            if(Request.Form["txtTip"].ToString() == "")
            {
                order.Tip = 0.00m.ToString();
                lblTipSelectedDisplay.Text = order.Tip;
            }
            else
            {
                lblTipSelectedDisplay.Text = order.Tip;
            }

            // Calculate how much the size is
            // Calc the toppings, premium toppings, side order, soda order,
            // subtotal, tax, tip, and grand total.

            order.SizeCost = calc.CalculatePizzaSize(order.Size).ToString();
            order.ToppingsCost = calc.CalculatePizzaToppings(order.CountToppings).ToString();
            order.PremiumToppingsCost = calc.CalculatePremiumPizzaToppings(order.CountPremiumToppings).ToString();
            order.SideOrderCost = calc.CalculateSideOrder(order.SideOrder).ToString();
            order.SodaOrderCost = calc.CalculateSodaOrder(order.SodaOrder).ToString();
            order.Subtotal = calc.CalculateSubtotal(order.SizeCost, order.ToppingsCost, order.PremiumToppingsCost,
                order.SideOrderCost, order.SodaOrderCost).ToString();
            order.Tax = calc.CalculateTax(order.SizeCost, order.ToppingsCost, order.PremiumToppingsCost,
                order.SideOrderCost, order.SodaOrderCost).ToString();
            order.GrandTotal = calc.CalculateGrandTotal(order.SizeCost, order.ToppingsCost, order.PremiumToppingsCost,
                order.SideOrderCost, order.SodaOrderCost, order.Tip).ToString();

            // display
            lblSizeSelectedDisplay.Text =  order.Size.ToString() + " $" + order.SizeCost.ToString();
            lblCrustSelectedDisplay.Text = order.Crust.ToString();
            lblToppingsSelectedDisplay.Text = order.ToppingsCost.ToString();
            lblPremiumToppingsSelectedDisplay.Text = order.PremiumToppingsCost.ToString();
            lblSideOrderSelectedDisplay.Text = order.SideOrder.ToString() + " $" + order.SideOrderCost.ToString();
            lblSodaSelectedDisplay.Text = order.SodaOrder.ToString() + " $" + order.SodaOrderCost.ToString();
            lblSubtotalDisplay.Text = order.Subtotal.ToString();
            lblTaxDisplay.Text = order.Tax.ToString();
            lblGrandTotalSelected.Text = order.GrandTotal.ToString();

            // Convert strings into currency formatted decimals
            decimal num = Convert.ToDecimal(lblTipSelectedDisplay.Text);
            lblTipSelectedDisplay.Text = num.ToString("C");
            num = Convert.ToDecimal(lblToppingsSelectedDisplay.Text);
            lblToppingsSelectedDisplay.Text = num.ToString("C");
            num = Convert.ToDecimal(lblPremiumToppingsSelectedDisplay.Text);
            lblPremiumToppingsSelectedDisplay.Text = num.ToString("C");
            num = Convert.ToDecimal(lblSubtotalDisplay.Text);
            lblSubtotalDisplay.Text = num.ToString("C");
            num = Convert.ToDecimal(lblTaxDisplay.Text);
            lblTaxDisplay.Text = num.ToString("C");
            num = Convert.ToDecimal(lblGrandTotalSelected.Text);
            lblGrandTotalSelected.Text = num.ToString("C");


        }
    }
}
