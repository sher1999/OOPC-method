public class User{
    public string Firstname;
    public string Lastname;
    public string Username;
    public string Password;
    public bool IsLoggedOn; 

    public void Login(string username, string password){
      
        if(Username==username && Password==password){
            Console.WriteLine("User logged successfully");
        Console.WriteLine(IsLoggedOn);
        }
        else{
           Console.WriteLine("Your password or username is incorrect"); 
           IsLoggedOn=false;
           Console.WriteLine(IsLoggedOn);
        }
    }

    public void Logout(){
        IsLoggedOn=false;
        Console.WriteLine(IsLoggedOn);
    }

    public string GetFullInfo(){
       return $"{Firstname} {Lastname} - {IsLoggedOn=true}";
    }


}