using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.ViewModels;

namespace shop.Views.Login;

public partial class ResetPasswordPage : ContentPage
{
    public ResetPasswordPage(ResetPasswordViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}