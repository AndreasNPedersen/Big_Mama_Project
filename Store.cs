using System;
using System.Collections.Generic;

namespace Big_Mama
{
    class Program
    {
        static void Main(string[] args)
        {
            bool close = false;
           OrderHandler orderHandler = new OrderHandler();
           // for at lave en kunde, Til sidst i min ordering kan der tilføjes navnet på kunden(ikke gjort).
           Customer customer = new Customer();
           customer.Name="Andreas";
           customer.Address="Roskilde";
           orderHandler.AddCustomer(customer); 

          
            while(!close){
                Console.WriteLine("Velkommen til Big Mamma");
                Console.WriteLine("indtast følgende:");
                Console.WriteLine("'1': for at vise pizza menu, '2': for at tilføje en nyt produkt," +
                "'3': for at updater en produkt, '4': for at søge/slette et produkt. '5': for at tilføje produkter til en ordre," +
                " '6': for at finde en ordre med et ID, '7': for at vise listen af ordre, '8' for håndtering af kunde. '9: for at lukke programmet.");
                
                try{
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch(input){
                        case 1:
                        Console.WriteLine(orderHandler.GetProductList());
                    break;
                        case 2:
                        Console.WriteLine("Nu vil du tilføje et produkt, vælg hvilket produkt" +
                        ", 'Pizza':1,'Menu':2,'Ekstra tilbehør':3,'Topping':4");
                        int productInput = Convert.ToInt32(Console.ReadLine());
                        switch(productInput){
                            case 1:
                            Pizza pizza1=new Pizza();
                            Console.WriteLine("Pizzaens ID: (kun heltal)");
                            int inputIDP = Convert.ToInt32(Console.ReadLine());
                            pizza1.ProductNumber=inputIDP;
                            Console.WriteLine("Pizzaens navn:");
                            string inputnameP = Console.ReadLine();
                            while(orderHandler.GetProductList().Contains(inputnameP)){
                                Console.WriteLine("Navnet er brugt, prøv igen.");
                                inputnameP = Console.ReadLine();
                            }
                            pizza1.ProductName=inputnameP;
                            Console.WriteLine("Pizzaens pris: tal");
                            double inputPriceP = Convert.ToDouble(Console.ReadLine());
                            pizza1.ProductPrice=inputPriceP;
                            Console.WriteLine("Pizzaens ingredienser (en lang tekst)");
                            string inputIngrediensP = Console.ReadLine();
                            pizza1.Ingrediens=inputIngrediensP;
                            orderHandler.AddProduct(pizza1);
                            break;
                            case 2:
                            List<Product> menuList = new List<Product>();
                            Menu menu1 = new Menu();
                            Console.WriteLine("Menuens ID: (kun heltal)");
                            int inputIDM = Convert.ToInt32(Console.ReadLine());
                            menu1.ProductNumber=inputIDM;
                            Console.WriteLine("Menuens navn:");
                            string inputnameM = Console.ReadLine();
                            while(orderHandler.GetProductList().Contains(inputnameM)){
                                Console.WriteLine("Navnet er brugt, prøv igen.");
                                inputnameM = Console.ReadLine();
                            }
                            menu1.ProductName=inputnameM;
                            Console.WriteLine("Menuens pris: tal");
                            double inputPriceM = Convert.ToDouble(Console.ReadLine());
                            menu1.ProductPrice=inputPriceM;
                            Console.WriteLine("Menuens Produkter (Produktets præcise navn)");
                            bool finishMenu = false;
                            while(!finishMenu){
                               string inputPizzaName = Console.ReadLine(); 
                               if (inputPizzaName != "0"){
                               menuList.Add(orderHandler.GetProduct(inputPizzaName));
                               Console.WriteLine("skriv 0 for at færdiggøre ellers bliv ved");
                                }
                                else{
                                    finishMenu = true;
                                }
                            }
                            menu1.Products=menuList;          
                            orderHandler.AddProduct(menu1);
                            break;
                            case 3:
                            Accessory accessory = new Accessory();
                            Console.WriteLine("Ekstra tilbørens ID: (kun heltal)");
                            int inputIDA = Convert.ToInt32(Console.ReadLine());
                            accessory.ProductNumber=inputIDA;
                            Console.WriteLine("Ekstra tilbørens navn:");
                            string inputnameA = Console.ReadLine();
                            while(orderHandler.GetProductList().Contains(inputnameA)){
                                Console.WriteLine("Navnet er brugt, prøv igen.");
                                inputnameA = Console.ReadLine();
                            }
                            accessory.ProductName=inputnameA;
                            Console.WriteLine("Ekstra tilbørens pris: tal");
                            double inputPriceA = Convert.ToDouble(Console.ReadLine());
                            accessory.ProductPrice=inputPriceA;
                            orderHandler.AddProduct(accessory);
                            break;
                            case 4:
                            Topping topping = new Topping();
                            Console.WriteLine("Toppingens ID: (kun heltal)");
                            int inputIDT = Convert.ToInt32(Console.ReadLine());
                            topping.ProductNumber=inputIDT;
                            Console.WriteLine("Toppingens navn:");
                            string inputnameT = Console.ReadLine();
                            while(orderHandler.GetProductList().Contains(inputnameT)){
                                Console.WriteLine("Navnet er brugt, prøv igen.");
                                inputnameT = Console.ReadLine();
                            }
                            topping.ProductName=inputnameT;
                            Console.WriteLine("Toppingens pris: tal");
                            double inputPriceT = Convert.ToDouble(Console.ReadLine());
                            topping.ProductPrice=inputPriceT;
                            orderHandler.AddProduct(topping);
                            break;
                        }
                    break;
                        case 3:
                        Console.WriteLine("Nu vil du redigere et produkt, vælg hvilket produkt" +
                        ", 'Pizza':1,'Menu':2,'Ekstra tilbehør':3,'Topping':4");
                        int productInputR = Convert.ToInt32(Console.ReadLine());
                        switch(productInputR){
                            case 1:
                            Console.WriteLine("Pizzaens navn:");
                            string inputnameP = Console.ReadLine();
                            Pizza pizza1 = (Pizza)orderHandler.GetProduct(inputnameP);
                            pizza1.ProductName=inputnameP;
                            Console.WriteLine("Pizzaens nye ID: (kun heltal)");
                            int inputIDP = Convert.ToInt32(Console.ReadLine());
                            pizza1.ProductNumber= inputIDP;
                            Console.WriteLine("Pizzaens nye pris: tal");
                            double inputPriceP = Convert.ToDouble(Console.ReadLine());
                            pizza1.ProductPrice=inputPriceP;
                            Console.WriteLine("Pizzaens nye ingredienser (en lang tekst)");
                            string inputIngrediensP = Console.ReadLine();
                            pizza1.Ingrediens=inputIngrediensP;
                            orderHandler.SetProduct(inputnameP,pizza1);
                            break;
                            case 2:
                            Console.WriteLine("Menuens navn:");
                            string inputnameM = Console.ReadLine();
                            Menu menu1 = (Menu) orderHandler.GetProduct(inputnameM);
                            menu1.ProductName=inputnameM;
                            Console.WriteLine("Menuens nye ID: (kun heltal)");
                            string inputIDM = Console.ReadLine();
                            menu1.ProductNumber=Convert.ToInt32(inputIDM);
                            Console.WriteLine("Menuens nye pris: tal");
                            double inputPriceM = Convert.ToDouble(Console.ReadLine());
                            menu1.ProductPrice=inputPriceM;
                            Console.WriteLine("Menuens nye Produkter (Produktets præcise navn)");
                            bool finishMenu = false;
                            List<Product> menuList = new List<Product>();
                            while(!finishMenu){
                               string inputPizzaID = Console.ReadLine(); 
                               if (inputPizzaID != "0"){
                               menuList.Add(orderHandler.GetProduct(inputPizzaID));
                               Console.WriteLine("skriv 0 for at færdiggøre og gå videre");
                                   } else{
                                   finishMenu = true;
                                   }
                            }          
                            orderHandler.SetProduct(inputnameM,menu1);
                            break;
                            case 3:
                            Console.WriteLine("Ekstra tilbørens navn:");
                            string inputnameA = Console.ReadLine();
                            Accessory accessory = (Accessory) orderHandler.GetProduct(inputnameA);
                            accessory.ProductName=inputnameA;
                            Console.WriteLine("Ekstra tilbørens nye ID: (kun heltal)");
                            string inputIDA = Console.ReadLine();
                            accessory.ProductNumber= Convert.ToInt32(inputIDA);
                            Console.WriteLine("Ekstra tilbørens nye pris: tal");
                            double inputPriceA = Convert.ToDouble(Console.ReadLine());
                            accessory.ProductPrice=inputPriceA;
                            orderHandler.SetProduct(inputnameA,accessory);
                            break;
                            case 4:
                            Console.WriteLine("Toppingens navn:");
                            string inputnameT = Console.ReadLine();
                            Topping topping = (Topping) orderHandler.GetProduct(inputnameT);
                            topping.ProductName=inputnameT;
                            Console.WriteLine("Toppingens nye ID: (kun heltal)");
                            string inputIDT = Console.ReadLine();
                            topping.ProductNumber=Convert.ToInt32(inputIDT);
                            Console.WriteLine("Toppingens nye pris: tal");
                            double inputPriceT = Convert.ToDouble(Console.ReadLine());
                            topping.ProductPrice=inputPriceT;
                            orderHandler.SetProduct(inputnameT,topping);
                            break;
                        }
                    break;
                        case 4:
                        Console.WriteLine("Du har valgt at søge efter et produkt, vælg hvilket produkt du vil søge efter" + 
                        ". 1:Pizza, 2:Menu, 3: Ekstra Tilbehør, 4: Toppings, 5: slette et produkt");
                        int inputSearch = Convert.ToInt32(Console.ReadLine());
                        switch(inputSearch){
                            case 1:
                            Console.WriteLine("vælg hvilken pizza udfra dets præcise navn");
                            string inputSP = Console.ReadLine();
                            Pizza pizzaS = (Pizza) orderHandler.GetProduct(inputSP);
                            Console.WriteLine(pizzaS.ToString());
                            break;
                            case 2:
                            Console.WriteLine("vælg hvilken menu udfra dets præcise navn");
                            string inputSM = Console.ReadLine();
                            Menu menuS = (Menu) orderHandler.GetProduct(inputSM);
                            Console.WriteLine(menuS.ToString()); 
                            break;
                            case 3:
                            Console.WriteLine("vælg hvilken menu udfra dets præcise navn");
                            string inputSA = Console.ReadLine();
                            Accessory accessoryS = (Accessory) orderHandler.GetProduct(inputSA);
                            Console.WriteLine(accessoryS.ToString()); 
                            break;
                            case 4:
                            Console.WriteLine("vælg hvilken menu udfra dets præcise navn");
                            string inputST = Console.ReadLine();
                            Topping toppingS = (Topping) orderHandler.GetProduct(inputST);
                            Console.WriteLine(toppingS.ToString()); 
                            break;
                            case 5:
                            Console.WriteLine("vælg hvilket produkt udfra dets præcise navn");
                            string inputDP = Console.ReadLine();
                            orderHandler.DeleteProduct(inputDP);
                            break;
                        }
                    break;
                        case 5:
                        Console.WriteLine("Du har valgt at tilføje produkter til din ordre" +
                        ". Du har 2 valgmuligheder, '1': at tage en pizza/menu/Ekstra tilbehør "+
                        "eller '2': at vælge en pizza og vælge hvad mere topping(s) der skal på. Dertil '3':køb");
                            Order order = new Order();
                            List<Product> productsList = new List<Product>();
                            List<Product> toppingList = new List<Product>();
                        bool orderMaker = false;
                        while(!orderMaker){
                            int inputOrderMaker = Convert.ToInt32(Console.ReadLine());
                            switch(inputOrderMaker){
                                case 1:
                                Console.WriteLine("Indtast produktets navn");
                                string inputOP = Console.ReadLine();
                                Console.WriteLine("Indtast hvor mange");
                                Product product = orderHandler.GetProduct(inputOP);
                                int inputCount = Convert.ToInt32(Console.ReadLine());
                                product.NumberOfProducts = inputCount;
                                productsList.Add(product);
                                break;
                                case 2:
                                Console.WriteLine("indtast pizzaens navn");
                                string inputOC = Console.ReadLine();
                                Pizza pizzaC = (Pizza) orderHandler.GetProduct(inputOC);
                                pizzaC.NumberOfProducts=1;
                                bool pizzaMakerToppings = false;
                                while(!pizzaMakerToppings){
                                Console.WriteLine("indtast toppings navn:");
                                string inputToppings = Console.ReadLine();
                                    if(inputToppings=="0"){
                                        pizzaMakerToppings=true; 
                                        pizzaC.toppings = toppingList;
                                    }
                                    else{
                                        Topping topping = (Topping)orderHandler.GetProduct(inputToppings);
                                        topping.NumberOfProducts = 1;
                                        toppingList.Add(topping);
                                        pizzaC.toppings = toppingList;
                                        productsList.Add(orderHandler.GetProduct(inputToppings));
                                        productsList.Add(pizzaC);
                                        Console.WriteLine("skriv 0, for at stoppe med at sætte toppings på pizzaen");
                                    }
                                }
                                break;
                                case 3:
                                orderMaker = true;
                                order.deliveryTakeAway=false;
                                order._theCustomer = customer;
                                order._productsListOrder = productsList;
                                Console.WriteLine("du har nu købt produkter, vil du have take-away? 1: Ja, 2:Nej");
                                string inputTakeAway = Console.ReadLine();
                                if(inputTakeAway=="1"){
                                    order.deliveryTakeAway=true;
                                }
                                orderHandler.AddOrder(order);
                                break; 
                            }
                            Console.WriteLine("indtast et produkt mere udfra nr. '1' eller nr. '2', eller stop ved at indtaste '3'");
                        }
                    break;
                        case 6:
                        Console.WriteLine("Du har valgt at søge efter en ordre, indtast det præcise ordre ID");
                        string inputOrdreID = Console.ReadLine();
                        Order order1 = orderHandler.GetOrder(inputOrdreID);
                        Console.WriteLine(order1.ToString()); 
                    break;
                        case 7:
                        Console.WriteLine("Du har valgt at se efter alle ordre:");
                        Console.WriteLine(orderHandler.GetAllOrders().ToString()); 
                        Console.WriteLine("Du har en total calculution på:");
                        Console.WriteLine(orderHandler.CalculateTotalPrice());
                    break;
                        case 8:
                        Console.WriteLine("Du har valgt at have med kunden, '1' for at lave en kunde, '2' for at se en kunde, '3' for at slette en kunde, '4' for at se alle kunder og '5' for at afslutte kundedelen");
                        int inputCustomerChoice = Convert.ToInt32(Console.ReadLine());
                        switch(inputCustomerChoice){
                            case 1:
                            Console.WriteLine("tilføj en kunde, vælg navn:");
                            Customer customer1 = new Customer();
                            string inputnameCustomer= Console.ReadLine();
                            customer1.Name=inputnameCustomer;
                            Console.WriteLine("Kundens postaddresse ");
                            int inputPCustomer= Convert.ToInt32(Console.ReadLine());
                            customer1.Postnumber=inputPCustomer;
                            Console.WriteLine("Kundens addresse:");
                            string inputACustomer= Console.ReadLine();
                            customer1.Address=inputACustomer;
                            Console.WriteLine("Kundens email");
                            string inputECustomer= Console.ReadLine();
                            customer1.Email=inputECustomer;
                            Console.WriteLine("Kundens telefonnummer:");
                            string inputTCustomer= Console.ReadLine();
                            customer1.PhoneNumber=inputTCustomer;
                            orderHandler.AddCustomer(customer1);
                            break;
                            case 2:
                            Console.WriteLine("se en kunde, indtast navn:");
                            string inputGetCustomer = Console.ReadLine();
                            Customer customer2 = orderHandler.GetCustomer(inputGetCustomer);
                            Console.WriteLine(customer2.ToString());
                            break;
                            case 3:
                            Console.WriteLine("slet en kunde, indtast navn:");
                            string inputdelCustomer = Console.ReadLine();
                            orderHandler.DeleteCustumer(inputdelCustomer);
                            break;
                            case 4:
                            Console.WriteLine("Her er alle kunder");
                            Console.WriteLine(orderHandler.GetAllCustomers());
                            break;
                            case 5:
                            break;
                        }
                    break;
                        case 9:
                        close = true;
                    break;
                        default:
                    break;
                }
                } catch (Exception ex){
                    if(ex is System.FormatException){
                    Console.WriteLine("Du må kun indtaste som det nøjagtig står fx '{tingen du vil in på}':{talet}" +
                    ", eller Pizzaens ID : {kun hel tal}. Din præcise fejl var " + ex.Message);
                    }
                    if (ex is System.NullReferenceException)
                    Console.WriteLine(ex.Message);
                    
                }

            }

        }
    }
}
