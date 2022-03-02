//using System;

namespace Tutorial_App_04
{
    public class Pessoa
    {

        public string? Nome { get; set; } //add a question mark "?" to accept Nome as a null property

        public int Idade { get; set; }

        public virtual void SeApresentar() /*
                                            * adicionado virtual para que outras classes filhas possam realizar override (sobrescrever)
                                            * add the virtual word to allow other sons classes to use override
                                            * override can be used as a modifier code, keeping a parent class intact.
                                            * in this program, "SeApresentar" was used at Professor Class and Diretor Class
                                            * and the code was changed by follow
                                            * Console.WriteLine($"olá, meu nome é {Nome} e sou professor, meu salário é {salario}");
                                            */
        {
            Console.WriteLine($"Hello my name is {Nome} and I'm {Idade} years old");
        }

    }
}
