using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.ViewModels;

namespace shop.Views.Main.Account;

public partial class AddressPage : ContentPage
{
    public AddressPage(AddressViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}