using System;
using NUnit.Framework;

[TestFixture]
public class Tester
{
    private double epsilon = 1e-6;

    [Test]
    public void AccountCannotHaveNegativeOverdraftLimit()
    {
        Account account = new Account(-20);

        Assert.AreEqual(0, account.OverdraftLimit, epsilon);
    }
    [Test]
    public void WithdrawCannotBeNegative()
    {
        Account account = new Account(20);
        bool output = account.Withdraw(-5);
        Assert.AreEqual(output, false);
    }
    [Test]
    public void DepositCannotBeNegative()
    {
        Account account = new Account(20);
        bool output = account.Deposit(-5);
        Assert.AreEqual(output, false);
    }
    [Test]
    public void CannotOverdrawOverLimit()
    {
        Account account = new Account(20);
        bool output = account.Withdraw(25);
        Assert.AreEqual(output, false);
    }
    [Test]
    public void DepositCorrect()
    {
        Account account = new Account(20);
        account.Deposit(20);
        Assert.AreEqual(account.Balance, 20, epsilon);
    }
    [Test]
    public void WithdrawCorrect()
    {
        Account account = new Account(20);
        account.Withdraw(5);
        Assert.AreEqual(account.Balance, -5, epsilon);
    }
    [Test]
    public void DepositCorrectBool()
    {
        Account account = new Account(20);
        bool output = account.Deposit(5);
        Assert.AreEqual(output, true);
    }
    [Test]
    public void WithdrawCorrectBool()
    {
        Account account = new Account(20);
        bool output = account.Withdraw(5);
        Assert.AreEqual(output, true);
    }
}