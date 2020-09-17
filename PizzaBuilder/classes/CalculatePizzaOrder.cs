/*
 * Andrew Larkins
 * 09/12/20
 * CIS3342-1 
 * Pizza Builder Project - Class used to calculate pizza order.
 * Contains a bunch of methods with prices.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaBuilder.classes
{
    public class CalculatePizzaOrder
    {
        public decimal CalculatePizzaSize(String pizzaSize)
        {
            decimal cost = 0m;
            switch(pizzaSize)
            {
                case "Personal":
                    cost = 6.50m;
                    break;
                case "Small":
                    cost = 8.95m;
                    break;
                case "Medium":
                    cost = 9.95m;
                    break;
                case "Large":
                    cost = 10.95m;
                    break;
            }
            return cost;
        }

        public decimal CalculatePizzaToppings(String toppings)
        {
            decimal cost = 0m;
            int count = Convert.ToInt32(toppings);
            cost = count * 1.50m;
            return cost;
        }
        public decimal CalculatePremiumPizzaToppings(String premiumToppings)
        {
            decimal cost = 0m;
            int count = Convert.ToInt32(premiumToppings);
            cost = count * 2.50m;
            return cost;
        }
        public decimal CalculateSideOrder(String sideOrder)
        {
            decimal cost = 0m;
            switch (sideOrder)
            {
                case "None":
                    cost = 0m;
                    break;
                case "French Fries - Small":
                    cost = 1.50m;
                    break;
                case "French Fries - Large":
                    cost = 3.00m;
                    break;
                case "8 Piece Buffalo Wings":
                    cost = 5.00m;
                    break;
                case "12 Piece Buffalo Wings":
                    cost = 7.00m;
                    break;
                case "8 Piece Spicy Nugs":
                    cost = 4.00m;
                    break;
                case "12 Piece Spicy Nugs":
                    cost = 6.00m;
                    break;
            }
            return cost;
        }
        public decimal CalculateSodaOrder(String sodaOrder)
        {
            decimal cost = 0m;
            switch (sodaOrder)
            {
                case "None":
                    cost = 0m;
                    break;
                case "Coke":
                    cost = 2.25m;
                    break;
                case "Dr. Pepper":
                    cost = 2.50m;
                    break;
                case "Mountain Dew":
                    cost = 1.79m;
                    break;
                case "Iced Tea":
                    cost = 2.25m;
                    break;
                case "Root Beer":
                    cost = 3.00m;
                    break;
                case "Sprite":
                    cost = 2.25m;
                    break;
            }
            return cost;
        }

        public decimal CalculateSubtotal(String size, String toppings, String premiumToppings,
            String sideOrder, String sodaOrder)
        {
            decimal cost = 0m;
            cost = Convert.ToDecimal(size) + Convert.ToDecimal(toppings) +
                Convert.ToDecimal(premiumToppings) + Convert.ToDecimal(sideOrder) +
                Convert.ToDecimal(sodaOrder);
            return cost;
        }
        
        public decimal CalculateTax(String size, String toppings, String premiumToppings,
            String sideOrder, String sodaOrder)
        {
            decimal subtotal = 0m;
            subtotal = Convert.ToDecimal(size) + Convert.ToDecimal(toppings) +
                Convert.ToDecimal(premiumToppings) + Convert.ToDecimal(sideOrder) +
                Convert.ToDecimal(sodaOrder);
            decimal pennsylvaniaTax = 0.06m;
            return subtotal * pennsylvaniaTax;
        }

        public decimal CalculateGrandTotal(String size, String toppings, String premiumToppings,
            String sideOrder, String sodaOrder, String tip)
        {
            decimal cost = 0m;
            cost = CalculateSubtotal(size, toppings, premiumToppings,
            sideOrder, sodaOrder) + CalculateTax(size, toppings, premiumToppings,
            sideOrder, sodaOrder) + Convert.ToDecimal(tip);
            return cost;

        }

    }
}
