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
    
    public partial class tb_cliente
    {
        public int id_cliente { get; set; }
        public string nm_nome { get; set; }
        public string ds_telefone { get; set; }
        public System.DateTime dt_nascimento { get; set; }
        public string ds_cpf { get; set; }
        public string ds_endereço { get; set; }
        public int id_compras { get; set; }
        public string ds_celular { get; set; }
        public string ds_rg { get; set; }
    
        public virtual tb_compra tb_compra { get; set; }
    }
}
