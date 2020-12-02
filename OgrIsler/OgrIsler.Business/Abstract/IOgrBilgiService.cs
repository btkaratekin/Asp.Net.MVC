using OgrIsler.DataAccess.Abstract;
using OgrIsler.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OgrIsler.Business.Abstract
{
    public interface IOgrBilgiService
    {
        List<OgrBilgi> GetList(Expression<Func<OgrBilgi, bool>> filter = null);
    }
}
