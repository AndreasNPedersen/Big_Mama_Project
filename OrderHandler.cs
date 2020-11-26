using System;

class OrderHandler{

    CustomerManagment customerManagment = new CustomerManagment();
    ProductManagment productManagment = new ProductManagment();
    OrderManagment orderManagment = new OrderManagment();
    
    //product handeling
    public void AddProduct(Product product){
        productManagment.Create(product);
    }

    public void SetProduct(string oldProductName, Product product){
        productManagment.Update(oldProductName,product);
    }

    public Product GetProduct(string productName){
        return productManagment.Retrieve(productName);
    }

    public void DeleteProduct(string productName){
        productManagment.Delete(productName);
    }

    public string GetProductList(){
        string productList = "";
        foreach(Product product in productManagment.GetAll().Values){
            productList = product.ToString() + ", " + productList;
        }
        return productList;
    }
    
    //Order handeling
    public void AddCustomer(Customer customer){
        System.Random randomNumber = new Random();
        customer.ID = Convert.ToString(randomNumber.Next(1,999999));
        customerManagment.Create(customer);
    }

    public void SetCustomer(string oldID, Customer newCustomer){
        customerManagment.Update(oldID,newCustomer);
    }

    public Customer GetCustomer(string getID){
       return customerManagment.Retrieve(getID);
    }

    public void DeleteCustumer(string ID){
        customerManagment.Delete(ID);
    }

    public string GetAllCustomers(){
        string customerList ="";
        foreach (Customer customer in customerManagment.GetAll().Values){
            customerList = $"Customer ID: {customer.ID} with name: {customer.Name} and lives in {customer.Address}, " + customerList; 
        }
        return customerList;
    }

    // Order handeling
    public void AddOrder(Order order){
        System.Random randomNumber = new Random();
        order.ID = Convert.ToString(randomNumber.Next(1,999999));
        orderManagment.Create(order);
    }

    public void SetOrder(string oldID, Order newOrder){
        orderManagment.Update(oldID,newOrder);
    }

    public Order GetOrder(string ID){
        return orderManagment.Retrieve(ID);
    }

    public void DeleteOrder(string ID){
        orderManagment.Delete(ID);
    }

    public string GetAllOrders(){
        string orderList="";
        foreach(Order order in orderManagment.GetAll().Values){
            orderList = order.ToString() + ", " + orderList;
        }
        
        return orderList;
    }

    public double CalculateTotalPrice(){
        
        double amount = 0;
        foreach(Order order in orderManagment.GetAll().Values){
            amount = order.TotalPrice() + amount;
        }
        
        return amount;
    }



}