//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS_EurekaBank_REST.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CostoMovimiento
    {
        public string chr_monecodigo { get; set; }
        public decimal dec_costimporte { get; set; }
    
        public virtual Moneda Moneda { get; set; }
    }
}
