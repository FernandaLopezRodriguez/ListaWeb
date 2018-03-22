
using System;
using System.ComponentModel.DataAnnotations;

namespace ListaWeb.Models
{


    public class PendienteItem
    {
        /// Guid genera un secuencia aletoria 
        /// Investigar Guid
        public Guid Id { get; set; }

        public bool EstaHecha { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Pendiente { get; set; }

        public DateTimeOffset? ParaCuando { get; set; }

        /// Aquí deben hacer todo lo necesario para la creación de un Pendiente
        public PendienteItem()
        {
            
                Id=Guid.NewGuid();

                ParaCuando=DateTime.Today.AddDays(3);
                EstaHecha=false;
                        
            /// El Id debe generarse a la creación de Guid


            /// Las tareas son para dentro de dos días 


            
            /// Siempre las tareas deben estas no EstaHecha = false
           

        }
    }
}