using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.ViewModels;

namespace shop.Views.Main.Account;

public partial class PaymentMethodsPage : ContentPage
{
    public PaymentMethodsPage(PaymentMethodsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}