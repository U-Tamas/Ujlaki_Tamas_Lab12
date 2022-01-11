using System.ComponentModel;
using Ujlaki_Tamas_Lab12.ViewModels;
using Xamarin.Forms;

namespace Ujlaki_Tamas_Lab12.Views
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