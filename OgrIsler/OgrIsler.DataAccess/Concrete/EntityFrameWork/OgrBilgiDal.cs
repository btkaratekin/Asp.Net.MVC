using OgrIsler.DataAccess.Abstract;
using OgrIsler.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OgrIsler.DataAccess.Concrete.EntityFrameWork
{
    public class OgrBilgiDal : IOgrBilgiDal
    {
        public void Add(OgrBilgi Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(OgrBilgi Entity)
        {
            throw new NotImplementedException();
        }

        public OgrBilgi Get(Expression<Func<OgrBilgi, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<OgrBilgi> GetList(Expression<Func<OgrBilgi, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(OgrBilgi Entity)
        {
            throw new NotImplementedException();
        }
    }
}
