using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App5;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            friendsList.ItemsSource = App.Database.GetItems();
            brosList.ItemsSource = App.Database.GetBros();
            base.OnAppearing();
        }

       

        private async void BroSel(object sender, SelectedItemChangedEventArgs e)
        {
            Bros selectedBros = (Bros)e.SelectedItem;
            BrosPage brosPage = new BrosPage();
            brosPage.BindingContext = selectedBros;
            await Navigation.PushAsync(brosPage);
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Friend selectedFriend = (Friend)e.SelectedItem;
            FriendPage friendPage = new FriendPage();
            friendPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(friendPage);
        }

        private async void Sel(object sender, SelectedItemChangedEventArgs e)
        {
            Bros selectedFriend = (Bros)e.SelectedItem;
            BrosPage brosPage = new BrosPage();
            brosPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(brosPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateFriend(object sender, EventArgs e)
        {
            Friend friend = new Friend();
            FriendPage friendPage = new FriendPage();
            friendPage.BindingContext = friend;
            await Navigation.PushAsync(friendPage);
        }

        private async void CreateBro(object sender, EventArgs e)
        {
            Bros bros = new Bros();
            BrosPage brosPage = new BrosPage();
            brosPage.BindingContext = bros;
            await Navigation.PushAsync(brosPage);
        }
       
    }
}