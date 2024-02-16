// See https://aka.ms/new-console-template for more information
using task16feb;

Console.WriteLine("<=== Welcome to Products Page ===>");

     List<Product> products = new List<Product>()
        {
            new Product(){PName="Hair Gel",PPrice=67,PBrand="SetWet",MfgDate=new DateTime(day:15,month:01,year:2012),ExpDate=new DateTime(day:15,month:12,year:2012)},
            new Product(){PName="Deodrant",PPrice=158,PBrand="Axe",MfgDate=new DateTime(day:28,month:01,year:2012),ExpDate=new DateTime(day:15,month:11,year:2012)},
            new Product(){PName="Soapl",PPrice=31,PBrand="Santoor",MfgDate=new DateTime(day:06,month:06,year:2011),ExpDate=new DateTime(day:30,month:08,year:2012)},
            new Product(){PName="Talk",PPrice=67,PBrand="Ponds",MfgDate=new DateTime(day:18,month:02,year:2012),ExpDate=new DateTime(day:31,month:12,year:2012)},
        };
  
        foreach (Product product in products)
        {
           
            //Console.WriteLine(product.PName+"\t"+ product.PPrice + "\t" + product.PBrand + "\t" + product.MfgDate + "\t" + product.ExpDate);
            Console.WriteLine(product.PName);
            Console.WriteLine(product.PPrice);
            Console.WriteLine(product.PBrand);
            Console.WriteLine(product.MfgDate);
            Console.WriteLine(product.ExpDate);
        }

    
