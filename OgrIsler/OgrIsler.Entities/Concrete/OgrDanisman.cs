using OgrIsler.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrIsler.Entities.Concrete
{
    public class OgrDanisman:IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Dkodu { get; set; }
        [Required,StringLength(15)]
        public string Dadi { get; set; }
        [Required, StringLength(20)]
        public string Dsoyadi { get; set; }

        public virtual IList<OgrOkul> OgrOkuls { get; set; }
        public virtual OgrBolum Bkodu { get; set; }

    }
}
