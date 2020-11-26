using System.Collections.Generic;
using System.Text;
class Order {
    public string ID{get;set;}
    public Customer _theCustomer{get;set;}
    public bool deliveryTakeAway{get;set;}
    public List<Product> _productsListOrder{get;set;}

    public Order(){}

    public double TotalPrice (){
        double totalPrice = 0; 
        foreach (Product products in _productsListOrder){
            totalPrice = totalPrice + (products.ProductPrice*products.NumberOfProducts);
        }
        if (deliveryTakeAway){
            totalPrice  = totalPrice + 40;
        }
        return (totalPrice * 1.25); // 1.25 = tax & 40 = delivery cost
    }

    public override string ToString()
    {
        StringBuilder sbP = new StringBuilder();
            sbP.Append("has brought the product(s): ");
        foreach (Product product in _productsListOrder){
            sbP.Append( product.NumberOfProducts +" of "+product.ProductNumber+ " "+product.ProductName+ ", ");
        }
        

        

        return ("The Order: " + ID +", The customer: " + _theCustomer.Name + " who lives in " + _theCustomer.Address + ". Delivery: "+deliveryTakeAway+". " + sbP.ToString()  +
         "at a price of: " + TotalPrice() + " DKK.|");
    }

}