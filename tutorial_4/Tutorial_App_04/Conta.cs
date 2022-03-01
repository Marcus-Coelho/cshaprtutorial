namespace Tutorial_App_04
{
    public abstract class Conta
    {
        //atribuir uma propriedade chamada de saldo
        //protected somente a própria classe ou as classes filhas podem acessar
        //já não poderia ter acesso por também ser abstrata
        protected double saldo;

        //MÉTODO ABSTRATO, esse método não tem implementação, por ser abstrato
        public abstract void creditar(double valor);

        //criação de um método nao abstrato
        public void ExibirSaldo()

        {
            Console.WriteLine("your balance is $ " + saldo);
        }

    }
}
