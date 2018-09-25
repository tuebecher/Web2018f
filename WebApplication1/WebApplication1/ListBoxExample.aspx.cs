using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ListBoxExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(TextBoxInput.Text);
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelSelected.Text = "Selected: " + ListBox1.SelectedItem.Text;

        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Remove(ListBox1.SelectedItem);
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = Calendar1.SelectedDate.ToString();
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string s = "";
            int i = 1;
            while (i<=10)
            {
                s += i + " ";
                i++;
            }
            ListBox2.Items.Add(s);


            s = "";
            i = 100;
            do
            {
                s += i + " ";
                i++;
            } while (i<=110);
            ListBox2.Items.Add(s);

            s = "";
            for (int j = 50; j < 60; j++)
            {
                s += j + " ";
            }
            ListBox2.Items.Add(s);

        }
    }
}