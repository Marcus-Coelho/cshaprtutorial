namespace Tutorial_App_04
{
    public class Carro
    {
        public string Name { get; set; }
        public string Montadora { get; set; }

        public void DescreverCarro()
        {
            Console.WriteLine($"o meu carro é o(a) {Name} {Montadora}");
        }
    }
}
