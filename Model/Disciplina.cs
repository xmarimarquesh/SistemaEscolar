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
        descricao = data[0];
        periodo = int.Parse(data[1]);
    }

    protected override string[] SaveTo()
        => new string[]
        {
            descricao,
            periodo.ToString()
        };
}