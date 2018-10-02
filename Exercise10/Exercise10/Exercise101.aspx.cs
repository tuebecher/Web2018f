using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise10
{
    public partial class Exercise101 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

         

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] myInts = new int[5];
            myInts[0] = Int32.Parse(TextBox1.Text);
            myInts[1] = Int32.Parse(TextBox2.Text);
            myInts[2] = Int32.Parse(TextBox3.Text);
            myInts[3] = Int32.Parse(TextBox4.Text);
            myInts[4] = Int32.Parse(TextBox5.Text);

            Array.Sort(myInts);

            string s = "";
            foreach (int i in myInts)
            {
                s = s + i + " ";
            }
            ListBox1.Items.Add(s);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Dog[] dogs = new Dog[3];
            dogs[0] = new Dog("Milo", 26);
            dogs[1] = new Dog("Frisky", 10);
            dogs[2] = new Dog("Laika", 50);

            foreach (Dog d in dogs)
            {
                string doginfo = d.Name + " " + d.Weight + " kg";
                ListBox1.Items.Add(doginfo);
            }
        }
    }
}