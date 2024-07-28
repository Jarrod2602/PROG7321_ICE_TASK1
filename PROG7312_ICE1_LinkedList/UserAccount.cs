using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_ICE1_LinkedList
{
    public class UserAccount
    {
        /*Having an index class allows easier indexing of data.
        If there is tons of data and you need to find something specific, such as a users account balance,
        instead of needing to know exactly which index their balance is located, you can search it using the assinged value such as "balance" 
        when searching through the object
        */
        private double balance;
        private string accNumber, accType, name, surname;

        public UserAccount(double balance, string accNumber, string accType, string name, string surname)
        {
            this.balance = balance;
            this.accNumber = accNumber;
            this.accType = accType;
            this.name = name;
            this.surname = surname;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.accNumber;
                else if (index == 1)
                    return this.accType;
                else if (index == 2)
                    return this.name;
                else if (index == 3)
                    return this.surname;
                else if (index == 4)
                    return this.balance;
                return null;
            }
            set
            {
                if (index == 0)
                    this.accNumber = (string)value;
                else if (index == 1)
                    this.accType = (string)value;
                else if (index == 2)
                    this.name = (string)value;
                else if (index == 3)
                    this.surname = (string)value;
                else if (index == 4)
                    this.balance = (double)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("accnumber"))
                    return this.accNumber;
                else if (attrName.ToLower().Equals("acctype"))
                    return this.accType;
                else if (attrName.ToLower().Equals("name"))
                    return this.name;
                else if (attrName.ToLower().Equals("surname"))
                    return this.surname;
                else if (attrName.ToLower().Equals("balance"))
                    return this.balance;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("accnumber"))
                    this.accNumber = (string)value;
                else if (attrName.ToLower().Equals("acctype"))
                    this.accType = (string)value;
                else if (attrName.ToLower().Equals("name"))
                    this.name = (string)value;
                else if (attrName.ToLower().Equals("surname"))
                    this.surname = (string)value;
                else if (attrName.ToLower().Equals("balance"))
                    this.balance = (double)value;


            }
        }
    }
}
