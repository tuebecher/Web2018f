using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BirdInheritance
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bird b1 = new Bird("sparrow", "green");
            Songbird b2 = new Songbird("Nightinggale", "brown", 5);
            ListBox1.Items.Add(b1.ToString());
            ListBox1.Items.Add(b2.ToString());

            Bird b3 = new Songbird("Canarrie", "Yellow", 2);
            ListBox1.Items.Add(b3.SayTweet());
            ListBox1.Items.Add(((Songbird)b3).NumberOfSongs.ToString());

            Owl b4 = new Owl("Snowowl", "White");

            ListBox1.Items.Add(b4.ToString());
            b4.ChangeColor("Green");
            ListBox1.Items.Add(b4.ToString());

        }
    }
}