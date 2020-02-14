using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BrushuoLib.model
{
    public class Underviser:Person
    {
        // instans felter
        
        private List<String> _teachingCourses;

        // properties
        

        public List<String> TeachingCourses
        {
            get { return _teachingCourses; }
            private set { _teachingCourses = value; }
        }

        // constructor
        public Underviser():this ("dummy",0,true)
        {
        }

        public Underviser(string name, int age, bool sex):base(name,age,sex)
        {
            _teachingCourses = new List<string>();
        }


        // tostring

        public override string ToString()
        {
            //version 1
            String fagStr = String.Join(", ", _teachingCourses);

            // version 2
            String fagStr2 = "";
            foreach (string fag in _teachingCourses)
            {
                fagStr2 = fagStr2 + ", " + fag;
            }

            return base.ToString() + $", Underviser i: [{fagStr}]";
        }
    }
}
