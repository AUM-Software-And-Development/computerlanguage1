using System;
using System.Collections.Generic;
using System.Text;

namespace TTSTS
{
    /// <summary>
    /// This is intended for computational methods like if statements that eventually interface with dynamic classes.
    /// </summary>
    interface IHardCodedInstructions
    {
        void JumpToMethod(uint sum);
    }
}
