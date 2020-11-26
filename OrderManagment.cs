using System.Collections.Generic;
using System;
class OrderManagment : IManagement<Order> {
    
    private Dictionary<string,Order> _orderDictionary = new Dictionary<string, Order>();

    public void Create(Order order){
        order.ID = Guid.NewGuid().ToString();
        _orderDictionary.Add(order.ID.ToString(),order);
    }
    
    public Order Retrieve(string ID){
        if (_orderDictionary.ContainsKey(ID)){
            return _orderDictionary[ID];
        }
        return null;
    }

    public void Update(string ID, Order order0){
        _orderDictionary[ID] = order0;
    }

    public void Delete(string ID){
        _orderDictionary.Remove(ID);
    }

    public Dictionary<string,Order> GetAll(){
        return _orderDictionary;
    }
}