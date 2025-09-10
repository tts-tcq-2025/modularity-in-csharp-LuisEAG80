using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder;

internal static class ColorPairDebugger
{
    public static void DebugColorPair(int pairNumber, ColorPair colorPair, Color majorExpected, Color minorExpected)
    {
        Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, colorPair);
        Debug.Assert(colorPair.majorColor == majorExpected);
        Debug.Assert(colorPair.minorColor == minorExpected);
    }

    public static void DebugPairNumber(int pairNumber, ColorPair colorPair, int pairNumberExpected)
    {
        Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", colorPair, pairNumber);
        Debug.Assert(pairNumber == pairNumberExpected);
    }
}
