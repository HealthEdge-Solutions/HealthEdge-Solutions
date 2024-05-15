using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Repository<T>
{
    public string FilePath { get; set; }

    public List<T> GetAll()
    {
        if (!File.Exists(FilePath))
            return new List<T>();

        string json = File.ReadAllText(FilePath);
        return JsonConvert.DeserializeObject<List<T>>(json);
    }

    public void Add(T item)
    {
        List<T> items = GetAll();
        items.Add(item);
        File.WriteAllText(FilePath, JsonConvert.SerializeObject(items));
    }

    public void Update(Func<T, bool> predicate, Action<T> updateAction)
    {
        List<T> items = GetAll();
        T itemToUpdate = items.FirstOrDefault(predicate);
        if (itemToUpdate != null)
        {
            updateAction(itemToUpdate);
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(items));
        }
    }

    public void Delete(Func<T, bool> predicate)
    {
        List<T> items = GetAll();
        T itemToRemove = items.FirstOrDefault(predicate);
        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(items));
        }
    }
}
