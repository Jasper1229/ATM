namespace ATM;

public class AccountStorage
{
    private Account[] accounts;

    public void StoreAccount(Account account)
    {
        accounts[accounts.Length] = account;
        accounts[accounts.Length].SetID(accounts.Length);
    }

    public Account GetAccount(int id)
    {
        return accounts[id];
    }
}