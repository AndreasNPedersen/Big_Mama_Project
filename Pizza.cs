using System.Collections.Generic;
public class Pizza : Product {
    public string Ingrediens{get;set;}
    public List<Product> toppings{get;set;}
    public Pizza () {}

    public override string ToString()
    {
        return $"Pizza: {ProductName}, pizza number: {ProductNumber}, pizza count: {NumberOfProducts} pizza price: {ProductPrice}, with pizza ingrediens: {Ingrediens}";
    }
}