namespace trybank;

public class Trybank
{
    public bool Logged;
    public int loggedUser;

    //0 -> Número da conta
    //1 -> Agência
    //2 -> Senha
    //3 -> Saldo
    public int[,] Bank;
    public int registeredAccounts;
    private int maxAccounts = 50;
    public Trybank()
    {
        loggedUser = -99;
        registeredAccounts = 0;
        Logged = false;
        Bank = new int[maxAccounts, 4];
    }

    public void RegisterAccount(int number, int agency, int pass)
    {
        int numberIndex = 0;
        int agencyIndex = 1;
        int passIndex = 2;
        for (int i = 0; i < maxAccounts; i++)
        {
            if (Bank[i, 0] == number || Bank[i, 1] == agency)
                throw new ArgumentException("A conta já está sendo usada!");
        }
        Bank[registeredAccounts, numberIndex] = number;
        Bank[registeredAccounts, agencyIndex] = agency;
        Bank[registeredAccounts, passIndex] = pass;
        registeredAccounts += 1;
    }

    public void Login(int number, int agency, int pass)
    {
        if (Logged) throw new AccessViolationException("Usuário já está logado");
        for (int account = 0; account < maxAccounts; account++)
        {
            if (Bank[account, 0] == number && Bank[account, 1] == agency)
            {
                if (Bank[account, 2] != pass) throw new ArgumentException("Senha incorreta");
                loggedUser = account;
                Logged = true;
            }
        }
        if (!Logged) throw new ArgumentException("Agência + Conta não encontrada");
    }

    public void Logout()
    {
        if (!Logged) throw new AccessViolationException("Usuário não está logado");
        Logged = false;
        loggedUser = -99;
    }

    public int CheckBalance()
    {
        if (!Logged) throw new AccessViolationException("Usuário já está logado"); //??
        return Bank[loggedUser, 3];
    }

    public void Transfer(int destinationNumber, int destinationAgency, int value)
    {
        if (!Logged) throw new AccessViolationException("Usuário já está logado"); //??
        if (value > CheckBalance()) throw new InvalidOperationException("Saldo insuficiente");
        Withdraw(value);
        for (int i = 0; i < registeredAccounts; i++)
        {
            if (Bank[i, 0] == destinationNumber && Bank[i, 1] == destinationAgency)
            {
                Bank[i, 3] += value;
            }
        }
    }

    public void Deposit(int value)
    {
        if (!Logged) throw new AccessViolationException("Usuário já está logado"); //??
        Bank[loggedUser, 3] = Bank[loggedUser, 3] + value;
    }

    public void Withdraw(int value)
    {
        if (!Logged) throw new AccessViolationException("Usuário já está logado"); //??
        if (Bank[loggedUser, 3] < value) throw new InvalidOperationException("Saldo insuficiente"); //??
        Bank[loggedUser, 3] = Bank[loggedUser, 3] - value;
    }
}
