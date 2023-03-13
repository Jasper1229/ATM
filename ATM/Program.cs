
using ATM;

AccountStorage storage = new AccountStorage();

Main();

void Main()
{
    Console.Clear();
    Console.WriteLine("Hello! Welcome to Jasper Banking. Press '1' to start the sign in process. Press '2' to create a new account.");

    string mainInput = Console.ReadLine();

    if (mainInput == "1")
    {
        SignIn();
    } 
    else if (mainInput == "2")
    {
        CreateAccount();    
    }
    else
    {
        Main();
    }
}


void CreateAccount()
{
    Console.Clear();
    Console.WriteLine("Enter Your Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter a Password: ");
    string password;
    password = Console.ReadLine();
    if (password == null || name == null)
    {
        Console.WriteLine("Invalid name or password. ");
    }

    Account account = new Account(name, password);
    Account storedAccount = storage.StoreAccount(account);
    Console.WriteLine("Your account id is: " + storedAccount.GetAccountID());
    Console.WriteLine("Account Created. Return to main page by pressing enter.");
    Console.ReadLine();
    Main();
}



void SignIn()
{
    Console.Clear();
    Console.WriteLine("Enter Your Account ID: ");
    
    int idInput = 0;
    
    try
    {
        idInput = Int32.Parse(Console.ReadLine());
    }
    catch (System.FormatException)
    {
        Console.WriteLine("ERROR: Your account id must be an integer. (ex. '1, 100, 23') ");
        SignIn();
    }

    int counter = 0;
    bool signedIn = false;
    Console.WriteLine("Enter Your Password: ");
    string passwordInput;
    while(counter < 3)
    {
        passwordInput = Console.ReadLine();
        if (passwordInput == storage.GetAccount(idInput).GetPassword() && storage.GetAccount(idInput).GetActivated())
        {
            counter = 3;
            signedIn = true;
        }
        else if (passwordInput == storage.GetAccount(idInput).GetPassword() && !storage.GetAccount(idInput).GetActivated())
        {
            Console.WriteLine("Unfortunately your account has been disabled.");
            SignIn();
        }
        else {
            counter++;
            Console.WriteLine("Incorrect Password. You have " + (3-counter) + " attempts remaining.");
        }
        
    }

    if (signedIn)
    {
        AccountLoggedIn(storage.GetAccount(idInput));
    }
    else
    {
        Main();
    }
    

}

void AccountLoggedIn(Account account)
{
    Console.Clear();
    Console.WriteLine("\nName: " + account.GetName() + "\nID: " + account.GetAccountID() + "\nBalance: $" + account.GetBalance());
}


