using System.Data;
using Database;

namespace Model;

public class Aluno : DatabaseObject
{
    
    public string Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string IDTurma { get; set; }

    public Aluno() => Id = GetNewId;

    protected override void LoadFrom(string[] data)
    {
        Nome = data[1];
        Idade = int.Parse(data[2]);
        IDTurma = data[3];
    }

    protected override string[] SaveTo()
        => new string[]
            {
                Id.ToString(),
                Nome,
                Idade.ToString(),
                IDTurma
            };

    protected override void loadFromSqlRow(DataRow data)
    {
        Id = data[0].ToString();
        Nome = data[1].ToString();
        Idade = int.Parse(data[2].ToString());
        IDTurma = data[3].ToString();
    }

    protected override string saveToSql()
        => $"INSERT INTO [Aluno] VALUES ('{Id}','{Nome}', {Idade}, '{IDTurma}')";
}