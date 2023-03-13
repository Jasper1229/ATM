namespace ATM;

public class AccountStorage
{
    private List<Account> _accounts = new List<Account>();

    public Account StoreAccount(Account account)
    {
        _accounts.Add(account);
        _accounts[_accounts.Count - 1].SetID(_accounts.Count - 1);
        return _accounts[_accounts.Count - 1];
    }

    public Account GetAccount(int id)
    {
        return _accounts[id];
    }
}