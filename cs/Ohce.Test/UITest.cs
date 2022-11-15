namespace Ohce.Test
{
    public class UITest
    {
        [Test]
        public void MainLoopExample()
        {
            List<String> inputList = new List<String> { "hello", "oto", "quit" };
            List<String> outputList = new List<String> { "olleh", "oto", "That was a palindrom!" };

            UI ui = new UI(new SpyInteractor(inputList));
            ui.MainLoop();
            Assert.That(SpyInteractor.Instance.getAttempts(), Is.EqualTo(outputList));
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