using System;
using System.Collections.Generic;
using System.Text;

namespace TTSTS
{
    /// <summary>
    /// In order for the user to be able to define these quality of life features, you must first create a method that makes them accessible.
    /// </summary>
    public interface IDynamicInstructions
    {
        void LinkMethod(uint value, Action method);
        void JumpToMethod(uint sum);
        void BackgroundToRed();
        void BackgroundToBlue();
        void BackgroundToGray();
    }
}
