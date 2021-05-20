using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TI2MedicosOnline.Models
{
    public class ReceitaMedica
    {
        /// <summary>
        /// Id da receita médica
        /// </summary>
        [Key]
        public int ReceitaId { get; set; }

        /// <summary>
        /// Preço total da receita médica
        /// </summary>
        [Display(Name = "Preço do(s) medicamento(s) total")]
        public decimal Preco { get; set; }

        //---------------------------


        /// <summary>
        /// FK para o médico que receitou a receita médica
        /// </summary>
        [ForeignKey(nameof(Medico))]
        [Display(Name = "Médico")]
        public int MedicoIDFK { get; set; }
        public Medico MedicoID { get; set; }



        /// <summary>
        /// FK do utente da receita médica
        /// </summary>
        [ForeignKey(nameof(Utente))]
        public int UtenteIDFK { get; set; }
        public int UtenteID { get; set; }

        //lista de medicamentos receitas
        //data




        /// <summary>
        /// FK do(s) medicamentos receitados
        /// </summary>
        /// [ForeignKey(nameof(Medicamento))]
        /// public int MedicIDFK { get; set; }
        ///public int MedicID { get; set; }





    }
}
