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
        public string pkodu { get; set; }
        [Required]
        public string padi { get; set; }

        public virtual List<OgrOkul> ogrOkuls { get; set; }

    }
}
