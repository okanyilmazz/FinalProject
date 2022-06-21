using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint - kısıtlama işlemi 
    //T olarak sadece veritabanı nesnelerinini gönderilmesi için T:class yazıyoruz.
    //class : referans tip olabilir demektir.
    // T IEntity olabilir veya IEntityden implement olmuş olabilir.
    //new() : new'lenebilir olmalı IEntity interface olduğu için newlenemez bu yüzden yazılamaz.

    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Filtre vermek zorunlu değli ise filter = null yazıyoruz.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
