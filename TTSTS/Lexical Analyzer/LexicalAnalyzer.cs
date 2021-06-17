using System;
using System.Collections.Generic;
using System.Text;

namespace TTSTS
{
    public abstract class LexicalAnalyzer
    {
        /// <summary>
        /// Method to get input. The parameter allows you to define the original message.
        /// </summary>
        /// <param name="userInputString">Set the first thing to say to the user here.</param>
        /// <returns>What the user entered.</returns>
        public virtual string GetInput(string userInputString)
        {
            /// <summary>
            /// Programmer defined string which is overwritten when the command is read. Saves some stack space.
            /// </summary>
            Console.Write(userInputString);
            userInputString = Console.ReadLine();
            return userInputString;
        }

        /// <summary>
        /// Method to convert any input string into its ASCII equivalent as a list.
        /// </summary>
        /// <param name="stringToConvert">Set the string to convert here.</param>
        /// <returns>The resulting list of ASCII decimal codes.</returns>
        public virtual List<uint> ConvertStringToASCIIList(string stringToConvert)
        {
            List<uint> ASCIIList = new List<uint>();
            uint lengthOfString = (uint)stringToConvert.Length;

            for (int i = 0; i < lengthOfString; i++)
            {
                ASCIIList.Add(stringToConvert[i]);
            }
            return ASCIIList;
        }

        /// <summary>
        /// Method to convert any input list of strings into their ASCII equivalents in numerous lists.
        /// </summary>
        /// <param name="stringsToConvert">Convert any group of strings you need to convert into a list, and pass them here.</param>
        /// <returns>The resulting enumeration.</returns>
        public virtual List<List<uint>> ConvertStringListToASCIILists(List<string> stringsToConvert)
        {
            List<List<uint>> ASCIILists = new List<List<uint>>();

            foreach (string _string in stringsToConvert)
            {
                ASCIILists.Add(this.ConvertStringToASCIIList(_string));
            }
            return ASCIILists;
        }

        /// <summary>
        /// Method to convert any list of ASCII decimals to alphabetical english characters only.
        /// </summary>
        /// <param name="sourceList">The list you need to translate to english characters.</param>
        /// <param name="destinationList">The resulting list without any non-alphabetical english characters.</param>
        public void RemoveNonEnglishValues(List<List<uint>> sourceLists, ref List<List<uint>> destinationLists)
        {
            bool noLetter;
            List<uint> registerList = new List<uint>();

            foreach (List<uint> ASCIIList in sourceLists)
            {
                for (int i = 0; i < ASCIIList.Count; i++)
                {
                    uint registerASCII = ASCIIList[i];

                    if (registerASCII > 64 && registerASCII < 91)
                    {
                        noLetter = false;
                    }

                    else if (registerASCII > 96 && registerASCII < 123)
                    {
                        noLetter = false;
                    }

                    else
                    {
                        noLetter = true;
                    }

                    switch (noLetter)
                    {
                        case true:
                            break;
                        case false:
                            registerList.Add(registerASCII);
                            break;
                    }
                }
                destinationLists.Add(registerList);
                registerList = new List<uint>();
            }
        }
    }
}
