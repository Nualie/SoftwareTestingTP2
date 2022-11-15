namespace Ohce.Test
{
    public class UITest
    {
        [Test]
        public void MainLoopExample()
        {
            UI ui = new UI(new send_hello());
            Assert.That(ui.Main(), Is.EqualTo("olleh"));
            ui = new UI(new send_oto());
            Assert.That(ui.Main(), Is.EqualTo("oto"));
            ui = new UI(new send_quit());
            Assert.That(ui.Main(), Is.EqualTo("quit"));
        }


    }
}
/*
            TODO: check that given the following inputs:
             - hello
             - oto
             - quit

            the following messages are shown to the user:
             - olleh
             - oto
             That was a palindrome!
             - (Nothing is displayed, the program stops)

           */