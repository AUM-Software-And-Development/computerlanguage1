using System;
using System.Collections.Generic;
using System.Text;

namespace TTSTS
{
    public abstract class Instructions
    {
        /// <summary>
        /// Creates an accessible dictionary for the programmer to link value sums to methods.
        /// </summary>
        public Dictionary<uint, Action> Methods;

        public Instructions()
        {
            this.Methods = new Dictionary<uint, Action>();
        }

        /// <summary>
        /// Method for linking value sum to the method. Will check for any duplicates first.
        /// </summary>
        /// <param name="value">The value from ASCII codes added together.</param>
        /// <param name="method">The method to be performed, or label to jump to when the key value is found.</param>
        public void LinkMethod(uint value, Action method)
        {
            byte overwrite = 0;
            string errorcheck;

            if (this.Methods.ContainsKey(value))
            {
                Console.Write($"{value} has already been used. Would you like to overwrite it? (y then enter for yes) ");
                errorcheck = Console.ReadLine();
                if (errorcheck == "y")
                {
                    overwrite = 1;
                }
                else
                {
                    overwrite = 2;
                }
            }
            switch (overwrite)
            {
                case 1:
                    this.Methods.Remove(value);
                    this.Methods.Add(value, method);
                    break;
                case 2:
                    break;
                default:
                    this.Methods.Add(value, method);
                    break;
            }
        }

        /// <summary>
        /// Method to jump to a location from the method dictionary, also known as a hashtable, or map.
        /// </summary>
        /// <param name="sum">The value summed from the user instruction.</param>
        public void JumpToMethod(uint sum)
        {
            foreach (KeyValuePair<uint, Action> pair in this.Methods)
            {
                if (sum == pair.Key)
                {
                    pair.Value();
                }
            }
        }

        /// <summary>
        /// These methods just change the console color. They can also be made into an array or dictionary, but it doesn't make the code look very elegant.
        /// </summary>
        public void BackgroundToRed()
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }

        public void BackgroundToBlue()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }

        public void BackgroundToGray()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
        }
    }
}
