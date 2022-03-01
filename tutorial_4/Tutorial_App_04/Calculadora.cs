namespace Tutorial_App_04
{
    public class Calculadora : ICalculadora // ao incluir a INTERFACE ICALCULADORA É DADO UM ERRO
                                            //ESSE ERRO É PQ NÃO FOI IMPLEMENTADO O ICALCULADORA
                                            //PARA RESOLVER DEVE SE FAZER A IMPLEMENTAÇÃO COM BOTÃO CONTROL E PONTO E AO SURGIR AS OPÇOES ESCOLHA IMPLEMENTAR A INTERFACE
    {
        public int dividir(int x, int y)
        {
            return (int)(x / y);
        }

        public int multiplicar(int x, int y)
        {
            return x * y;
        }

        public int somar(int num1, int num2)
        { return num1 + num2; }
        public int somar(int num1, int num2, int num3)
        { return num1 + num2 + num3; }

        public int subtrair(int x, int y)
        {
            return (x - y);
        }
    }
}
