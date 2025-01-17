using System;
using System.Collections.Generic;
using System.Data;
using Database;

namespace Model;

public class Professor : DatabaseObject
{
    
    public string ID { get; set; }
    public string Nome { get; set; }
    public string Formacao { get; set; }
    public string IDDisciplina { get; set; }

    public Professor() => ID = GetNewId;

    protected override void LoadFrom(string[] data)
    {
        ID = data[0];
        Nome = data[1];
        Formacao = data[2];
        IDDisciplina = data[3];
    }

    protected override string[] SaveTo()
        => new string[]
            {
                ID.ToString(),
                Nome,
                Formacao,
                IDDisciplina
            };

    protected override void loadFromSqlRow(DataRow data)
    {
        throw new NotImplementedException();
    }

    protected override string saveToSql()
    {
        throw new NotImplementedException();
    }
}