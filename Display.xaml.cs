using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class Display : ContentPage
    {
        public Display(string name, string id, string phone, string address)
        {
            InitializeComponent();


            nam.Text = "NAME: " + name;
            idd.Text = "ID: "+id;
            pho.Text = "PHONE: "+phone;
            add.Text = "ADDRESS: "+address;

        }
    }
}