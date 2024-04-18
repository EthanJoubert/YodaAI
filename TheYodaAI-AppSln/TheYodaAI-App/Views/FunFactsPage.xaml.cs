namespace TheYodaAI_App.Views;
using TheYodaAI_App.Services;
using System.Windows.Input;
using TheYodaAI_App.ViewModels;

public partial class FunFactsPage : ContentPage
{
	FunFactPageViewModel _viewModel;
	public FunFactsPage(FunFactPageViewModel vm)
	{
        _viewModel = vm;
		InitializeComponent();
		BindingContext = _viewModel;
	}
}