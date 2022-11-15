using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Greeter 
{
    private GiveHour sClock;
    public Greeter(GiveHour sClock)
    {
        this.sClock = sClock;
    }



    public string Greet()
    {
        int hour = sClock.GetCurrentHour();
        return hour switch
        {
            (>=6) and (< 12) => "Good morning",
            (>=12) and (<= 19) => "Good afternoon",
            // Fun fact: (>=20) and (<6) does not compile because the compiler
            // thinks this statement is unreachable :P
            _ => "Good night",
        };
    }
}


public interface GiveHour
{
    public int GetCurrentHour();
}


public class Return_Oclock : GiveHour
{
    private readonly OsClock _clock;
    public Return_Oclock()
    {
        _clock = new OsClock();
    }
    public int GetCurrentHour() { return _clock.GetCurrentHour(); }
}
public class Return_9_Oclock : GiveHour { public int GetCurrentHour() { return 9; } }
public class Return_16_Oclock : GiveHour { public int GetCurrentHour() { return 16; } }
public class Return_0_Oclock : GiveHour { public int GetCurrentHour() { return 0; } }
