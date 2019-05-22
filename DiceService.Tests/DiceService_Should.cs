using NUnit.Framework;
using Dice.Services;
using System;

namespace Dice.UnitTests.Services
{
    [TestFixture]
    public class DiceService_Should
    {
        private readonly DiceService _diceService;

        public DiceService_Should()
        {
            _diceService = new DiceService();
        }

        [Test]
        public void UncorrectDice()
        {
            // V�rifie si l'instance du ou des d�s est correcte.
            var result = _diceService.InitDice("1d100");

            Assert.IsFalse(result, "Roll initialization failed.");
        }

        [Test]
        public void UnverifiedDice()
        {
            // V�rifie si le ou les d�s ne respectent pas la syntaxe.
            var result = _diceService.VerifyDice(2);

            Assert.IsFalse(result, "Dies do not respect the correct syntax.");
        }

        [TestCase(3)]
        [TestCase(2)]
        [TestCase(120)]
        public void UnverifiedFaces()
        {
            // V�rifie si les faces ne respectent pas la syntaxe.
            var result = _diceService.VerifyFaces(3);

            Assert.IsFalse(result, "Faces do not respect the correct syntax.");
        }

        [Test]
        public void UnverifiedModifier()
        {
            // V�rifie si le modificateur ne respectent pas la syntaxe.
            var result = _diceService.VerifyModifier(5);

            Assert.IsFalse(result, "Modifier do not respect the correct syntax.");
        }

        [Test]
        public void SumNotFound()
        {  
            // V�rifie si la somme n'est pas trouv�e.
            var result = _diceService.GetDiceSum(1, 100);

            Assert.IsFalse(result, "The sum could not be found.");
        }

        [Test]
        public void DiceByDefaultNotFound()
        {
            // V�rifie si le d� par d�faut est cr��.
            var result = _diceService.GetDiceByDefault();

            Assert.IsFalse(result, "The dice by default could not be found.");
        }

        [Test]
        public void UnhandledErrorSyntax()
        {
            // V�rifie si le message d'erreur n'est pas cr��.
            var result = _diceService.ThrowErrorUnhandledSyntax();

            Assert.IsFalse(result, "Wrong syntax found.");
        }


    }
}