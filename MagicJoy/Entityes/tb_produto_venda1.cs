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
    
    public partial class tb_produto_venda1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_produto_venda1()
        {
            this.tb_venda_item = new HashSet<tb_venda_item1>();
        }
    
        public int id_produto { get; set; }
        public string nm_produto { get; set; }
        public decimal vl_produto { get; set; }
        public decimal vl_total { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_venda_item1> tb_venda_item { get; set; }
    }
}
