using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("computer")]
    public class ComputerEntity
    {
        
        [Key]
        public int ComputerId { get; set; }

        public string Nazwa { get; set; }

        public string Procesor { get; set; }
        
        public int Memory { get; set; }
        [MaxLength(5)]
        public string Karta_Graficzna { get; set; }

        public string Producent { get; set; }


        [Column("data_produkcji")]
        public DateTime Data_Produkcji { get; set; }

        [Display(Name = "Priorytet")]
        public int Priority { get; set; }

    }
}
