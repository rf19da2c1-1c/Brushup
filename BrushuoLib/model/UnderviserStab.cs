using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushuoLib.model
{
    public class UnderviserStab
    {
        private List<Underviser> _stab;

        public UnderviserStab()
        {
            _stab = new List<Underviser>();
            PopulateStab(_stab);
        }


        public List<Underviser> GetTeacherByCourse(string course)
        {
            List<Underviser> liste = new List<Underviser>();

            foreach (Underviser uv in _stab)
            {
                foreach (string c in uv.TeachingCourses)
                {
                    if (c == course)
                    {
                        liste.Add(uv);
                    }
                }
            }
            return liste;
        }



        public override string ToString()
        {
            return String.Join("\r\n", _stab) ;
        }

        /*
         * Stub for adding information into stab
         */
        private void PopulateStab(List<Underviser> stab)
        {
            int CoursesNo = _courses.Count;

            for (int i = 0; i < 13; i++)
            {
                Underviser uv = new Underviser("lærer"+i, 40+i, i%3==0);
                uv.TeachingCourses.Add(_courses[_rnd.Next(CoursesNo)]);
                uv.TeachingCourses.Add(_courses[_rnd.Next(CoursesNo)]);
                uv.TeachingCourses.Add(_courses[_rnd.Next(CoursesNo)]);

                stab.Add(uv);
            }

        }
        /*
         * Just for help
         */
        private List<string> _courses = new List<string>()
        {
            "SWC1", "SWC2","SWD1", "SWD2","PROG", "TECH", "SYM", "ELEC", "DISSERTATION"
        };

        private Random _rnd = new Random(DateTime.Now.Millisecond);
    }
}
