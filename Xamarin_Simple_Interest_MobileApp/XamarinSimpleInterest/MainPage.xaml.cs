using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinSimpleInterest
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }
        public async void Simpleinterest(object sender, EventArgs e)
        { 
            iname.Text = "" + int.Parse(pname.Text) * int.Parse(rname.Text) * int.Parse(tname.Text) / 100;
            yname.Text = "" + (int.Parse(pname.Text) + int.Parse(iname.Text));

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            pname.Text = "0.0";
            tname.Text = "0.0";
            rname.Text = "0.0";
            iname.Text = "";
            yname.Text = "";

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            
        }
    }
}
