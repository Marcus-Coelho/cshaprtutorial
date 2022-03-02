namespace Tutorial_App_04
{
    public class Retangulo
    {
        public double comprimento;
        public double largura;

        public void DefinirDimensoes(double comprimento, double largura) //note void have not return
        {
            this.comprimento = comprimento;
            this.largura = largura;
        }

        public double ObterArea() //note ObterArea is a method and have a return, whem another class call ObterArea the
                                    //calculus is made
        {
            return comprimento * largura;

        }
    }

}


