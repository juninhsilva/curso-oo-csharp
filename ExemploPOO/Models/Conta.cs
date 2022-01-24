namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double Saldo;

        public abstract void Creditar(double valor);

        public string Extrato() {
            return $"Seu saldo é {Saldo}";
        }
    }
}