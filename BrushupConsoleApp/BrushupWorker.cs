using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrushuoLib.model;

namespace BrushupConsoleApp
{
    class BrushupWorker
    {
        public void Start()
        {
            Underviser uv = new Underviser("Peter", 61, true);
            uv.TeachingCourses.Add("SWC1");
            uv.TeachingCourses.Add("SWC2");

            Console.WriteLine(uv);

            try
            {
                uv.Name = "ib";
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Fejl: " + ae.Message);
            }

            try
            {
                Underviser uv2 = new Underviser("Kurt", 61, true);
                uv2.TeachingCourses.Add("SWC1");
                uv2.TeachingCourses.Add("SWC2");
                Console.WriteLine(uv2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            UnderviserStab stab = new UnderviserStab();
            Console.WriteLine(stab);

            Console.WriteLine("Underviser i faget SWC2");

            List<Underviser> underviserifaget =  stab.GetTeacherByCourse("SWC2");

            Console.WriteLine(string.Join("\n", underviserifaget));

        }
    }
}
