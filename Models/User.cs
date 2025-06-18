public class User
{
    private int userID;
    private string userRole;
    private string userName;
    private string userEmail;
    private string userPassword;

    public bool Login(string username, string password)
    {
        return (username == userName) && (password == userPassword);
    }

    public void LogOut()
    {

        Console.WriteLine("you had logged out successfully ");
    }

    public override void navigateToHome()
    {
    }

    public int UserID
    {
        get { return userID; }
        set { userID = value; }
    }

    public string UserRole
    {
        get { return userRole; }
        set { userRole = value; }
    }

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public string UserEmail
    {
        get { return userEmail; }
        set { userEmail = value; }
    }

    public string UserPassword
    {
        get { return userPassword; }
        set { userPassword = value; }   
    }

} 