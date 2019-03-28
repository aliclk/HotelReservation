using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes.CrudFacade
{
    public class GenelCrud<T> : IOtelRepository<T> where T : DbObject
    {
        private DbContext _database;//Üzerinde çalışacağım veritabanı
        private DbSet<T> _currentTable;//üzerinde çalışacağım tabloseti
        public GenelCrud(DbContext database,DbSet<T> currentTable)
        {
            _database = database;
            _currentTable = currentTable;
        }
        public List<T> Records
        {
            get
            {
                return _currentTable.ToList();
            }
        }
        public bool Delete(T entity)
        {
            try
            {
                _currentTable.Remove(entity);
                _database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(string id)
        {
            try
            {
                _currentTable.Remove(Find(id));
                _database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public T Find(string id)
        {
            var entity = _currentTable.FirstOrDefault(x => x.ID == id);
            if (entity!=null)
            {
                return entity;
            }
            else
            {
                return null;
            }
        }
        public bool Insert(T entity)
        {
            try
            {
                _currentTable.Add(entity);
                _database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(T oldEntity,T newEntity)
        {
            try
            {
                _database.Entry(oldEntity).CurrentValues.SetValues(newEntity);
                _database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(string id,T newEntity)
        {
            try
            {
                var oldEntity = Find(id);
                _database.Entry(oldEntity).CurrentValues.SetValues(newEntity);
                _database.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void CheckConnection()
        {
            var records = Records;
        }
    }
}
