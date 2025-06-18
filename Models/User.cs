using System;

public class User
{
    private int UserID;
    private string UserRole;
    private string UserName;
    private string UserEmail;
    private string UserPassword;
<<<<<<< HEAD

    // Constructor to initialize the user
    public User(int userId, string role, string name, string email, string password)
    {
        UserID = userId;
        UserRole = role;
        UserName = name;
        UserEmail = email;
        UserPassword = password;
    }
=======
>>>>>>> 45f6ee20444e5d8aa803dca2a2d7fbc85e65924c

    public bool Login(string username, string password)
    {
        return (username == UserName) && (password == UserPassword);
    }

    public void LogOut()
    {
<<<<<<< HEAD
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
=======

        Console.WriteLine("you had logged out successfully ");
    }
    public override void navigateToHome()
    {
       
    }

>>>>>>> 45f6ee20444e5d8aa803dca2a2d7fbc85e65924c
}
