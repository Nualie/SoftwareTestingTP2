namespace Ohce.Test
{
    public class GreeterTest
    {

        [Test]
        public void SaysGoodMorningWhenHourIs9()
        {
            Greeter greet = new Greeter(new Return_9_Oclock());
            Assert.Fail("TODO");
        }

        [Test]
        public void SaysGoodAfternoonWhenHourIs16()
        {
            Greeter greet = new Greeter(new Return_16_Oclock());
            Assert.Fail("TODO");
        }

        [Test]
        public void SaysGoodNightWhenHourIs0()
        {
            Greeter greet = new Greeter(new Return_0_Oclock());
            Assert.Fail("TODO");
        }
    }
}