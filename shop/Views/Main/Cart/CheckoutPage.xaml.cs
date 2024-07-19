using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.ViewModels;

namespace shop.Views.Main.Cart;

public partial class CheckoutPage : ContentPage
{
    public CheckoutPage(CheckoutViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}