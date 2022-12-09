using pract13;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace pract13
{
    class Password
    {
        
        string[,] usersNameAndPass = new string[10, 2];
        public string Pass { get; set; }
        public string Login { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public Password()
        {

        }
        
        public void Add(string login, string password)
        {
            for (int i = Row; i < usersNameAndPass.GetLength(0); i++)
            {
                for (int j = Column; j < usersNameAndPass.GetLength(1); j++)
                {
                    while (usersNameAndPass[i, j] == null)
                    {

                        usersNameAndPass[i, j] = login;
                        usersNameAndPass[i, j + 1] = password;

                    }
                    Column = j;
                    break;
                }
                Row = i+1;
                break;
            }
        }
        public bool CheckPassword(string login, string password)
        {
            
            for (int i = 0; i < usersNameAndPass.GetLength(0); i++)
            {
                for ( int j = 0; j < usersNameAndPass.GetLength(1); j++)
                {
                    if (login == usersNameAndPass[i, j] && password == usersNameAndPass[i, j + 1]) return true;
                }
            }
            return false;
            
           
        }
    }
}
