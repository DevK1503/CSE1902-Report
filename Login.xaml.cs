using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading;
using SQLite;



namespace MyFirstApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();


        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            string a = txtUsename.Text;
            string b = txtid.Text;
            string c = txtadd.Text;
            string d = txtphone.Text;

            //App.DB

            await Navigation.PushAsync(new Display(a, b, d, c));


        }
        
        



}
    public class Trial
    {
        static void Main()
        {
            List<string> list1 = new List<string>
        {
            "india" ,
            "UK",
            "Usa",
            "canada",

            

        };
            list1.Add("Japan");
            for (int i = 0; i < list1.Count; i++)
            {
                var element = list1[i];
                Console.WriteLine(element);
                list1.Insert(2, "singapore");
            }

            List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};

            Console.Write("The list : ");
            foreach (var value in numbers)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            var square = numbers.Select(x => x * x);

            Console.Write("Squares : ");
            foreach (var value in square)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);

            Console.Write("Numbers Divisible by 3 : ");
            foreach (var value in divBy3)
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();
        }
        
        
        

    }
}