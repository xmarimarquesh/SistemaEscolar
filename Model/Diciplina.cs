using Database;

namespace Model;

public class Diciplina : DatabaseObject
{   
    public string descricao { get; set; }
    public int periodo { get; set; }

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