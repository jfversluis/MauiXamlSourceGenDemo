using MauiXamlSourceGenDemo.Models;
using MauiXamlSourceGenDemo.PageModels;

namespace MauiXamlSourceGenDemo.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}