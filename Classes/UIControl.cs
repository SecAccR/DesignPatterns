using System;

namespace Classes;

public abstract class UIControl
{
    public void Enable()
    {
        Console.WriteLine("Enabled");
    }

    public abstract void Draw();
}