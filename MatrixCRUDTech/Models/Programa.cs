using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MatrixCRUDTech.Models
{
    public class Programa
    {
        [Key]
        [StringLength(4, ErrorMessage =
             "No maximo 4 Digitos")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public int Codigo { get; set; }

        [Column(TypeName = "varchar(70)")][Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public string Descricao { get; set; }

        [Column(TypeName = "varchar(70)")]
        public string PublicoAlvo { get; set; }

        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public int Tipo { get; set; }

        [Display(Name = "Objetivo do Milenio")]
        [Required(ErrorMessage = "Este campo é de preenchimento obrigatório")]
        public int ObjMilenio { get; set; }

        //relacionamento IndicadorPrograma (1,1)
        // public virtual List<IndicadorPrograma> IndicadorPrograma { get; set; } = new List<IndicadorPrograma>();

        public virtual IndicadorPrograma ObjIndicadorPrograma { get; set; }

        //relacionamento ObjetivoPrograma (1,n);
        public virtual ICollection<ObjetivoPrograma> ObjetivoProgramas { get; set; }
    }
}
