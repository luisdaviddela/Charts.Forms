using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace Charts.Forms_Demo
{
    class VM_Deudas
    {
        private Color colorbar = Color.FromHex("#2eb8c1");

        public Color ColorBar
        {
            get { return colorbar; }
            set { colorbar = value; }
        }
        private Color backColor = Color.FromHex("#323c3d");

        public Color BackColor
        {
            get { return backColor; }
            set { backColor = value; }
        }
        public List<Person> Serie1 { get; set; }
        public VM_Deudas()
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
