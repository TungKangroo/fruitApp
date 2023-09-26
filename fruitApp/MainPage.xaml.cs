using System.Collections.Generic;

namespace fruitApp
{
    public partial class MainPage : ContentPage
    {
        List<string> list = new List<string>() { "Apple", "Banana", "Orange", "Guava", "Peach", "Melon" };


        public MainPage()
        {
            InitializeComponent();
            fruitListView.ItemsSource = list;
        }

        private void fruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           if(e.SelectedItem == null) {
                return;
                DisplayAlert("Selected",e.SelectedItem.ToString(),"OK");
                ((ListView)sender).SelectedItem = null;
            
            
            }
        }
    }
}