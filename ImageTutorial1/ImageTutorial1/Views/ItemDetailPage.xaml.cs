using ImageTutorial1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ImageTutorial1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}