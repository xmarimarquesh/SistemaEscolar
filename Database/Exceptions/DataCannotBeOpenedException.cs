using System;

namespace Database.Exceptions;

public class DataCannotBeOpenedException : Exception
{
    private string file;

    public DataCannotBeOpenedException(string file) 
        => this.file = file;
        
    public override string Message => $"Data cannot Be Opened: '{file}'";
}