

public class Product{
    public string ProductName{get;set;}
    public int NumberOfProducts{get;set;}
    public int ProductNumber{get;set;}
    public double ProductPrice {get; set;}

    public Product(){}
     

    public override string ToString()
    {
        return ProductName + " " + NumberOfProducts + " " + ProductNumber +
         " " + ProductPrice;
    }

    
}