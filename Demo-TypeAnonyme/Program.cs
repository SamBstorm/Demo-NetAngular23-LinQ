using Demo_TypeAnonyme;

Produit prod_1 = new Produit() { Nom = "Kinder Bueno", Marque="Kinder", RefProduit="KD15034", Prix=1.2M, CodeBar13=1234567890123, Description="Barres chocolatées avec fourage de noisettes"};

var prod_1_little = new { Name = prod_1.Nom, Price = prod_1.Prix, prod_1.RefProduit };

Console.WriteLine( $"{prod_1_little.Name} Prix : {prod_1_little.Price} € - ref:{prod_1_little.RefProduit}");
