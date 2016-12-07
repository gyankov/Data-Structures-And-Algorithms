using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorfulBunnies
{
    class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<long>();
            long total = 0;

            for (int i = 0; i < n; i++)
            {
                list.Add(long.Parse(Console.ReadLine()));
            }

            var grouped = list.GroupBy(x => x);

            foreach (var group in grouped)
            {
                var temp = group.ToArray();

                if (group.Count() == 1)
                {
                    total += temp[0] + 1;
                }
                else if (group.Count()%(temp[0]+1)==0)
                {
                    total += group.Count();
                }
                else
                {
                    var target = temp[0] + 1;
                    var subList = new List<long>();
                    for (int i = 0; i < temp.Length; i++)
                    {
                        if (subList.Count == target)
                        {
                            total += target;
                            subList.Clear();
                            subList.Add(temp[i]);
                        }
                        else
                        {
                            subList.Add(temp[i]);
                        }
                    }

                    if (subList.Count>0)
                    {
                        total += target;
                    }
                }               
                
            }
            Console.WriteLine(total);
        }
    }
}
