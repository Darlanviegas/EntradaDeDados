namespace Entrada_de_Dados_CSharp
{
    public class Usuario
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string Profession { get; set; }
        public Usuario(string name, int age, double weight, double height, string profession)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            Profession = profession;
        }
        
    }


}