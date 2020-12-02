using OgrIsler.Core.DataAccess.EntityFrameWork;
using OgrIsler.DataAccess.Abstract;
using OgrIsler.Entities.Concrete;

namespace OgrIsler.DataAccess.Concrete.EntityFrameWork
{
    public class OgrOkulDal : EfRepositoryBase<OgrOkul, OgrIslerDbContext>, IOgrOkulDal
    {
    }


}
