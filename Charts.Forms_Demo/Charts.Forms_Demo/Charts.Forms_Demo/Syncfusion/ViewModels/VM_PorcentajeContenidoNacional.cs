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
                new Person { Name= "Luis", Height=10},
                new Person { Name= "Reyna", Height=8}
            };


            Serie2 = new List<Person>()
            {
                new Person { Name= "Luis", Height=8},
                new Person { Name= "Reyna", Height=7}
            };
        }
    }
}
