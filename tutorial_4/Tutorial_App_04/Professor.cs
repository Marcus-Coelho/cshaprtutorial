namespace Tutorial_App_04
{
    public class Professor : Pessoa //public sealed class to sealed this class
                                           //para deixar selada a classe PROFESSOR
    {
        public double Salario { get; set; }

        public override void SeApresentar()
        {
            Console.WriteLine($"olá, meu nome é {Nome} e sou professor, meu salário é {Salario}");
        }

    }
}
