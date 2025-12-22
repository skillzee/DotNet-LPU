// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using InterfaceDemo;

IAdd m1  = new MathClass();
IAddSub m2  = new MathClass();
// IAll m3  = new MathClass();



// int res = m1.AddMe(67, 3);

// System.Console.WriteLine(res);



//approach 1
Product pObj = new Product();

pObj.ProdID = 101;
pObj.Name = "Flask";
pObj.Price = 850;



// Approach 2
// Object Initialiser

Product pObj1 = new Product()
{
    ProdID = 102,
    Name = "Cap",
    Price = 800
};



// Approach 3
// Collection Initialiser


List<Product> prodList = new List<Product>()
{
    new Product()
{
    ProdID = 102,
    Name = "Cap",
    Price = 800
},

    new Product(){ProdID=103, Name="Ball", Price = 50},
    new Product(){ProdID=104, Name="Bat", Price = 50},

};


foreach(var item in prodList)
{
    System.Console.WriteLine($"{item.ProdID}\t{item.Name}\t{item.Price}");
}



