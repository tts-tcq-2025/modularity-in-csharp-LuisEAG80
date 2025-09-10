using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int pairNumber = 4;
            ColorPair testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
            ColorPairDebugger.DebugColorPair(pairNumber, testPair1, Color.White, Color.Brown);

            pairNumber = 5;
            testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
            ColorPairDebugger.DebugColorPair(pairNumber, testPair1, Color.White, Color.SlateGray);

            pairNumber = 23;
            testPair1 = ColorPair.GetColorFromPairNumber(pairNumber);
            ColorPairDebugger.DebugColorPair(pairNumber, testPair1, Color.Violet, Color.Green);

            ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumber = ColorPair.GetPairNumberFromColor(testPair2);
            ColorPairDebugger.DebugPairNumber(pairNumber, testPair2, 18);

            testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = ColorPair.GetPairNumberFromColor(testPair2);
            ColorPairDebugger.DebugPairNumber(pairNumber, testPair2, 6);
        }
    }
}
