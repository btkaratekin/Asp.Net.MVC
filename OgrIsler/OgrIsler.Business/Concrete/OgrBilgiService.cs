using OgrIsler.Business.Abstract;
using OgrIsler.DataAccess.Abstract;
using OgrIsler.DataAccess.Concrete.EntityFrameWork;
using OgrIsler.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OgrIsler.Business.Concrete
{
    public class OgrBilgiService : IOgrBilgiService
    {
        private readonly IOgrBilgiDal _OgrBilgiDal;

        public OgrBilgiService(IOgrBilgiDal ogrBilgiDal)
        {
            _OgrBilgiDal = ogrBilgiDal;
        }

        public List<OgrBilgi> GetList(Expression<Func<OgrBilgi, bool>> filter = null)
        {
            return _OgrBilgiDal.GetList();
        }

        
    }
}
