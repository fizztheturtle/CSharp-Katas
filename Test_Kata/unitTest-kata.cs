using System;
using Kata;
using NUnit.Framework;

namespace Test_Kata
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void MultipleOfThreeOrFiveUptoTen()
        {
            Assert.AreEqual(23, Kata_Class.MultipleOf3Or5(10));
        }
        [Test]
        public static void ReverseWord()
        {
            Assert.AreEqual("emocleW", Kata_Class.SpinWords("Welcome"));
        }

        [Test]
        public static void ReverseWordsGreaterThanFive()
        {
            Assert.AreEqual("Hey wollef sroirraw", Kata_Class.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void ReverseWordsGreaterThanFive1()
        {
            Assert.AreEqual("This is a test",  Kata_Class.SpinWords("This is a test"));
        }

        [Test]
        public static void ReverseWordsGreaterThanFive2()
        {
            Assert.AreEqual("This is rehtona test", Kata_Class.SpinWords("This is another test"));
        }

        [Test]
        public static void ReverseWordsGreaterThanFive3()
        {
            Assert.AreEqual("You are tsomla to the last test", Kata_Class.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void ReverseWordsGreaterThanFive4()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Kata_Class.SpinWords("Just kidding there is still one more"));
        }
        [Test]
        public void DeleteNthDuplicate()
        {
            var expected = new int[] { 20, 37, 21 };

            var actual = Kata_Class.DeleteNth(new int[] { 20, 37, 20, 21 }, 1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void DeleteNthDuplicate2()
        {
            var expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

            var actual = Kata_Class.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_InsertRGB_OutputHexadecimal()
        {
            Assert.AreEqual("FFFFFF", Kata_Class.Rgb(255, 255, 255));
            Assert.AreEqual("FFFFFF", Kata_Class.Rgb(255, 255, 300));
            Assert.AreEqual("000000", Kata_Class.Rgb(0, 0, 0));
            Assert.AreEqual("9400D3", Kata_Class.Rgb(148, 0, 211));
            Assert.AreEqual("9400D3", Kata_Class.Rgb(148, -20, 211), "Handle negative numbers.");
            Assert.AreEqual("90C3D4", Kata_Class.Rgb(144, 195, 212));
            Assert.AreEqual("D4350C", Kata_Class.Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }
        [Test]
        public void Test_IsPangram()
        {
            Assert.AreEqual(true, Kata_Class.IsPangram("The 99 quick brown foxes jump over the lazy dog."));
        }
        [Test]
        public void Test_IsPangram1()
        {
            Assert.AreEqual(false, Kata_Class.IsPangram("This is not a Pangram777"));
        }
        [Test]
        public void Test_ExpandedFormNumbers()
        {
            Assert.That(Kata_Class.ExpandedForm(12), Is.EqualTo("10 + 2"));
            Assert.That(Kata_Class.ExpandedForm(42), Is.EqualTo("40 + 2"));
            Assert.That(Kata_Class.ExpandedForm(70300), Is.EqualTo("70000 + 300"));
        }
        [Test]
        public void Test_PigLatin()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Kata_Class.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", Kata_Class.PigIt("This is my string"));
        }

        [Test]
        public void Test_MaxSequenceZero()
        {
            Assert.AreEqual(0, Kata_Class.MaxSequence(new int[0]));
        }
        [Test]
        public void Test_MaxSequenceSix()
        {
            Assert.AreEqual(6, Kata_Class.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }

        [Test]
        public void Test_BreakCamelCase_SpaceOutWords()
        {
            Assert.AreEqual("this Is A Camel Case", Kata_Class.BreakCamelCase("thisIsACamelCase"));
        }
        [Test]
        public void Test_MorseCodeDecoderBasic()
        {
            try
            {
                string input = ".... . -.--   .--- ..- -.. .";
                string expected = "HEY JUDE";

                string actual = Kata_Class.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }
        [Test]
        public void Test_rot13ShouldOutputJoke()
        {
            Assert.AreEqual("In the elevators, the extrovert looks at the OTHER guy's shoes.", Kata_Class.Rot13("Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf."));
        }
        [Test]
        public void Test_rot13ShouldOutputRot13Example()
        {
            Assert.AreEqual("ROT13 example.", Kata_Class.Rot13("EBG13 rknzcyr."));
        }
    }
}