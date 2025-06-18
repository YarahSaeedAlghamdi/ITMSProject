using System;

public class User
{
    private int UserID;
    private string UserRole;
    private string UserName;
    private string UserEmail;
    private string UserPassword;

    // Constructor to initialize the user
    public User(int userId, string role, string name, string email, string password)
    {
        UserID = userId;
        UserRole = role;
        UserName = name;
        UserEmail = email;
        UserPassword = password;
    }

    public bool Login(string username, string password)
    {
        return (username == UserName) && (password == UserPassword);
    }

    public void LogOut()
    {
        Console.WriteLine("You have logged out successfully.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a user object
        User user = new User(1, "admin", "maha", "maha@email.com", "1234");

        // Try to log in
        Console.WriteLine("Enter username:");
        string inputName = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string inputPassword = Console.ReadLine();

        if (user.Login(inputName, inputPassword))
        {
            Console.WriteLine("Login successful!");
            // Do something...
            user.LogOut();
        }
        else
        {
            Console.WriteLine("Invalid credentials.");
        }
    }
}
