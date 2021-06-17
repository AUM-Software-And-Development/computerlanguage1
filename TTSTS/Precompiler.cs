using System;
using System.Collections.Generic;
using System.Text;

namespace TTSTS
{
    class Precompiler
    {
        /// <summary>
        /// These lists store every character that gets entered.
        /// </summary>
        private static List<string> InputHistory = new List<string>();
        private static List<List<uint>> ASCIIInputHistory = new List<List<uint>>();
        private static List<uint> HistorySums = new List<uint>();

        /// <summary>
        /// This item keeps track of where the computer is operating.
        /// </summary>
        private static int InstructionPointer = 0;

        /// <summary>
        /// These lists keep track of recognized characters.
        /// </summary>
        private static List<List<uint>> ASCIIRecognizedHistory = new List<List<uint>>();
        private static List<uint> RecognizedSums = new List<uint>();

        /// <summary>
        /// This list keeps track of where peiods are to sort instructions.
        /// </summary>
        private static List<uint> DivisionList = new List<uint>();

        /// <summary>
        /// Instantiation of tools for the program.
        /// </summary>
        private static ICompleteAnalyzer completeAnalysis = new CompleteLexicalAnalyzer();
        private static IDynamicInstructions dynamicInstructions = new DynamicInstructions();

        static void Main(string[] args)
        {
            InputHistory.Add(completeAnalysis.GetInput("Please enter a command: "));
            ASCIIInputHistory = completeAnalysis.ConvertStringListToASCIILists(InputHistory);
            HistorySums.Add(completeAnalysis.SumOfAllParts(ASCIIInputHistory[InstructionPointer]));
            completeAnalysis.RemoveNonEnglishValues(ASCIIInputHistory, ref ASCIIRecognizedHistory);
            RecognizedSums.Add(completeAnalysis.SumOfAllParts(ASCIIRecognizedHistory[InstructionPointer]));

            dynamicInstructions.LinkMethod(510, dynamicInstructions.BackgroundToRed);
            dynamicInstructions.LinkMethod(619, dynamicInstructions.BackgroundToBlue);
            dynamicInstructions.LinkMethod(630, dynamicInstructions.BackgroundToGray);

            dynamicInstructions.JumpToMethod(RecognizedSums[InstructionPointer]);
        }
    }
}
