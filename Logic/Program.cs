using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            PuttingPicturesTohetger p = new PuttingPicturesTohetger();
            p.PuttingTogether();


            using (var context = new Context())
            {
                context.Pictures.ToList();
            }

            //using (var context = new Context())
            //{

            //var test = from t in context.Theme
            //           where t.ID == 1
            //           select t;

            //}
        }
    }
}
