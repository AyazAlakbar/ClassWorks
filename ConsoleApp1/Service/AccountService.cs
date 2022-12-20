using ConsoleApp1.Domain;
using ConsoleApp1.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.Service
{
    internal class AccountService : IAccountService
    {
       
        public void Register(string Username, int Password, string email)
        {
            try
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);

                if (match.Success)
                {
                    Console.WriteLine("Register Successed");
                }
                else
                {
                    throw new MyException("email have not @ symbol");
                }

            }
            catch (MyException ex)
            {

                Console.WriteLine(ex.Message) ;
            }
        }
       
    }
}
