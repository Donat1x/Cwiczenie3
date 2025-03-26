namespace ProjektCsharp;

public class OverFillException : Exception
{
    public override string Message
    {
        get
        {
            return "You cant load this Container it's overfilled";
        }
    }
}