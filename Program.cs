User user = new User();
System.Console.WriteLine("User");
System.Console.Write("Firstname : ");
user.Firstname=Convert.ToString(Console.ReadLine());

System.Console.Write("Lastname : ");
user.Lastname=Convert.ToString(Console.ReadLine());
System.Console.Write("Username : ");
user.Username=Convert.ToString(Console.ReadLine());
System.Console.Write("Password : ");
user.Password=Convert.ToString(Console.ReadLine());


 System.Console.WriteLine();
 System.Console.WriteLine("Login :");
 System.Console.Write("Username : ");
 string username=Convert.ToString(Console.ReadLine());
 System.Console.Write("Password : ");
 string password=Convert.ToString(Console.ReadLine());
user.Login(username, password);

System.Console.WriteLine();
System.Console.WriteLine("Logout :");


System.Console.WriteLine();
System.Console.WriteLine("GetFullInfo");
 System.Console.WriteLine( user.GetFullInfo());