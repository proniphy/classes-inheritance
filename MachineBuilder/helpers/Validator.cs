using System;

namespace MachineBuilder.helpers
{
    internal class Validator
    {
        internal static void ValidateIfPositive(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("wheel can not be 0 or negative!");
            }
        }
        internal static void ValidateIfPositive(float number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("number can not be 0 or negative!");
            }
        }
        internal static void ValidateString(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException("Please eneter some text");
            }
        }

    }
}
