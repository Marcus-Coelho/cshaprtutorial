namespace Tutorial_App_04
{

    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            ICalculadora calc = new Calculadora(); //ICALCULADORA NÃO É PERMITIDO, MAS CALCULADORA É.
            Console.WriteLine(calc.multiplicar(3, 5));


            //Pessoa p1 = new Pessoa();
            //Console.WriteLine("Qual seu nome?");
            //p1.Nome = Console.ReadLine();
            //p1.Idade = 38;
            //p1.SeApresentar();
            //Console.WriteLine();

            //Aluno al1 = new Aluno();
            //al1.Nome = "joão";
            //al1.Idade = 12;
            //al1.SeApresentar();


            //Retangulo ret = new Retangulo();
            //Console.WriteLine("largura do lote");

            //Console.WriteLine("comprimento do lote");

            //ret.DefinirDimensoes(50, 50);
            //Console.WriteLine("tenho um lote de");
            //Console.WriteLine(ret.ObterArea());


            //Carro carro = new Carro();
            //carro.Name = "Fox";
            //carro.Montadora = "Volks";
            //carro.DescreverCarro();

            //Conta conta = new Conta(); //não instancia classe abstrata, solução é instanciar classe filha chamada de CORRETE

            //Corrente corrente = new Corrente();

            //corrente.creditar(51.3);

            //corrente.ExibirSaldo();

            //Computador computador = new Computador();

            //Console.WriteLine(computador.ToString()); //imprime o nome da classe Computador, que está vazia.



        }
    }
}