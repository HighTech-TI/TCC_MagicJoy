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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_funcionario()
        {
            this.tb_controle_ponto = new HashSet<tb_controle_ponto>();
        }
    
        public int id_funcionario { get; set; }
        public string nm_nome { get; set; }
        public string ds_rg { get; set; }
        public string ds_cpf { get; set; }
        public System.DateTime dt_nascimento { get; set; }
        public int id_folha_pagamento { get; set; }
        public string ds_endereco { get; set; }
        public System.DateTime dt_admissao { get; set; }
        public System.DateTime dt_demissao { get; set; }
        public int id_beneficios { get; set; }
        public string ds_telefone { get; set; }
        public string ds_celular { get; set; }
        public string nm_cargo { get; set; }
    
        public virtual tb_beneficio tb_beneficio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_controle_ponto> tb_controle_ponto { get; set; }
        public virtual tb_folha_pagamento tb_folha_pagamento { get; set; }
    }
}
