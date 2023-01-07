using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool_UOW_DataAccessLayer.Concrete;

namespace UpSchool_UOW_DataAccessLayer.UoW
{
    public class UowDal :IUowDal
    {
        private readonly Context _context;

        public UowDal(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
