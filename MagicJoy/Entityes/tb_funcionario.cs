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
    
    public partial class tb_funcionario
    {
        public int id_funcionario { get; set; }
        public string nm_nome { get; set; }
        public string ds_rg { get; set; }
        public string ds_cpf { get; set; }
        public System.DateTime dt_nascimento { get; set; }
        public int tb_folha_pagamento_id_folha_pagamento { get; set; }
        public string ds_endereco { get; set; }
        public System.DateTime dt_admissao { get; set; }
        public System.DateTime dt_demissao { get; set; }
        public int tb_beneficio_id_beneficios { get; set; }
    }
}
