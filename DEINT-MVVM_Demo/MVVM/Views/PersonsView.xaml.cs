using DEINT_MVVM_Demo.MVVM.ViewModels;

namespace DEINT_MVVM_Demo.MVVM.Views;

public partial class PersonsView : ContentPage
{
	public PersonsView()
	{
		InitializeComponent();

		BindingContext = new PersonsViewModel();

	}
}