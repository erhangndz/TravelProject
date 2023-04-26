using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T: class
    {
        List<T> TGetList();
        T TGetByID(int id);
        void TDelete(T t);
        void TUpdate(T t);
        void TInsert(T t);
    }
}   
