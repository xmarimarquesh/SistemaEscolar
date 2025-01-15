using System;

namespace Database.Exceptions;

public class CustomNotDefinedException : Exception
{
    public override string Message => "Algum elemento errado CUSTOM";
}