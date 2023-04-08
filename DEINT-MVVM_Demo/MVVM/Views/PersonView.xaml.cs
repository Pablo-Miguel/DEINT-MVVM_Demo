using DEINT_MVVM_Demo.MVVM.ViewModels;

namespace DEINT_MVVM_Demo.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();

		BindingContext = new PersonViewModel();

	}
}