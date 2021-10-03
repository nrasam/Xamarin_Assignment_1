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
    public partial class ManagerPanelPage : ContentPage
    {
        ObservableCollection<Product> products;
        ObservableCollection<History> histories;

        public ManagerPanelPage(ObservableCollection<Product> products, ObservableCollection<History> histories)
        {
            InitializeComponent();  // DO THIS FIRST
            this.products = products;
            this.histories = histories;
            BindingContext = this;
        }

        private void History_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HistoryItems(ref histories));
        }

        private void Restock_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RestockPage(ref products));
        }

        private void Add_New_Product_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddProductPage(ref products));
        }
    }
}