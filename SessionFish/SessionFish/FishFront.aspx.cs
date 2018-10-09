using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionFish
{
    public partial class FishFront : System.Web.UI.Page
    {
        private Fishtank thetank;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["SharedFishTank"] == null)
            {
                Application["SharedFishTank"] = new Fishtank();
            }

            thetank = (Fishtank)Application["SharedFishTank"];
            UpdateFishListView();
        }

        protected void ButtonUpdateTank_Click(object sender, EventArgs e)
        {
            thetank = (Fishtank)Application["SharedFishTank"];
            UpdateFishListView();
        }

        private void UpdateFishListView()
        {
            ListBoxTank.Items.Clear();

            List<Fish> fishInTheTank = thetank.WhatIsInside();
            foreach (Fish f in fishInTheTank)
            {
                ListBoxTank.Items.Add(f.ToString());
            }
        }
        protected void ButtonAddFish_Click(object sender, EventArgs e)
        {
            Fish f = new Fish(
                TextBoxFishType.Text,
                int.Parse(TextBoxFishLength.Text),
                int.Parse(TextBoxFishWeight.Text));

            Application.Lock();
            thetank = (Fishtank)Application["SharedFishTank"];
            thetank.AddFish(f);
            Application["SharedFishTank"] = thetank;
            Application.UnLock();

            UpdateFishListView();
        }
    }
}