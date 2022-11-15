namespace Ohce.Test
{
    public class GreeterTest
    {

        [Test]
        public void SaysGoodMorningWhenHourIs9()
        {
            Greeter greet = new Greeter(new Return_9_Oclock());
            Assert.That(greet.Greet(), Is.EqualTo("Good morning"));
        }

        [Test]
        public void SaysGoodAfternoonWhenHourIs16()
        {
            Greeter greet = new Greeter(new Return_16_Oclock());
            Assert.That(greet.Greet(), Is.EqualTo("Good afternoon"));
        }

        [Test]
        public void SaysGoodNightWhenHourIs0()
        {
            Greeter greet = new Greeter(new Return_0_Oclock());
            Assert.That(greet.Greet(), Is.EqualTo("Good night"));
        }
    }
}