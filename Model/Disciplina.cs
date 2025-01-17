using System.Data;
using Database;

namespace Model;

public class Disciplina : DatabaseObject
{   
    public string descricao { get; set; }
    public string ID { get; set; }
    public int periodo { get; set; }

    public Disciplina() => ID = GetNewId;
    protected override void LoadFrom(string[] data)
    {
        ID = data[0];
        descricao = data[1];
        periodo = int.Parse(data[2]);
    }

    protected override string[] SaveTo()
        => new string[]
        {
            ID,
            descricao,
            periodo.ToString()
        };

    protected override void loadFromSqlRow(DataRow data)
    {
        throw new System.NotImplementedException();
    }

    protected override string saveToSql()
    {
        throw new System.NotImplementedException();
    }
}