namespace Tutorial_App_04
{

    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {

            Pessoa p1 = new Pessoa();
            Console.WriteLine("PROGRAM: What is your name?");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("PROGRAM: What is your age?");
            p1.Idade = Int16.Parse(Console.ReadLine());
            p1.SeApresentar();
            Console.WriteLine();
            
            Console.WriteLine($"PROGRAM: Welcome " + p1.Nome + " I'm a program, created by Marcus Dev in his learning process, I hope to help you in this journey\n");
            Thread.Sleep(2000);
            Console.WriteLine("PROGRAM: Let's try and stress the program\nif you is a teacher, imagine one imaginarium student, type his name\n");

            Aluno al1 = new Aluno();
            al1.Nome = Console.ReadLine();
            Console.WriteLine("PROGRAM: And about his/her age?");
            
            string i = Console.ReadLine();
            al1.Idade = Int16.Parse(i); ;
            al1.SeApresentar(); //note that at Aluno class have not a SeApresentar method, this method was inherited by
                                //Pessoa Class where exist this method.
            Console.WriteLine($"{al1.Nome}: I'm your student {p1.Nome} ,do want question me about rectangle area?\n");
            Thread.Sleep(2000);
            Console.WriteLine($"{al1.Nome}: Let's try? Give me two rectangle dimensions");
            
            Console.WriteLine($"{al1.Nome}: Please, type first dimension: ");
            string fd = Console.ReadLine();
            double fdint = Int16.Parse(fd);
            Thread.Sleep(1000);
            Console.WriteLine($"{al1.Nome}: Now, please a second dimension: ");
            string sd = Console.ReadLine();
            double sdint = Int16.Parse(sd);

            Retangulo ret = new Retangulo(); //here a new object is created and it was named as ret, now is
                                             //possible to use all property and method Retangulo Class, meanly use
                                             //the ObterArea method that can be used to calc rectangle area

            ret.DefinirDimensoes(fdint, sdint);
            
            Console.WriteLine($"{al1.Nome}: The rectangle area is {ret.ObterArea()}, right?"); //interpolation resource
            Thread.Sleep(2000);
            Console.WriteLine($"{al1.Nome}: Would you like to rate me? what's my grade?");

            al1.Nota = Int16.Parse(Console.ReadLine());

            Console.WriteLine($"{al1.Nome}: Thanks {p1.Nome} for my {al1.Nota} grade");  // now used a Nota property from exclusive ALUNO class
            Thread.Sleep(2000);
            Console.WriteLine($"{p1.Nome}: No so bad for a studente of {al1.Idade} years old");
            Thread.Sleep(2000);
            Console.WriteLine($"{al1.Nome}: Not so bad for a teacher of {p1.Idade} years old, Thank you!");
            Thread.Sleep(2000);
            Console.WriteLine($"PROGRAM: Let's talk about of Director of your imaginarium scholl {p1.Nome} ?");
            Thread.Sleep(2000);
            Console.WriteLine("PROGRAM: Type his/her name please");


            Diretor d1 = new Diretor(); // new object created to add Director's properties
            d1.Nome = Console.ReadLine(); //add input user typed as Director Name using a Nome property came from PESSOA CLASS
                                          //This is possible because at DIRECTOR CLASS WAS inherited A PROFESSOR CLASS AND INSIDE
                                          //PROFESSOR CLASS PESSOA CLASS WAS inherited TOO. SEE ABOVE
                                          //public class Diretor : Professor
                                          // public class Professor : Pessoa
            Console.WriteLine($"{p1.Nome}: Hi {d1.Nome}!");
            Thread.Sleep(2000);
            d1.SeApresentar(); //never forget close parenthesis
                               // was used SeApresentar from DIRECTOR CLASS because SeApresentar was override as show above
                               //public override void SeApresentar()
            
            Carro carro1 = new Carro();

            carro1.Name = "Chronos";
            carro1.Montadora = "Fiat";

            Console.WriteLine($"{d1.Nome}: I have a car, {carro1.DescreverCarrotostring()}");
            Thread.Sleep(2000);
            carro1.DescreverCarro(); //here I'm using DescreverCarro by method Carro Public Class

            Carro carro2 = new Carro();
            Console.WriteLine($"{d1.Nome}: and about your car?");
            Thread.Sleep(2000);
            carro2.Name = Console.ReadLine();

            Console.WriteLine($"{d1.Nome}: by what factoring?");

            carro2.Montadora = Console.ReadLine();

            Console.Write($"{p1.Nome}: "); //write is diferent 'cause not included a line after args
            carro2.DescreverCarro();
            Thread.Sleep(2000);
            
            //ICalculadora calc = new ICalculadora(); //not possible to instance a INTERFACE, SOLVE IS INSTANCE A CLASS THAT INTERIAGE
            //THE INTERFACE, LIKE WRITE ABOVE
            ICalculadora calc = new Calculadora();
            //Console.WriteLine(calc.somar(10,20);
            //Console.WriteLine(calc.multiplicar(3, 5));



            /*Conta conta = new Conta(); /*não instancia classe abstrata, solução é instanciar classe filha chamada de CORRETE
                            * is not possible to instance a abstract class, instead you can instance a child class
                            * at this case, Conta is a abstract class
                            * and Corrente is a child class of Conta
                            */
            d1.Salario = 10000;
            Console.Write($"PROGRAM: {p1.Nome} your salary is equal to 60% of mine, if my salary is {d1.Salario} so your is ");
            Console.Write(calc.multiplicar(0.6, d1.Salario));
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("PROGRAM: Maybe your acount bank said at final month:");
            Thread.Sleep(1000);
            
            Conta conta = new Corrente ();

            conta.creditar(calc.multiplicar(0.6, d1.Salario));
            conta.ExibirSaldo();

            Console.WriteLine("PROGRAM: Very good !");
            Console.WriteLine("PROGRAM: See you later !");

            //Corrente corrente = new Corrente();



            //corrente.creditar(51.3);

            //corrente.ExibirSaldo();

            //Computador computador = new Computador();

            //Console.WriteLine(computador.ToString()); //imprime o nome da classe Computador, que está vazia.
        }
    }
}