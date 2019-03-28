﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Classes.CrudFacade
{
    /// <summary>
    /// Temel Veritabanı işlemlerini yapabilmek için arayüzde işlemleri tanımladık.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IOtelRepository<T> where T:DbObject
    {
        List<T> Records { get; }
        bool Insert(T entity);
        bool Delete(T entity);
        bool Delete(string id);
        bool Update(T oldEntity,T newEntity);
        bool Update(string id, T newEntity);
        T Find(string id);          
    }
}
