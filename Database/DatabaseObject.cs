using System;

namespace Database;

public abstract class DatabaseObject
{
    internal protected abstract void LoadFrom(string[] data);
    internal protected abstract string[] SaveTo();
    protected string GetNewId => Guid.NewGuid().ToString();
}