using System.ComponentModel.DataAnnotations;

namespace PayCore__HW1.NewFolder
{
    public class InterestModel
    {
        [Required(ErrorMessage = "Ana Para Miktarını Giriniz.")]
        public double Principal { get; set; } //ana para 

        [Required (ErrorMessage = "Faiz Miktarını Giriniz.") , Range(1,100)]
        public double InterestAmount { get; set; } // faiz miktarı 

        [Required (ErrorMessage = "Vade Ayı Giriniz.") , Range(1, 36), ]
        public int Expiry { get; set; } // vade
    }
}
