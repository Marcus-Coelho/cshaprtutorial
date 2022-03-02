namespace Tutorial_App_04
{
    public interface ICalculadora
        /* a interface was created by .Net to solve the problem that is not possible a class inheritage multiples class, only one, but
         * is possible a class inheritage multiplies interfaces
         */
    {
        int somar(int x, int y); //this is a assign, not is necessary to add a modifier acsess, all is public
        //all these are methods.
        int subtrair(int x, int y);
        double multiplicar(double x, double y);
        int dividir(int x, int y);
     }
}
