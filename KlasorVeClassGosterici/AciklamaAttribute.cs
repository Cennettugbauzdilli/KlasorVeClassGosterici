using System;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AciklamaAttribute : Attribute
{
    public string Mesaj { get; }

    public AciklamaAttribute(string mesaj)
    {
        Mesaj = mesaj;
    }
}
