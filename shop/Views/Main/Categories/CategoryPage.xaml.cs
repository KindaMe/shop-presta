using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shop.ViewModels;

namespace shop.Views.Main.Categories;

public partial class CategoryPage : ContentPage
{
    public CategoryPage(CategoryViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}