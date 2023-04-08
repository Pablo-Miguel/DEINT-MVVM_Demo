using DEINT_MVVM_Demo.MVVM.Views;

namespace DEINT_MVVM_Demo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new PersonView();
	}
}
