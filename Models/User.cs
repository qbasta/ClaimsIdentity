﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClaimsIdentity.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe")]
        [StringLength(100, ErrorMessage = "{0} nie może przekraczać 100 znaków.")]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string? Name { get; set; }

        [Display(Name = "Nazwisko")]
        [StringLength(100, ErrorMessage = "{0} nie może przekraczać 100 znaków.")]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string? Surname { get; set; }

        [Display(Name = "Rok")]
        [Required(ErrorMessage = "Pole {0} jest obowiązkowe")]
        [Range(1899, 2022, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
        public int? Year { get; set; }

        [Display(Name = "Wynik")]
        public bool Result { get; set; }

        [Display(Name = "Utworzony")]
        public DateTime CreatedTime { get; set; }

        [Display(Name = "OwnerId")]
        public string? OwnerId { get; set; }

        public bool IsLeapYear()
        {
            if (DateTime.IsLeapYear(Year ?? 0))
                return true;

            return false;
        }
    }
}