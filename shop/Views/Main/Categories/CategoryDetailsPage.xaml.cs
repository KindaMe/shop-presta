using shop.ViewModels;

namespace shop.Views.Main.Categories;

public partial class CategoryDetailsPage : ContentPage
{
    public CategoryDetailsPage(CategoryDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}