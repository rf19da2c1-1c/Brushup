using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BrushuoLib.model
{
    public class Underviser
    {
        // instans felter
        private String _name;
        private int _age;
        private bool _sex;
        private List<String> _teachingCourses;

        // prooerties
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }


        }

        public bool Sex
        {
            get { return _sex; }
            set { _sex = value;}
        }

        public List<String> TeachingCourses
        {
            get { return _teachingCourses; }
            private set { _teachingCourses = value; }
        }

        // constructor
        public Underviser()
        {
            _name = "dummy";
            _age = 0;
            _sex = true;
            _teachingCourses = new List<string>();
        }

        public Underviser(string name, int age, bool sex)
        {
            _name = name;
            _age = age;
            _sex = sex;
            _teachingCourses = new List<string>();
        }


        // tostring

        public override string ToString()
        {
            String fagStr = String.Join(", ", _teachingCourses);

            String fagStr2 = "";
            foreach (string fag in _teachingCourses)
            {
                fagStr2 = fagStr2 + ", " + fag;
            }

            return $"Navn:{_name}, Alder:{_age}, Mand:{_sex}, Underviser i: [{fagStr2}]";
        }
    }
}
