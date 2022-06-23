using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudntProjectMVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Ad { get; set; }

        [StringLength(20)]
        public string Soyad { get; set; }

        [StringLength(11)]
        [Display(Name ="Kimlik Numarası")]
        public string TCKimlikNo { get; set; }

        [StringLength(50)]
        public string Adres { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

        [StringLength(20)]
        [Display(Name = "Aldığı Eğitim")]

        public string AldigiEgitim { get; set; }

        [StringLength(20)]
        [Display(Name = "Başarı Durumu")]

        public string BasariDurumu { get; set; }

    }
}