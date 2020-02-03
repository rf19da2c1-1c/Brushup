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



        }
    }
}
