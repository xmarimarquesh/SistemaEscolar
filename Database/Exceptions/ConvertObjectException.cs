using System;

namespace Database.Exceptions;

public class ConvertObjectException : Exception
{
    public override string Message => "Algum elemento errado";
}