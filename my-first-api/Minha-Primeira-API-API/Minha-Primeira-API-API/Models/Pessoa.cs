namespace Minha_Primeira_API_API.Models
{
    public class Pessoa
    {
        public long Id { get; set; }
        public string? Name { get; set; }


        public Pessoa(int id, string name) {

            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return @$"{Id}.{Name}";
        }
    }
}
