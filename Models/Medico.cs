using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TI2MedicosOnline.Models
{
    public class Medico
    {


        /// <summary>
        /// id do médico
        /// </summary>
        [Key]
        public int MedicoId { get; set; }



        /// <summary>
        /// nome do medico
        /// </summary>
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public String Nome { get; set; }






        //fotografia
        //especialidade

    }
}
