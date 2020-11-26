

class Customer{
    public string ID{get;set;}
    public string Name{get;set;}
    public int Postnumber{get;set;}
    public string Address{get;set;}
    public string Email{get;set;}
    public string PhoneNumber{get;set;}

    public Customer(){}
    
    public override string ToString(){
        return ($"ID: {ID}, Name: {Name}, Postnumber: {Postnumber}, Address: {Address}, Email: {Email}, Phonenumber: {PhoneNumber}");
    }
}