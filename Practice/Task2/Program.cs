using Task2;

var cat1 = new Cat("Kissy");
cat1.Greets();
 System.Console.WriteLine("<===============================================================================>");

var dog1 = new Dog("Tobby");
dog1.Greets();
dog1.Greets(dog1);
 System.Console.WriteLine("\n<===============================================================================>");
 var bigDog1 = new BigDog("Rembo");
 bigDog1.Greets();

 bigDog1.Greets(dog1);

 bigDog1.Greets(bigDog1);