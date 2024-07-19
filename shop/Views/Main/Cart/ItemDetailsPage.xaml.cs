using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.ViewModels;

namespace shop.Views.Main.Cart;

public partial class ItemDetailsPage : ContentPage
{
    public ItemDetailsPage(ItemDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}