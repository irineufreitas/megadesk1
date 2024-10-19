using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk_Bohman
{
    public class RushOrderManager
    {
        private int[,] rushOrderPrices;

        private string GetPathToRushOrderPrices()
        {
            // Construct the path to the rush order prices file dynamically
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\data\rushOrderPrices.txt");
        }

        public RushOrderManager()
        {
            GetRushOrderPrices();
        }

        // Method to read rush order prices from the file
        public void GetRushOrderPrices()
        {
            string[] priceLines;
            try
            {
                // Use the dynamic path to read the rush order prices
                priceLines = File.ReadAllLines(GetPathToRushOrderPrices());
            }
            catch (Exception ex)
            {
                // Handle file reading exceptions
                Console.WriteLine("Error reading the rush order prices file: " + ex.Message);
                return;
            }

            // Ensure we have exactly 9 prices for the 3x3 array
            if (priceLines.Length != 9)
            {
                Console.WriteLine("Invalid rush order prices file format.");
                return;
            }

            // Parse the prices into a 3x3 array
            rushOrderPrices = new int[3, 3];
            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    // Convert the string prices to integers
                    rushOrderPrices[i, j] = int.Parse(priceLines[index]);
                    index++;
                }
            }
        }

        // Method to retrieve the rush order price based on rush days and desk size
        public int GetRushOrderPrice(int rushDays, int deskSize)
        {
            int row;
            if (rushDays == 3)
                row = 0;
            else if (rushDays == 5)
                row = 1;
            else if (rushDays == 7)
                row = 2;
            else
                return 0; // No rush order

            int column;
            if (deskSize <= 1000)
                column = 0;
            else if (deskSize <= 2000)
                column = 1;
            else
                column = 2;

            return rushOrderPrices[row, column];
        }
    }
}