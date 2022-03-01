namespace Tutorial_App_04
{
    public interface ICalculadora
    {
        int somar(int x, int y);
        int subtrair(int x, int y);
        int dividir(int x, int y);
        int multiplicar(int x, int y)
        {
            return x / y;
        }


    }
}
