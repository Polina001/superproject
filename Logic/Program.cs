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
            

            using (var context = new Context())
            {
                CreatingListOfImages cli = new CreatingListOfImages();

                var testID = from t in context.Theme
                             select t.ID;

                foreach (var item in testID)
                {
                    Console.WriteLine(item);
                }

                var id = 5;
                var testlist = cli.ConvertingToListOfImages(id);

                if (testlist.Count == 0 )
                    Console.WriteLine("empty list");

                PuttingPicturesTohetger p = new PuttingPicturesTohetger();
                p.PuttingTogether(testlist[0], testlist[1]);

                Console.WriteLine("done");
                Console.ReadLine();

                context.Pictures.ToList();
                                       
            }
        }
    }
}
