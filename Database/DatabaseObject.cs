using System;
using System.Data;

namespace Database;

public abstract class DatabaseObject
{
    internal protected abstract void LoadFrom(string[] data);
    internal protected abstract string[] SaveTo();
    internal protected abstract void loadFromSqlRow(DataRow data);
    internal protected abstract string saveToSql();
    protected string GetNewId => Guid.NewGuid().ToString();
}