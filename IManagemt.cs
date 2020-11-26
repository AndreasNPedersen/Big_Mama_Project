using System.Collections.Generic;
public interface IManagement<T>{

    Dictionary<string,T> GetAll();
    void Create(T obj);
    T Retrieve(string key);
    void Update(string name, T obj);
    void Delete(string key);
}