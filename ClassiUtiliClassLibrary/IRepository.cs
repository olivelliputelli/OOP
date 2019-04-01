using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiUtiliClassLibrary
{
    public interface IRepository<T, TKey>
    {
        T GetItemBy(TKey key);
        List<T> GetAllItems();
        void AddItem(T item);
        void DeleteItemBy(TKey key);
    }
}
