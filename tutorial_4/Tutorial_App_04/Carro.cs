namespace Tutorial_App_04
{
    public class Carro
    {
        public string Name { get; set; }
        public string Montadora { get; set; }

        public void DescreverCarro()
        {
            Console.WriteLine($"My car is {Name} by {Montadora}");
        }

        public string DescreverCarrotostring()
        {
            return $"My car is {Name} by {Montadora}";
        }
    }
}
