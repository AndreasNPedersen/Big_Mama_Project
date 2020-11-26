using System.Collections.Generic;

class ProductManagment: IManagement<Product>{
    
    private Dictionary<string,Product> _productDictionary = new Dictionary<string,Product>();

    public void Create(Product product){
        if (!_productDictionary.ContainsKey(product.ProductName)){
            _productDictionary.Add(product.ProductName,product);
        }        
    }
    
    public Product Retrieve(string name){
        if (_productDictionary.ContainsKey(name)){
           return _productDictionary[name];
        }
        return null;
    }

    public void Update(string name,Product product0){
        _productDictionary[name] = product0;
    }

    public void Delete(string navn){
        _productDictionary.Remove(navn);
    }

    public Dictionary<string,Product> GetAll(){
        return _productDictionary;
    }
}