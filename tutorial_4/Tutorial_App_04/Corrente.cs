namespace Tutorial_App_04
{   //abaixo Corrente é classe herdada de Conta, ou seja é classe filha
    public class Corrente : Conta
    // teoricamente herdaria. Porém em Conta há um método abstrato e todos os métodos abstratos
    //obriatoriamente devem ser sobrescritos, ate essa sobrescrição, não há implementação
    {
        //abaixo é a implementação da classe abstrata, que foi inserida automaticamente ao apertar o botão direto sobre o erro
        //e escolher implementar classe abstrata (IMPLEMENT ABSTRACT CLASS)
        public override void creditar(double valor)
        {
            base.saldo = valor;//foi escolhido base porque altera a propriedade herdada, da classe pai.
        }
    }
}
