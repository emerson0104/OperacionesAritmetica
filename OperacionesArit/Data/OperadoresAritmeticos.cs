using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OperacionesArit.Data
{
    public class OperadoresAritmeticos
    {
        [Required(ErrorMessage= "EL Campo no Puede estar Vacio.")]
        public decimal PrimerNumero { get; set; }
        [Required(ErrorMessage = "EL Campo no Puede estar Vacio.")]
        public decimal SegundoNumero { get; set; }
        public decimal ResultadosResta { get; set; }
        public decimal ResultadosSuma { get; set; }
        public decimal ResultadosMultiplicacion { get; set; }

        public OperadoresAritmeticos()
        {
            PrimerNumero = 0;
            SegundoNumero = 0;
            ResultadosMultiplicacion = 0;
            ResultadosResta = 0;
            ResultadosSuma = 0;

        }

    }
}
