//using System;

namespace Tutorial_App_04
{
    public class Pessoa
    {

        public string Nome { get; set; }

        public int Idade { get; set; }

        public virtual void SeApresentar() //adicionado virtual para que outras classes filhas possam realizar override (sobrescrever)
        {
            Console.WriteLine($"olá meu nome é {Nome} e eu tenho {Idade} anos");
        }

    }
}
