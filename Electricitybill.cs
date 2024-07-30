using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Electricitybill
    {
        public void Ebill()
        {
            // Input customer details
            Console.Write("Enter Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            double unitsConsumed = double.Parse(Console.ReadLine());

            // Calculate charges
            double chargePerUnit;
            if (unitsConsumed <= 199)
            {
                chargePerUnit = 1.20;
            }
            else if (unitsConsumed >= 200 && unitsConsumed < 400)
            {
                chargePerUnit = 1.50;
            }
            else if (unitsConsumed >= 400 && unitsConsumed < 600)
            {
                chargePerUnit = 1.80;
            }
            else
            {
                chargePerUnit = 2.00;
            }

            double amountCharged = unitsConsumed * chargePerUnit;
            double surcharge = 0;

            if (amountCharged > 400)
            {
                surcharge = amountCharged * 0.15;
            }

            double netAmount = amountCharged + surcharge;

            // Ensure minimum bill amount
            if (netAmount < 100)
            {
                netAmount = 100;
            }

            // Output the bill details
            Console.WriteLine($"\nCustomer IDNO : {customerId}");
            Console.WriteLine($"Customer Name : {customerName}");
            Console.WriteLine($"Unit Consumed : {unitsConsumed}");
            Console.WriteLine($"Amount Charges @Rs. {chargePerUnit} per unit : {amountCharged:F2}");
            Console.WriteLine($"Surcharge Amount : {surcharge:F2}");
            Console.WriteLine($"Net Amount Paid By the Customer : {netAmount:F2}");
        }
    }
}
