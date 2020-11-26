public class Topping : Product{
    public Topping (){}

    public override string ToString()
    {
        return $"Topping: {ProductName}, topping number: {ProductNumber}, topping count: {NumberOfProducts}, topping price: {ProductPrice}";
    }   
}