using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium3.Models
{

    public class Computer
    {
        [HiddenInput]
        public int Id { get; set; }

        public string Nazwa { get; set; }
        [Required(ErrorMessage = "Proszę wpisz Nazwe Procesora!")]
        public string Procesor { get; set; }


        public int Memory { get; set; }
        [MinLength(length: 5, ErrorMessage = "Wiadomość musi mieć co najmniej 5 znaków!")]
        [Required(ErrorMessage = "Proszę wpisz nazwe Karty Graficznej!")]
        public string Karta_Graficzna { get; set; }

        public string Producent { get; set; }


        [DataType(DataType.Date)]
        public DateTime Data_Produkcji { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }



    }
}
