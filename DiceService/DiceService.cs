using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Dice.Services
{
    public class DiceService
    {
        public bool InitDice(string rolls)
        {
            return true;
        }

        public bool VerifyDice(int dice)
        {
            return true;
        }

        public bool VerifyFaces(int dice)
        {
            return true;
        }

        public bool VerifyModifier(int modifier)
        {
            return true;
        }

        public bool GetDiceSum(int dice, int faces)
        {
            return true;
        }

        public bool GetDiceByDefault()
        {
            return true;
        }

        public bool ThrowErrorUnhandledSyntax()
        {
            return true;
        }


    }
}
