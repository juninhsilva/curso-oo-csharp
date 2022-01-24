namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;

        public void GerarRetangulo(double comprimento, double largura){
            if(comprimento > 0 && largura > 0){
                this.comprimento = comprimento;
                this.largura = largura;
            }
        }

        public double ObterArea(){
            return this.comprimento * this.largura;
        }
    }
}