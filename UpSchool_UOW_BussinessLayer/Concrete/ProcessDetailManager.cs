﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool_UOW_BussinessLayer.Abstract;
using UpSchool_UOW_DataAccessLayer.Abstract;
using UpSchool_UOW_DataAccessLayer.EntityFramework;
using UpSchool_UOW_DataAccessLayer.UoW;
using UpSchool_UOW_EntityLayer.Concreate;

namespace UpSchool_UOW_BussinessLayer.Concrete
{
    public class ProcessDetailManager : IProcessDetailService
    {
        private readonly IProcessDetailDal _processDetailDal;
        private readonly IUowDal _uowDal;

        public ProcessDetailManager(IProcessDetailDal processDetailDal, IUowDal uowDal)
        {
            _processDetailDal = processDetailDal;
            _uowDal = uowDal;
        }

        public void TDelete(ProcessDetail t)
        {
            _processDetailDal.Delete(t);
            _uowDal.Save();
        }

        public ProcessDetail TGetByID(int id)
        {
            return _processDetailDal.GetByID(id);
        }

        public List<ProcessDetail> TGetList()
        {
            return _processDetailDal.GetList();
        }

        public void TInsert(ProcessDetail t)
        {
            _processDetailDal.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<ProcessDetail> t)
        {
            _processDetailDal.MultiUpdate(t);
        }

        public void TUpdate(ProcessDetail t)
        {
            _processDetailDal.Update(t);
            _uowDal.Save();
        }
    }
}
