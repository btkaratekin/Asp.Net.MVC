using OgrIsler.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace OgrIsler.Entities.Concrete
{
    public class OgrBilgi:IEntity
    {

        [Required,StringLength(9),Key]
        public string OgrNo { get; set; }
        [Required, StringLength(15)]
        public string Adi { get; set; }
        [Required, StringLength(20)]
        public string Soyadi { get; set; }
        [Required]
        public bool Cinsiyet { get; set; }
        [Required]
        public DateTime Dtarih { get; set; }
        
        public virtual OgrOkul ogrOkul { get; set; }

    }
}
