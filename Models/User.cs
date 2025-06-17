public class User
{
    private int UserID;     
    private string UserRole; 
    private string UserName;     
    private string UserEmail;     
    private string UserPassword; 

    public bool Login(string username, string password)
    {
         return (username == UserName) && (password == UserPassword);
    }

    public void LogOut()
    {
        
        Console.WriteLine("you had logged out successfully ");
    }

}
