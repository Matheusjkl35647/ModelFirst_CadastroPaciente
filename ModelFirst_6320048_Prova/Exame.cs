//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirst_6320048_Prova
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exame
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Medico { get; set; }
        public System.DateTime Data { get; set; }
        public int PacienteId { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}
