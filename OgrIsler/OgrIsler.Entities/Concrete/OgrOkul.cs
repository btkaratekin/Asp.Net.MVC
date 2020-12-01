using OgrIsler.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace OgrIsler.Entities.Concrete
{
    public class OgrOkul:IEntity
    {
        [Required, StringLength(9),Key]
        public string OgrNo { get; set; }

        [Required]
        public byte Sinif { get; set; }

        public virtual OgrBilgi ogrBilgi { get; set; }
        public virtual OgrProgram ogrProgram { get; set; }

    }
}
