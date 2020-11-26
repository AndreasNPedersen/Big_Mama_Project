using System.Collections.Generic;
using System;
class CustomerManagment: IManagement<Customer>{
    
    private Dictionary<string,Customer> _customerDictionary = new Dictionary<string,Customer>();

    public void Create(Customer customer){
        //customer.ID = Guid.NewGuid().ToString(); ville have gjort dette, nemmere at håndtere uden ID i Console.
        _customerDictionary.Add(customer.Name,customer);
    }
    
    public Customer Retrieve(string name){
        if (_customerDictionary.ContainsKey(name)){
            return _customerDictionary[name];
        }
        return null;
    }

    public void Update(string name, Customer customer0){
        _customerDictionary[name] = customer0;
    }

    public void Delete(string name){
        _customerDictionary.Remove(name);
    }

    public Dictionary<string,Customer> GetAll(){
        return _customerDictionary;
    }
}