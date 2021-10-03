using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Assignment_1.ModelClasses;

namespace Xamarin_Assignment_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestockPage : ContentPage
    {
        ObservableCollection<Product> products;

        public RestockPage(ref ObservableCollection<Product> products)
        {
            InitializeComponent();
            this.products = products;
            stockList.ItemsSource = this.products;
            restockBtn.IsEnabled = false;
        }

        private void stockList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            restockBtn.IsEnabled = true;
        }

        private void Restock_Clicked(object sender, EventArgs e)
        {
            Product product = stockList.SelectedItem as Product;
            product.quantity += Convert.ToInt32(quantityEntry.Text);
            //testLbl.Text = product.quantity.ToString();

            quantityEntry.Text = "0";

            stockList.ItemsSource = null;
            stockList.ItemsSource = this.products;
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}