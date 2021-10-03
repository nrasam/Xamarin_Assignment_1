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
    public partial class HistoryItems : ContentPage
    {
        ObservableCollection<History> histories;
        public HistoryItems(ref ObservableCollection<History> histories)
        {
            InitializeComponent();
            this.histories = histories;
            historyList.ItemsSource = this.histories;
        }

        private void list_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            History history = historyList.SelectedItem as History;
            Navigation.PushAsync(new ProductPage(history));
        }
    }
}