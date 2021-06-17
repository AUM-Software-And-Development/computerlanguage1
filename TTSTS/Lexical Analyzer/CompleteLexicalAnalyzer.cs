using System;
using System.Collections.Generic;
using System.Text;

namespace TTSTS
{
    public class CompleteLexicalAnalyzer : LexicalAnalyzer, ICompleteAnalyzer
    {
        /// <summary>
        /// Method to add all decimal values from a list of integers.
        /// </summary>
        /// <param name="decimalsToCount">The list you need to summarize.</param>
        /// <returns>The sum of all items within the list.</returns>
        public uint SumOfAllParts(List<uint> decimalsToCount)
        {
            uint sumOfAllParts = 0;

            foreach (uint integer in decimalsToCount)
            {
                sumOfAllParts += integer;
            }

            return sumOfAllParts;
        }
    }
}