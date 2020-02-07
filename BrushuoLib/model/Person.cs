using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushuoLib.model
{
    public class Person
    {

        // instans felter
        protected String _name;
        protected int _age;
        protected bool _sex;

        //properties
        public String Name
        {
            get { return _name; }
            set
            {
                if (value == null || value.Length < 5)
                {
                    // error
                    throw new ArgumentException("Name skal være mindst 5 tegn langt");
                }
                _name = value;
            }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }


        }

        public bool Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        // constructor
        public Person():this("",0,true)
        {

        }

        public Person(string name, int age, bool sex)
        {
            Name = name;
            _age = age;
            _sex = sex;
        }

        // tostring
        public override string ToString()
        {
            return $"Name={_name} Age={_age} Mand={_sex}";
        }
    }
}
