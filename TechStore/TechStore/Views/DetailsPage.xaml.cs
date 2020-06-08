using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


using TechStore.Models;
using TechStore.ViewModel;
namespace TechStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(Item item)
        {
            InitializeComponent();
            BindingContext = new DetailViewModel() { Item = item };
            
        }


        private async void Back_ButtonClicked(object sender,EventArgs e)
        {
            await Navigation.PopAsync();
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}