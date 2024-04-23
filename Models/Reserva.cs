using System.Drawing;

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
            // OK
            if(hospedes.Count <= Suite.Capacidade){
            
                Hospedes = hospedes;
                
            }else
            {
                //OK
                Console.ForegroundColor = ConsoleColor.Red; //O erro fica em vermelho porque é mais assustador
                throw new Exception("ERRO: \n A quantidade de hóspedes não pode ser maior que a capacidade da Suite");
                
                
            }
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //OK
            return Hospedes.Count;
            
        }

        public decimal CalcularValorDiaria()
        {
            
            //OK
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // OK
            if (DiasReservados > 9)
            {
                valor = valor - (valor * 10/100);
            }

            return valor;
        }
    }
}