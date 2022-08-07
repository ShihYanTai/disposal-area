using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 學生
{
    internal class User
    {
        private string Username;
        private string Password;

        private int count1, count5, count10 ;
        public int Money
        {
            get { return  count1 + count5 + count10 * 10; }
        }

        private int hp;
        public int HP
        {
            get { return hp; } // 在讀取 HP 會自動呼叫
            set {               // 再存入數值時自動呼叫
                if (value < 0)
                {
                    hp = 0;
                }
                else
                {
                    hp = value;
                }
            }
        }


        public void hurt(int decreaseHP)
        {
            if (hp >= decreaseHP)
            {
                hp -= decreaseHP;
            }
            else { hp = 0; }

        }

        public int getHP()
        {
            return hp;
        }

        // 利用Constructor(建構子) 來設定 Username, Password 的初始值
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
            this.hp = 20;
            this.count1 = 1;
            this.count5 = 1;
            this.count10 = 1;
        }

        public bool comparePassward(string targetPass)
        {
            if (this.Password == targetPass)
            {
                return true;
            }

            else { return false; }
        }



        public string getUsername()
        {
            return Username;
        }

        private void reset()
        {
            Password = "";
        }
    }
}
