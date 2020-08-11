﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aliquota.Domain.Models
{
    public class CadastroInvestidor
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        [Required]
        [Range(0, 999999.99)]
        [Display(Name = "Valor da Aplicação")]
        public double ValorAplicacao { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Data da Aplicação")]
        public DateTime DataAplicacao { get; set; }


        [DataType(DataType.Date)]
        [Display(Name = "Data do Resgate")]
        public DateTime DataResgate { get; set; }


        [Display(Name = "Tipo de Aplicação")]
        public List<TipoAplicacao> TipoAplicacao { get; set; }
    }
}
