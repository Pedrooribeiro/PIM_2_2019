//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControleFrota.web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class viagens
    {
        public int id_viagem { get; set; }
        public string data_viagem { get; set; }
        public string data_entregar { get; set; }
        public string data_entregue { get; set; }
        public string motivo { get; set; }
        public string situacao { get; set; }
        public decimal km_inicial { get; set; }
        public decimal km_final { get; set; }
        public string placa { get; set; }
        public string cpf { get; set; }
    }
}
