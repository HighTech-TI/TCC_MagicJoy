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
        public int vl_fgts { get; set; }
        public decimal ds_inss { get; set; }
        public decimal vl_irrf { get; set; }
        public decimal vl_salario_familia { get; set; }
        public decimal vl_VT { get; set; }
        public decimal vl_ferias { get; set; }
        public decimal vl_liquido { get; set; }
        public decimal vl_terceiro { get; set; }
        public decimal vl_bruto { get; set; }
        public System.DateTime dt_pagamento { get; set; }
        public decimal vl_gratificacao { get; set; }
    }
}
