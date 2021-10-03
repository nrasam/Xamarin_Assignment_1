using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Assignment_1.ModelClasses;

namespace Xamarin_Assignment_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        //History history;

        public ProductPage(History history)
        {
            InitializeComponent();
            //this.history = history;
            if(history != null)
            {
                nameLbl.Text = history.name;
                quantityLbl.Text = history.quantity.ToString();
                timeLbl.Text = history.purchaseTime.ToString();
                totalLbl.Text = string.Format("Total Amount: ${0:F2}", history.totalPrice);
            }
        }
    }
}