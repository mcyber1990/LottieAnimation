using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LottieAnimation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NextOnclicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewA());
        }
    }
}
