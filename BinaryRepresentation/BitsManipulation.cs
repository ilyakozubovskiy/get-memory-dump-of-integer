using System;

namespace BinaryRepresentation
{
    public static class BitsManipulation
    {
        /// <summary>
        /// Get binary memory representation of signed long integer.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Binary memory representation of signed long integer.</returns>
        public static string GetMemoryDumpOf(long number)
        {   
            char[] binary = new char[64];
            for (int i = 0, j = 63; j >= 0; i++, j--)
            {
                binary[i] = (number >> j & 1) > 0 ? '1' : '0';
            }

            return new string(binary);
        }
    }
}
