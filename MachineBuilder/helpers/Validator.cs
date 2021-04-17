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
                throw new ArgumentOutOfRangeException("wheel can not be 0 or negative!");
            }
        }
    }
}
