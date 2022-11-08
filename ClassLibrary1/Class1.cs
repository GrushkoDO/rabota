using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void AccountHandler(string message);
    public class Account
    {
        int sum;
        string FIO;
        AccountHandler taken;
        public Account(int sum, string a)
        {
            this.sum = sum;
            FIO = a;

        }
        // Регистрируем делегат
        public void RegisterHandler(AccountHandler del)
        {
            taken += del;
        }
  
        public void Add(int sum)
        {
            this.sum += sum;
            taken?.Invoke($" На счет зачисленно {sum}  баланс {this.sum}");
        }
        public void registr()
        {
            taken?.Invoke($"Аккаунт под именем{FIO} и с балансом {sum} был зареган");
        }

        public void Take(int sum)
        {
            if (this.sum >= sum)
            {
                this.sum -= sum;
                taken?.Invoke($"Со счета списано {sum}  остаток {this.sum}");
            }
            else
                taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
        }
    }
    public delegate void Grob(string message);
    public class bober
    {
        int kassa;
        string ima;
        event Grob robbery;
        public bober(int a, string b)
        {
            kassa = a;
            ima = b;
        }
        public void RegisterHandler(Grob del)
        {
            robbery += del;
        }
        public void Add(int sum)
        {
            kassa += sum;
            robbery.Invoke($" На счет зачисленно {sum}  баланс {kassa}");
        }
        public void registr()
        {
            robbery?.Invoke($"Аккаунт под именем{ima} и с балансом {kassa} был зареган");
        }

        public void Take(int sum)
        {
            if (this.kassa >= sum)
            {
                this.kassa -= sum;
                robbery?.Invoke($"Со счета списано {sum}  баланс {kassa}");
            }
            else
                robbery?.Invoke($"Недостаточно средств. Баланс: {kassa} баланс{kassa}");
        }
    }
}
