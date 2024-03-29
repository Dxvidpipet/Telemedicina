using System;
using System.ComponentModel.DataAnnotations;

namespace HospiEnCasa.App.Dominio
{
     /// <summary>Class <c>Persona</c>
     /// Modela una Persona en general en el sistema 
     /// </summary>   
    public class Persona
    {
        // Identificador único de cada persona
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo Obligatorio")]
        [StringLength(50,ErrorMessage ="Máximo 50 caracteres")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage ="Campo Obligatorio")]
        [StringLength(50,ErrorMessage ="Máximo 50 caracteres")]
        public string Apellidos { get; set; }
        [Display(Name = "Número telefonico")]
        public string NumeroTelefono { get; set; }
        // Genero de la persona
        public Genero Genero { set; get; }

    }
}