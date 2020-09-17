/*
Andrew Larkins
09/07/20
CIS3342-1
Pizza Builder Project - Pizza Order class used to store information about the order.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaBuilder.classes
{
    public class PizzaOrder
    {
        // Customer order information
        String name;
        String number;
        String address;
        String serviceType;
        String size;
        String crust;
        String sauce;
        String toppings;
        String premiumToppings;
        String sideOrder;
        String sodaOrder;
        String tip = "0";

        // Customer cost of order
        String sizeCost;
        String crustCost;
        String toppingsCost;
        String premiumToppingsCost;
        String countToppings;
        String countPremiumToppings;
        String sideOrderCost;
        String sodaOrderCost;
        String subTotal;
        String tax;
        String grandTotal;

        // constructor
        public PizzaOrder(String name, String number, String address, String serviceType,
            String size, String crust, String sauce, String toppings, String premiumToppings,
            String sideOrder, String sodaOrder, String tip)
        {
            this.name = name;
            this.number = number;
            this.address = address;
            this.serviceType = serviceType;
            this.size = size;
            this.crust = crust;
            this.sauce = sauce;
            this.toppings = toppings;
            this.premiumToppings = premiumToppings;
            this.sideOrder = sideOrder;
            this.sodaOrder = sodaOrder;
            this.tip = tip;

        }

        // setters and getters
        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public String Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        public String Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        public String ServiceType
        {
            get
            {
                return this.serviceType;
            }
            set
            {
                this.serviceType = value;
            }
        }
        public String Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public String Crust
        {
            get
            {
                return this.crust;
            }
            set
            {
                this.crust = value;
            }
        }
        public String Sauce
        {
            get
            {
                return this.sauce;
            }
            set
            {
                this.sauce = value;
            }
        }
        public String Toppings
        {
            get
            {
                return this.toppings;
            }
            set
            {
                this.toppings = value;
            }
        }
        public String PremiumToppings
        {
            get
            {
                return this.premiumToppings;
            }
            set
            {
                this.premiumToppings = value;
            }
        }
        public String SideOrder
        {
            get
            {
                return this.sideOrder;
            }
            set
            {
                this.sideOrder = value;
            }
        }
        public String SodaOrder
        {
            get
            {
                return this.sodaOrder;
            }
            set
            {
                this.sodaOrder = value;
            }
        }
        public String Tip
        {
            get
            {
                return this.tip;
            }
            set
            {
                this.tip = value;
            }
        }
        public String SizeCost
        {
            get
            {
                return this.sizeCost;
            }
            set
            {
                this.sizeCost = value;
            }
        }
        public String CrustCost
        {
            get
            {
                return this.crustCost;
            }
            set
            {
                this.crustCost = value;
            }
        }
        public String ToppingsCost
        {
            get
            {
                return this.toppingsCost;
            }
            set
            {
                this.toppingsCost = value;
            }
        }
        public String PremiumToppingsCost
        {
            get
            {
                return this.premiumToppingsCost;
            }
            set
            {
                this.premiumToppingsCost = value;
            }
        }
        public String CountToppings
        {
            get
            {
                return this.countToppings;
            }
            set
            {
                this.countToppings = value;
            }
        }
        public String CountPremiumToppings
        {
            get
            {
                return this.countPremiumToppings;
            }
            set
            {
                this.countPremiumToppings = value;
            }
        }
        public String SideOrderCost
        {
            get
            {
                return this.sideOrderCost;
            }
            set
            {
                this.sideOrderCost = value;
            }
        }
        public String SodaOrderCost
        {
            get
            {
                return this.sodaOrderCost;
            }
            set
            {
                this.sodaOrderCost = value;
            }
        }
        public String Subtotal
        {
            get
            {
                return this.subTotal;
            }
            set
            {
                this.subTotal = value;
            }
        }
        public String Tax
        {
            get
            {
                return this.tax;
            }
            set
            {
                this.tax = value;
            }
        }
        public String GrandTotal
        {
            get
            {
                return this.grandTotal;
            }
            set
            {
                this.grandTotal = value;
            }
        }




    }
}
