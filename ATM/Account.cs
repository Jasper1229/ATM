namespace ATM;

public class Account
{
    private double balance;
    private string name;
    private string password;
    private int account_id;

    public Account(string name, string password, int account_id)
    {
        this.name = name;
        this.password = password;
        this.account_id = account_id;
        this.balance = 0;
    }

    public void setBalance(double number)
    {
        this.balance = number;
    }

    public void modifyBalance(double number)
    {
        this.balance += number;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public void setPassword(string password)
    {
        this.password = password;
    }

    public int getAccountID()
    {
        return this.account_id;
    }

    public string getName()
    {
        return this.name;
    }

    public string getPassword()
    {
        return this.password;
    }
}