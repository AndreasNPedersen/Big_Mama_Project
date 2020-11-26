
class Accessory : Product{

    public Accessory (){}

    public override string ToString()
    {
        return $"Accessory: {ProductName}, accessory number: {ProductNumber}, accessory count {NumberOfProducts}, accessory price: {ProductPrice}";
    }
}