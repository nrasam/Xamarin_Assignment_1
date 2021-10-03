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
    public partial class AddProductPage : ContentPage
    {
        ObservableCollection<Product> products;

        public AddProductPage(ref ObservableCollection<Product> products)
        {
            InitializeComponent();
            this.products = products;
        }

        private void Save_Clicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            double price = Convert.ToDouble(priceEntry.Text);
            int quantity = Convert.ToInt32(quantityEntry.Text);

            if (name.Length > 0)
            {
                if(price > 0)
                {
                    if (quantity > 0)
                    {
                        products.Add(new Product(name, quantity, price));
                        Navigation.PopAsync();
                    }
                }
            }
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}