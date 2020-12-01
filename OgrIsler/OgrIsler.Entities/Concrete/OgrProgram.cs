using OgrIsler.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrIsler.Entities.Concrete
{
   public class OgrProgram:IEntity
    {
        [Key,StringLength(3)]
        public string Pkodu { get; set; }
        [Required]
        public string Padi { get; set; }

        public virtual IList<OgrOkul> ogrOkuls { get; set; }
        public virtual OgrBolum Bkodu { get; set; }

    }
}
