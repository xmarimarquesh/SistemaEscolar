using Database;

namespace Model;

public class Aluno : DatabaseObject
{
    
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    protected override void LoadFrom(string[] data)
    {
        Id = int.Parse(data[0]);
        Nome = data[1];
        Idade = int.Parse(data[2]);
    }

    protected override string[] SaveTo()
        => new string[]
            {
                Id.ToString(),
                Nome,
                Idade.ToString()
            };
}