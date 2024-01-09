using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrosPage : ContentPage
    {
        public BrosPage()
        {
            InitializeComponent();
        }
        private void SaveBros(object sender, EventArgs e)
        {
            var bros = (Bros)BindingContext;
            if (!String.IsNullOrEmpty(bros.Nick))
            {
                App.Database.SaveBro(bros);
            }
            this.Navigation.PopAsync();
        }
        private void Del(object sender, EventArgs e)
        {
            var bros = (Bros)BindingContext;
            App.Database.DeleteItem(bros.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}
