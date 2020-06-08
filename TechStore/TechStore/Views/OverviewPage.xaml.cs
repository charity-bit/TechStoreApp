using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TechStore.Views;
using TechStore.ViewModel;
using TechStore.Models;

namespace TechStore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OverviewPage : ContentPage
    {
        const uint AnimationSpeed = 500;
        public OverviewPage()
        {
            InitializeComponent();
            DisplayItems.ItemsSource = OverViewViewModel.GetItems;

        }

       

        private void Button_Clicked(object sender, EventArgs e)
        {
            entry.TranslateTo(0, 0, AnimationSpeed, Easing.SinInOut);
            Cancel.TranslateTo(0, 0, AnimationSpeed, Easing.SinInOut);
           

        }


        private async void DisplayItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Any())
            {
                // Reset selection
                DisplayItems.SelectedItem = null;

                // Get the item we're opening.
                var selectedItem = e.CurrentSelection.FirstOrDefault() as Item;

               await Navigation.PushAsync(new DetailsPage(selectedItem));
              }
            }

        private void entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            DisplayItems.ItemsSource = OverViewViewModel.GetSearchResults(e.NewTextValue);
        }

        private void Cancel_Clicked(object sender, EventArgs e)
        {
            entry.Text = "";
        }

        
    }
    }
