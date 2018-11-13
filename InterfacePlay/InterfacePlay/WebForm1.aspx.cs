using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterfacePlay
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Person[] people = new Person[5];
            people[0] = new Person("Niels", 67, 176);
            people[1] = new Person("Thor", 11, 152);
            people[2] = new Person("Lene", 42, 166);
            people[3] = new Person("Bastian", 15, 171);
            people[4] = new Person("Kim", 35, 186);

            foreach (Person p in people)
            {
                ListBox1.Items.Add(p.ToString());
            }

            ListBox1.Items.Add("Lets call bubblesort...");
            Util.BubbleSort(people);

            foreach (Person p in people)
            {
                ListBox1.Items.Add(p.ToString());
            }


        }
    }
}