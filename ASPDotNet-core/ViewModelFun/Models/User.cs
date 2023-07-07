namespace ViewModelFun.Models;

public class User
{    
    // We must put {get;set;} after all our properties
    // This will give ASP.NET Core the permissions it needs to modify the values    
    public string? FirstName {get;set;}
    public string? LastName {get;set;}

    public User()
    {
        FirstName = "";
        LastName = "";
    }
    public User(string F, string L)
    {
        FirstName = F;
        LastName = L;
    }

}

