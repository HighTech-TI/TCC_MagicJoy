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
    
    public partial class tb_folha_pagamento1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_folha_pagamento1()
        {
            this.tb_funcionario = new HashSet<tb_funcionario1>();
        }
    
        public int id_folha_pagamento { get; set; }
        public int id_funcionario { get; set; }
        public decimal vl_fgts { get; set; }
        public decimal ds_inss { get; set; }
        public decimal vl_irrf { get; set; }
        public decimal vl_salario_familia { get; set; }
        public decimal vl_VT { get; set; }
        public int ds_faltas { get; set; }
        public decimal vl_13_ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_funcionario1> tb_funcionario { get; set; }
    }
}
