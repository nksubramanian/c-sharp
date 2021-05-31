using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Structure
    {

        public void structuremain()
        {
            Customer c1 = new Customer(3, "subbu");
            c1.PrintName();
            Customer c2 = new Customer();
            c2.PrintName();
        }
    }

    public struct Customer
    {
        private int _id;
        private string _name;


        public Customer(int Id, string Name)
        {
            this._id = Id;
            this._name = Name;
        }

        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }


        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public void PrintName()
        {
            Console.WriteLine("{0},{1}", this._id, this._name);
            
        }



    }





























}
