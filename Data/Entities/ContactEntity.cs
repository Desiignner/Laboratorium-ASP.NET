using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("contacts")]
    public class ContactEntity
    {
        //[Key]
        public int Id { get; set; }
        [Column("name")]

        public string Name { get; set; }

        public string Email { get; set; }

        public string? Phone { get; set; }

        public DateTime? Date { get; set; }
        //DataTime? = moze byc null

        public int Priority { get; set; }
        public object? ContactId { get; internal set; }
        public DateTime Birth { get; internal set; }
    }
}
