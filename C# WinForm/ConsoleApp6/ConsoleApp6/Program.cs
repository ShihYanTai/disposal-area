using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static ConsoleApp6.Program;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ==========================================
            //DeadLock Sample
            //Console.WriteLine("1. DeadLockSample() ============================ ");
            //DeadLockSample();
            //We can fix the deadlock issue by the specific lock order.
            //Console.WriteLine("2. specific defined lock accuire order can fix DeadLock ================");
            //SpecificDefinedLockAccuireOrder();
            Console.WriteLine("3. Mutex can fix DeadLock V1 ================ ");
            MutexSample();
            Console.ReadKey();
        }

        static void DeadLockSample()
        {
            Console.WriteLine("Beginning of DeadLockSample() ‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐ ");
            Account accA = new Account(1, 4000);
            Account accB = new Account(2, 2000);
            TransferHelper transferHelperA =
                new TransferHelper(accA, accB, 1000);
            Thread t1 = new Thread(transferHelperA.Transfer)
            {
                Name = "t1"
            };
            TransferHelper transferHelperB = new
                TransferHelper(accB, accA, 500);
            Thread t2 = new Thread(transferHelperB.Transfer)
            {
                Name = "t2"
            };
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("End of DeadLockSample() ‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐ ");
        }
        static void SpecificDefinedLockAccuireOrder()
        {
            Console.WriteLine("Beginning of SpecificDefinedLockAccuireOrder() ‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐ ");
            Account accA = new Account(1, 4000);
            Account accB = new Account(2, 2000);
            TransferHelper2 transferHelperA =
                new TransferHelper2(accA, accB, 1000);
            Thread t1 = new Thread(transferHelperA.Transfer)
            {
                Name = "t1"
            };
            TransferHelper2 transferHelperB = new
                TransferHelper2(accB, accA, 500);
            Thread t2 = new Thread(transferHelperB.Transfer)
            {
                Name = "t2"
            };
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine($"accA.id=={accA.Id},accA.Balance=={accA.Balance} ;accB.id =={accB.Id},accB.Balance =={accB.Balance}");
            Console.WriteLine("End of SpecificDefinedLockAccuireOrder() ‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐ ");
        }

        static void MutexSample()
        {
            Console.WriteLine("Beginning of MutexSample() ‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐ ");
            AccountA accA = new AccountA(1, 4000);
            AccountA accB = new AccountA(2, 2000);
            Thread t1 = new Thread(() => accB.TransferFrom(accA, 1000))
            {
                Name = "t1"
            };
            Thread t2 = new Thread(() => accA.TransferFrom(accB, 500))
            {
                Name = "t2"
            };
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine($"accA.id=={accA.Id},accA.Balance=={accA.Balance} ; accB.id=={accB.Id},accB.Balance=={accB.Balance}");
            Console.WriteLine("End of MutexSample() ‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐‐ ");
        }
        public class Account
        {
            public double Balance { get; set; }
            public int Id { get; }
            public Account(int id, double balance)
            {
                Id = id;
                Balance = balance;
            }
            public void Withdraw(double amount)
            {
                Balance -= amount;
            }
            public void Deposit(double amount)
            {
                Balance += amount;
            }
        }
        public class TransferHelper
        {
            Account _fromAccount;
            Account _toAccount;
            double _amount;
            public TransferHelper(Account fromAccount, Account toAccount, double amount)
            {
                _fromAccount = fromAccount;
                _toAccount = toAccount;
                _amount = amount;
            }
            public void Transfer()
            {
                Console.WriteLine($"Beginning of Transfer, Thread.CurrentThread.Name=={ Thread.CurrentThread.Name},_fromAccount.Id =={ _fromAccount.Id} , _toAccount.Id =={_toAccount.Id}, _amount =={_amount}");
                Console.WriteLine($"Thread.CurrentThread.Name=={ Thread.CurrentThread.Name}, is about to lock (_fromAccount), and _fromAccount.Id =={ _fromAccount.Id}");
                lock (_fromAccount)
                {
                    Console.WriteLine($"Thread.CurrentThread.Name=={Thread.CurrentThread.Name}, lock (_fromAccount) acquired lock on _fromAccount.Id =={_fromAccount.Id}");
                    Thread.Sleep(1000); // wait for 1000 milliseconds

                    Console.WriteLine($"Thread.CurrentThread.Name=={Thread.CurrentThread.Name}, is about to lock (_toAccount), and _toAccount.Id =={_toAccount.Id}");
                    lock (_toAccount)
                    {
                        Console.WriteLine($"Thread.CurrentThread.Name=={Thread.CurrentThread.Name}, lock (_toAccount) acquired lock on _toAccount.Id =={_toAccount.Id}");
                        _fromAccount.Withdraw(_amount);
                        _toAccount.Deposit(_amount);
                    }
                }
                Console.WriteLine($"End of Transfer, Thread.CurrentThread.Name=={Thread.CurrentThread.Name}, _fromAccount.Id =={_fromAccount.Id} , _toAccount.Id =={_toAccount.Id}, _amount =={_amount} ");
            }
        }
        public class TransferHelper2
        {
            Account _fromAccount;
            Account _toAccount;
            double _amount;
            public TransferHelper2(Account fromAccount, Account toAccount, double amount)
            {
                _fromAccount = fromAccount;
                _toAccount = toAccount;
                _amount = amount;
            }
            public void Transfer()
            {
                Console.WriteLine( $"Beginning of Transfer, Thread.CurrentThread.Name=={Thread.CurrentThread.Name},_fromAccount.Id =={_fromAccount.Id} , _fromAccount.Balance =={_fromAccount.Balance},_toAccount.Id =={_toAccount.Id}, _toAccount.Balance =={_toAccount.Balance}, _amount =={_amount}");
                //***check the comment
                object _lockA =
                    _fromAccount.Id < _toAccount.Id ?
                    _fromAccount :
                    _toAccount;
                object _lockB =
                    _fromAccount.Id > _toAccount.Id ?
                    _fromAccount :
                    _toAccount;
                Console.WriteLine($"Thread.CurrentThread.Name=={ Thread.CurrentThread.Name}, is about tolock (_lockA), and((Account)_lockA).Id =={ ((Account)_lockA).Id}");
                lock (_lockA)
                {
                    Console.WriteLine($"Thread.CurrentThread.Name=={ Thread.CurrentThread.Name}, lock(_lockA) acquired lock on((Account)_lockA).Id =={ ((Account)_lockA).Id}");
                    Thread.Sleep(1000); // wait for 1000 milliseconds
                    Console.WriteLine($"Thread.CurrentThread.Name=={ Thread.CurrentThread.Name}, is about tolock (_lockB), and((Account)_lockB).Id =={ ((Account)_lockB).Id}");
                    lock (_lockB)
                    {
                        Console.WriteLine($"Thread.CurrentThread.Name=={ Thread.CurrentThread.Name}, lock (_lockB) acquired lock on((Account)_lockB).Id =={((Account)_lockB).Id}");
                        _fromAccount.Withdraw( _amount);
                        _toAccount.Deposit(_amount);
                    }
                }
                Console.WriteLine($"End of Transfer, Thread.CurrentThread.Name=={ Thread.CurrentThread.Name},_fromAccount.Id =={_fromAccount.Id} , _fromAccount.Balance =={_fromAccount.Balance},_toAccount.Id =={_toAccount.Id}, _toAccount.Balance =={_toAccount.Balance}, _amount =={_amount}");
            }
        }
        public class AccountA
        {
            public int Id { get; set; }
            public double Balance { get; set; }
            Mutex _mutexLock = new Mutex();
            public AccountA(int id, double balance)
            {
                Id = id;
                Balance = balance;
            }
            //check the comment
            public void Withdraw(double amount)
            {
                if (!_mutexLock.WaitOne()) return;
                try
                {
                    Balance -= amount;
                }
                finally
                {
                    _mutexLock.ReleaseMutex();
                }
            }
            public void Deposit(double amount)
            {
                if (!_mutexLock.WaitOne()) return;
                try
                {
                    Balance += amount;
                }
                finally
                {
                    _mutexLock.ReleaseMutex();
                }
            }
            //Transfer the "amount" from "fromAcc" into current object, which is "toAcc"
            public void TransferFrom(AccountA fromAcc, double amount)
            {
                Console.WriteLine(
                    $"Beginning of TransferFrom, Thread.CurrentThread.Name=={Thread.CurrentThread.Name}, fromAcc.Id =={ fromAcc.Id} , fromAcc.Balance =={ fromAcc.Balance}, _toAccount.Id == this.Id =={ Id}, _toAccount.Balance == this.Balance =={ Balance}, amount =={ amount} ");
                //***check the comment
                Mutex[] mutexlocks = { _mutexLock, fromAcc._mutexLock };
                if (WaitHandle.WaitAll(mutexlocks))
                {
                    //***check the comment
                    try
                    {
                        fromAcc.Withdraw(amount); //從 fromAcc 取出錢來
                        Deposit(amount); //把錢放進 toAcc
                    }
                    finally
                    {
                        foreach (Mutex mutexlockItem in mutexlocks)
                        {
                            //***check the comment
                            mutexlockItem.ReleaseMutex();
                        }
                    }
                }
                Console.WriteLine(
                    $"End of TransferFrom, Thread.CurrentThread.Name=={Thread.CurrentThread.Name}, fromAcc.Id =={ fromAcc.Id} , fromAcc.Balance =={ fromAcc.Balance}, _toAccount.Id == this.Id =={ Id}, _toAccount.Balance == this.Balance =={ Balance}, amount =={ amount} ");
            }
        }
    }
}
