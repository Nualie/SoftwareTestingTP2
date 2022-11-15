namespace Ohce
{
    public class UI
    {
        private readonly messageInput _interactor;

        public UI(messageInput input)
        {
            _interactor = input;
        }

        public string Main()
        {
            string? input = _interactor.ReadInput();
            if (input == null || input.Equals("quit"))
            {
                return "quit";
            }
            string reversed = StringReverser.reverse(input);
            _interactor.PrintMessage(reversed);
            if (reversed.Equals(input))
            {
                _interactor.PrintMessage("That was a palindrom!");
            }
            return reversed;
        }

        public void MainLoop()
        {
            while (!(Main() == "quit")) ;
           
        }
    }
    public interface messageInput
    {
        public string ReadInput();
        public void PrintMessage(string str);


    }

    public class Interactor : messageInput
    {
        private readonly ConsoleInteractor? input;
        public string ReadInput()
        {
            if(input?.ReadInput() != null)
            {
#pragma warning disable CS8603 // Possible null reference return.
                return input.ReadInput();
#pragma warning restore CS8603 // Possible null reference return.
            }
            return "";
        }

        public void PrintMessage(string str)
        {
            input?.PrintMessage(str);
        }
    }

    //stub hello
    public class send_hello : messageInput 
    {
        public void PrintMessage(string str)
        {
            Console.WriteLine(str);
        }

        public string ReadInput()
        {
            return "hello";
        }
    }

    public class send_oto : messageInput
    {
        public void PrintMessage(string str)
        {
            Console.WriteLine(str);
        }

        public string ReadInput()
        {
            return "oto";
        }
    }

    public class send_quit : messageInput
    {
        public void PrintMessage(string str)
        {
            Console.WriteLine(str);
        }

        public string ReadInput()
        {
            return "quit";
        }
    }
}
