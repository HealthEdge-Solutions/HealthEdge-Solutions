using System.Collections.Generic;

public interface IRepository<T>
{
    List<T> GetAll();
    void Add(T item);
}