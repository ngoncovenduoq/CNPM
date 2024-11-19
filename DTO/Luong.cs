using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Luong
    {
        private string _ma;
        private string _name;
        private string _value;
        public Luong(string _ma,string _name, string _value)
        {
            this._ma = _ma;
            this._name = _name;
            this._value = _value;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public string Ma
        {
            get { return _ma; }
            set { _ma = value; }
        }
    }
}
