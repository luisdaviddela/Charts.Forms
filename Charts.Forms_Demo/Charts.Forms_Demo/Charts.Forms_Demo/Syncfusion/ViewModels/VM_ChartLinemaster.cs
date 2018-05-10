using System;
using System.Collections.Generic;
using System.Text;

namespace Charts.Forms_Demo
{
    public class VM_ChartLinemaster
    {
        public List<Person> Serie1 { get; set; }
        public List<Person> Serie2 { get; set; }
        public VM_ChartLinemaster()
        {
            Serie1 = new List<Person>()
            {
                 new Person { Name ="	01-ene-16	",Height=   1615.532 },
                 new Person { Name ="	02-feb-16	",Height=   2971.064 },
                 new Person { Name ="	03-mar-16	",Height=   2974.564 },
                 new Person { Name ="	04-abr-16	",Height=   4547.396 },
                 new Person { Name ="	05-may-16	",Height=   6138.428 },
                 new Person { Name ="	06-jun-16	",Height=   7698.260 },
                 new Person { Name ="	07-jul-16	",Height=   8578.092 },
                 new Person { Name ="	08-ago-16	",Height=   9957.924 },
                 new Person { Name ="	09-sep-16	",Height=   10975.090 },
                 new Person { Name ="	10-oct-16	",Height=   12104.922 },
                 new Person { Name ="	11-nov-16	",Height=   13104.754 },
                 new Person { Name ="	12-dic-16	",Height=   14104.586 },
                 new Person { Name ="	01-ene-17	",Height=   14140.586 }
            };

            Serie2 = new List<Person>()
            {
                 new Person { Name ="	01-ene-16	",Height=   11.168   },
                 new Person { Name ="	02-feb-16	",Height=   11.168   },
                 new Person { Name ="	03-mar-16	",Height=   11.185   },
                 new Person { Name ="	04-abr-16	",Height=   11.201   },
                 new Person { Name ="	05-may-16	",Height=   11.312   },
                 new Person { Name ="	06-jun-16	",Height=   11.312   },
                 new Person { Name ="	07-jul-16	",Height=   11.312   },
                 new Person { Name ="	08-ago-16	",Height=   11.312   },
                 new Person { Name ="	09-sep-16	",Height=   18.739   },
                 new Person { Name ="	10-oct-16	",Height=   18.739   },
                 new Person { Name ="	11-nov-16	",Height=   18.739   },
                 new Person { Name ="	12-dic-16	",Height=   23.228   },
                 new Person { Name ="	01-ene-17	",Height=   23.239   }

            };
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public double Height { get; set; }
    }
    public class Car
    {
        public string Name { get; set; }
        public double Height { get; set; }
    }
}
