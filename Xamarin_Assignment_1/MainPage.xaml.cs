using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_Assignment_1.ModelClasses;

namespace Xamarin_Assignment_1
{
    public partial class MainPage : ContentPage
    {
        public int total;
        public String type, quantity;

        ObservableCollection<Product> products = new ObservableCollection<Product> {
                new Product("Pants", 20, 10),
                new Product("Shoes", 50, 10),
                new Product("Hats", 10, 10),
                new Product("Tshirts", 10, 10),
                new Product("Dresses", 24, 10)
            };
        ObservableCollection<History> histories = new ObservableCollection<History> { };
        public MainPage()
        {
            InitializeComponent();
            
            list.ItemsSource = products;
        }

        protected override void OnAppearing()
        {
            list.ItemsSource = null;
            list.ItemsSource = products;
        }

        private void Buy_Clicked(object sender, EventArgs e)
        {
            Product product = list.SelectedItem as Product;
            if (Convert.ToInt32(lblQuantity.Text) <= product.quantity)
            {
                product.quantity -= Convert.ToInt32(lblQuantity.Text);
                list.ItemsSource = null;
                list.ItemsSource = products;

                string name = product.type;
                int quantity = Convert.ToInt32(lblQuantity.Text);
                double totalPrice = quantity * product.price;
                DateTime purchaseTime = DateTime.Now;

                histories.Add(new History(name, quantity, totalPrice, purchaseTime));

                if(product.quantity <= 0)
                {
                    //list.SelectedIte
                }
            }
            else {
                DisplayAlert("Error", "Quantity surpasses stock.", "Try again");
            }

            lblQuantity.Text = "0";
            lblTotal.Text = "Total";

            //DisplayAlert("test", "message: " + Convert.ToString((list.SelectedItem as Product).quantity), "Ok");
        }

        private void list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            lblType.Text = (e.SelectedItem as Product).type;
            lblQuantity.Text = "0";
            btn0.IsEnabled = true;
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            btn9.IsEnabled = true;
            btnBuy.IsEnabled = true;
            // Error: lblType.Text = (e.SelectedItem).type; // Need to cast
        }

        private void btnManager_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ManagerPanelPage(products, histories));
        }

        private void Number_Clicked(object sender, EventArgs e)
        {
            //DisplayAlert("title", "message", "Ok");
            if(lblQuantity.Text[0] == '0')
            {
                lblQuantity.Text = (sender as Button).Text;
            }
            else
            {
                lblQuantity.Text += (sender as Button).Text;
            }

            lblTotal.Text = string.Format("${0:F2}", Convert.ToInt32(lblQuantity.Text) * (list.SelectedItem as Product).price);

            //lblQuantity.Text += sender.ToString(); // Results in Xamarin.Forms.Button
        }
    }
}
