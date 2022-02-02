using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCRUDTech.Models
{
    public class IndicadorPrograma
    {
        [Key]
        public int IdIndicador { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Descricao { get; set; }

        //FK
        public int ProgramaID { get; set; }
        public virtual Programa ObjPrograma { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string UndMedida { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public double IndiceApuracao { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public double IndiceDesejado { get; set; }

        public System.DateTime Data { get; set; }
    }
}
