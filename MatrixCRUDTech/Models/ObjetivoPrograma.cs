using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCRUDTech.Models
{
    public class ObjetivoPrograma
    {
        [Key]
        public int IdObjetivo { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string Descricao { get; set; }
        //Fk
        public int ProgramaId { get; set; }
        public virtual Programa Programa { get; set; }
    }
}
