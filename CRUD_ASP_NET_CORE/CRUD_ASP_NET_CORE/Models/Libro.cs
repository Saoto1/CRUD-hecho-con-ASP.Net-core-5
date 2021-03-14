using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_ASP_NET_CORE.Models
{
    public class Libro
    {
        //Aqui usaremos los Data Notation

        //lo usamos para denominarlo como clave primaria
        [Key]
        public int Id { get; set; }
        //validacion de campo
        [Required(ErrorMessage = "El titulo es obligatorio")]
        //validacion de logitud de caracteres permitidos,maximos y minimos
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        //Correccion de el nombre para la vista(esto no afecta la base de datos)
        [Display(Name ="Título")]
        public string Titulo { get; set; }


        //validacion de campo
        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        //validacion de logitud de caracteres permitidos,maximos y minimos
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        //Correccion de el nombre para la vista(esto no afecta la base de datos)
        [Display(Name = "Descripcíon")]
        public string Descripcion { get; set; }


        //validacion de campo
        [Required(ErrorMessage = "La Fecha es obligatoria")]
        //esto lo usaremos para guardar unicamente fecha
        [DataType(DataType.Date)]
        //Correccion de el nombre para la vista(esto no afecta la base de datos)
        [Display(Name = "Fecha Lanzamiento")]
        public DateTime FeachaLanzamiento { get; set; }

        //validacion de campo
        [Required(ErrorMessage = "El Autor es obligatorio")]
        public string Autor { get; set; }

        //validacion de campo
        [Required(ErrorMessage = "El Precio es obligatorio")]
        public int Precio { get; set; }
    }
}
