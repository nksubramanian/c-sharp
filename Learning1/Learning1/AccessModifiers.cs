using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class AccessModifiers
    {
        public void AccessModifiersmain()
        {
            EmployeeX c = new EmployeeX();
            c.Id = 4;

        }
    }


    public class EmployeeX
    {
        private int _Id;

        public int Id
        {
            get
            {
                return _Id;

            }

            set
            {
                this._Id = Id;
            }
        }

    }


}
