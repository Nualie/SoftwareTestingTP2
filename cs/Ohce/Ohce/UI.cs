namespace Ohce
{
    public class UI
    {
        private readonly MessageInput _interactor;


        public UI(MessageInput input)
        {
            _interactor = input;
        }

       

        public void MainLoop()
        {
            while (true)
            {
                string? input = _interactor.ReadInput();
                if (input == null || input.Equals("quit"))
                {
                    break;
                }
                string reversed = StringReverser.reverse(input);
                _interactor.PrintMessage(reversed);
                if (reversed.Equals(input))
                {
                    _interactor.PrintMessage("That was a palindrom!");
                }
                
            }
           
        }
    }
    public interface MessageInput
    {
        public string ReadInput();
        public void PrintMessage(string str);


    }

    public class Interactor : MessageInput
    {
        private readonly ConsoleInteractor? input;

        public string ReadInput()
        {
            if(input?.ReadInput() != null)
            {
                return input.ReadInput();
            }
            return "";
        }

        public void PrintMessage(string str)
        {
            input?.PrintMessage(str);
        }
    }

    //stub sequence

    public class SpyInteractor : MessageInput
    {
        private List<string> input;
        private List<String> attempts = new List<string>();

        public static SpyInteractor Instance { get; private set; }

        public SpyInteractor(List<string> input)
        {
            this.input = input;
            Instance = this;
        }

        public string ReadInput()
        {
            if (input.Count > 0)
            {
                string str = input[0];
                input.RemoveAt(0);
                return str;
            }
            return "quit";
        }

        public void PrintMessage(string str)
        {
            attempts.Add(str);
            Console.WriteLine(str);
        }

        public List<string> getAttempts()
        {
            return attempts;
        }


    }
}
