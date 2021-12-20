using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eroski.Models
{
    public class TodoItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Seccion { get; set; }
        public decimal NumeroDeTicket { get; set; }
    }
}