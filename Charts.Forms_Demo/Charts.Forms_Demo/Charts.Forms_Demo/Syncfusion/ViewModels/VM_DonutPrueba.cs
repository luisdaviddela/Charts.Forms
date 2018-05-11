using System;
using System.Collections.Generic;
using System.Text;

namespace Charts.Forms_Demo
{
    class VM_DonutPrueba
    {
        public List<Person> Serie1 { get; set; }
        public VM_DonutPrueba()
        {
            Serie1 = new List<Person>()
            {
                new Person { Name= "Geomaterials", Height=310},
                new Person { Name= "Exploración del pacifico", Height=125},
                new Person { Name= "Servicios integrales BDH", Height=98},
                new Person { Name= "Oil Services", Height=95},
                new Person { Name= "Corporativos de servicios Alpha", Height=75},
            };
        }
    }
}
