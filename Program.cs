User user = new User();
user.Firstname="Sherzod";
user.Lastname="Ishankulov";
user.Username="sher1111";
user.Password="711112607";
user.IsLoggedOn=true;

 System.Console.WriteLine();
 System.Console.WriteLine("Login :");
user.Login("sher1111", "711112607");

System.Console.WriteLine();
System.Console.WriteLine("Logout :");
user.Logout();

System.Console.WriteLine();
System.Console.WriteLine("GetFullInfo");
 System.Console.WriteLine( user.GetFullInfo());