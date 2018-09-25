using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ArrayPlay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string[] myArray = new string[3];
            myArray[0] = "Cat";
            myArray[1] = "Dog";
            myArray[2] = "Horse";

            AddToListBox(myArray);

            myArray[1] = "Hammy";

            AddToListBox(myArray);

            AddToListBox("Peter", "Poul", "Jan", "Niels");
        }

        public void AddToListBox(params string[] stringArray)
        {
            foreach (string str in stringArray)
            {
                ListBox1.Items.Add(str);
            }
        }


        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}