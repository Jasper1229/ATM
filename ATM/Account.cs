namespace ATM;

public class Account
{
    private double balance;
    private string name;
    private string password;
    private int account_id;
    private bool activated;

    public Account(string name, string password)
    {
        this.name = name;
        this.password = password;
        this.balance = 0.0;
        this.activated = true;
    }

    public void SetActivated(bool activated)
    {
        this.activated = activated;
    }
    public void SetBalance(double number)
    {
        this.balance = number;
    }

    public void ModifyBalance(double number)
    {
        this.balance += number;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetID(int id)
    {
        this.account_id = id;
    }

    public void SetPassword(string password)
    {
        this.password = password;
    }

    public int GetAccountID()
    {
        return this.account_id;
    }

    public double GetBalance()
    {
        return this.balance;
    }

    public string GetName()
    {
        return this.name;
    }

    public string GetPassword()
    {
        return this.password;
    }

    public bool GetActivated()
    {
        return this.activated;
    }
}