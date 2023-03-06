using System;
using System.Collections.Generic;

namespace API.Utils
{
    public class Reserva
    {
        public class Root
        {
            public int idReserva { get; set; }
            public string idReservaCb { get; set; }
            public string nomeHospede { get; set; }
            public DateTime dataInicio { get; set; }
            public DateTime dataFinal { get; set; }
            public DateTime dataCriacao { get; set; }
            public string fonte { get; set; }
            public string nomeQuarto { get; set; }
            public double total { get; set; }
            public string adultos { get; set; }
            public string criancas { get; set; }
            public string idHospedeCb { get; set; }
            public string statusHospede { get; set; }
            public string totalQuarto { get; set; }
            public int itensAdicionaisBalanco { get; set; }
            public string status { get; set; }
            public int vendedor { get; set; }
            public bool ota { get; set; }
            public DateTime dataRegistro { get; set; }
            public DateTime dataAtualizacao { get; set; }
            public string idHospede { get; set; }
            public object vendedorNavigation { get; set; }
            public List<object> tblCaixasCheques { get; set; }
        }
    }
}