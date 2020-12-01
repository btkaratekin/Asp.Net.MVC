using OgrIsler.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrIsler.Entities.Concrete
{
   public class OgrBolum:IEntity
    {
        [Key,StringLength(3)]
        public string Bkodu { get; set; }
        [Required]
        public string Badi { get; set; }

        public virtual IList<OgrProgram> ogrPrograms { get; set; }
        public virtual IList<OgrDanisman> ogrDanismans { get; set; }
    }
}
