using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApiDeGastosMensais.DATA.Model
{
    public class Gasto
    {
        public int Id { get; set; }
        public DateTime DataDeRegistro { get; set; }
        
        [Column(TypeName = "decimal(32,2)")]
        public decimal Preco { get; set; }        
        public string descricao { get; set; }

    }

}
