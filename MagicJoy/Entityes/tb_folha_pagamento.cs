//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagicJoy.Entityes
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_folha_pagamento
    {
        public int id_folha_pagamento { get; set; }
        public int id_funcionario { get; set; }
        public decimal vl_salario_liquido { get; set; }
        public decimal vl_salario_bruto { get; set; }
        public int ds_faltas { get; set; }
        public decimal ds_gratificacao { get; set; }
        public Nullable<decimal> ds_plr { get; set; }
        public Nullable<int> hr_extras { get; set; }
    }
}
