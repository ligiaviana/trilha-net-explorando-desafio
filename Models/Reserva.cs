namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Implementado!!!
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Implementado!!!
                throw new Exception("A capacidade é menor que o número de hóspedes recebido");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado!!!
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            // Implementado!!!
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            // Implementado!!!
            if (DiasReservados >= 10)
            {
                valor *= 0.9M;
            }

            return valor;
        }
    }
}