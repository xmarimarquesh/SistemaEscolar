using System;
using System.Collections.Generic;
using Database;

namespace Model;

public interface IRepository<T> 
    where T : DatabaseObject 
    {
        List<T> All { get;}
        void Add(T obj);

        T getById(string id);

        void seeAll();
    }