namespace Tutorial_App_04

{   //abaixo Corrente é classe herdada de Conta, ou seja é classe filha
    //trad: below Corrent is a class inherited from Conta, that is, it's a child class
    public class Corrente : Conta
    // teoricamente herdaria. Porém em Conta há um método abstrato e todos os métodos abstratos
    // obriatoriamente devem ser sobrescritos, ate essa sobrescrição, não há implementação
    //  trad: theoretically would inherit. But in Conta there is an abstract method and all abstract methods
    //  must be overridden, until this override, there is no implementation
    {
        //abaixo é a implementação da classe abstrata, que foi inserida automaticamente ao apertar o botão direto sobre o erro
        //e escolher implementar classe abstrata (IMPLEMENT ABSTRACT CLASS)
        //below is the implementation of the abstract class, which was automatically
        //inserted when pressing the right button on the error and choose to implement abstract class (IMPLEMENT ABSTRACT CLASS)
        public override void creditar(double valor)
        {
            base.saldo = valor; //foi escolhido base porque altera a propriedade herdada, da classe pai.
                                //trad: was chosen base because it changes the property inherited from the parent class.
        }
    }
}
