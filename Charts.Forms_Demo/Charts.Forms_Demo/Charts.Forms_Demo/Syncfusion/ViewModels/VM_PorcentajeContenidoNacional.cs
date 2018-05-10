using System;
using System.Collections.Generic;
using System.Text;

namespace Charts.Forms_Demo
{
    class VM_PorcentajeContenidoNacional
    {
        public List<Person> Serie1 { get; set; }
        public List<Person> Serie2 { get; set; }
        public VM_PorcentajeContenidoNacional()
        {
            Serie1 = new List<Person>()
            {
                new Person { Name= "2013", Height=100},
                new Person { Name= "2014", Height=100},
                new Person { Name= "2015", Height=100},
                
            };
            Serie2 = new List<Person>()
            {
                new Person { Name= "2013", Height=17},
                new Person { Name= "2014", Height=25},
                new Person { Name= "2015", Height=28},
            };
        }
    }
}
