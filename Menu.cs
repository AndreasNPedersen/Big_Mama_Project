using System.Collections.Generic;
using System.Text;
public class Menu : Product {
    public List<Product> Products{get;set;}

    public override string ToString()
    {
        StringBuilder sbP = new StringBuilder();
            sbP.Append("product(s): ");
        foreach(Product products in Products){
            sbP.Append(products.ProductName + ", ");
        }
        
        return $"Menu: {ProductName}, menu number: {ProductNumber}, menu count: {NumberOfProducts},menu contains: {sbP.ToString()},menu price: {ProductPrice}";
    }
}