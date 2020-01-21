using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RadioButtonDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {

        static string radioButtonType = "";
        public MainPage()
        {
            InitializeComponent();
        }


         void OnNewRegClicked(object sender, EventArgs e)
        {
            if(radioButtonType=="")
            {
                DisplayAlert("Alert", "Please select Radio Button", "OK");
            }
            else
                 if (radioButtonType == "abc")
            {
                DisplayAlert("Alert", "ABC is checked", "OK");
            }
            else
                 if (radioButtonType == "xyz")
            {
                DisplayAlert("Alert", "XYZ is cheched", "OK");
            }
            

              
        }

        void SMGClicked(object sender, EventArgs e)
        {

            SMGRbtn.BackgroundColor = Color.FromHex("#ff0000");
            SMGRbtn.BorderColor = Color.FromHex("#ff0000");
            VendorRbtn.BorderColor = Color.FromHex("#000000");
            VendorRbtn.BackgroundColor = Color.FromHex("#ffffff");
            radioButtonType = "abc";

        }

        void VendorClicked(object sender, EventArgs e)
        {
            SMGRbtn.BackgroundColor = Color.FromHex("#ffffff");
            VendorRbtn.BorderColor = Color.FromHex("#ff0000");
            SMGRbtn.BorderColor = Color.FromHex("#000000");
            VendorRbtn.BackgroundColor = Color.FromHex("#ff0000");
            radioButtonType = "xyz";
        }
    }
}
