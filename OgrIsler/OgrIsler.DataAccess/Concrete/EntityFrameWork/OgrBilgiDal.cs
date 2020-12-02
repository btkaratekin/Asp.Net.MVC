using OgrIsler.Core.DataAccess.EntityFrameWork;
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
    public class OgrBilgiDal : EfRepositoryBase<OgrBilgi,OgrIslerDbContext>,IOgrBilgiDal
    {    
    }


}
