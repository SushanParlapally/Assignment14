using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Duplicateelements
    {
        public void Duplicateelement() 
        {
            // Define an array with some duplicate elements
            int[] arr = { 1, 2, 3, 2, 4, 5, 3, 6, 7, 1, 8, 1, 9 };

            // Dictionary to store the frequency of each element
            Dictionary<int, int> elementFrequency = new Dictionary<int, int>();

            // Populate the dictionary with frequencies of each element
            foreach (int element in arr)
            {
                if (elementFrequency.ContainsKey(element))
                {
                    elementFrequency[element]++;
                }
                else
                {
                    elementFrequency[element] = 1;
                }
            }

            // Count the number of duplicate elements
            int duplicateCount = 0;
            foreach (KeyValuePair<int, int> kvp in elementFrequency)
            {
                if (kvp.Value > 1)
                {
                    duplicateCount++;
                }
            }

            // Display the result
            Console.WriteLine("Total number of duplicate elements in the array: " + duplicateCount);
        }
    }
}
