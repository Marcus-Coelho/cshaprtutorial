namespace Tutorial_App_04
{
    public class Professor : Pessoa //sealed para deixar selada a classe PROFESSOR
    {
        public double salario { get; set; }

        public override void SeApresentar()
        {
            Console.WriteLine($"olá, meu nome é {Nome} e sou professor, meu salário é {salario}");
        }

    }
}
