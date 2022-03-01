namespace Tutorial_App_04
{
    public class Retangulo
    {
        public double comprimento;
        public double largura;

        public void DefinirDimensoes(double comprimento, double largura)
        {
            this.comprimento = comprimento;
            this.largura = largura;
        }

        public double ObterArea()
        {
            return comprimento * largura;

        }
    }

}


