using DEINT_MVVM_Demo.MVVM.Models;
using System.Windows.Input;

namespace DEINT_MVVM_Demo.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }
        public ICommand ClickCommand { get; set; }

        public PersonViewModel()
        {
            Person = new Person { 
                Name = "Pepe",
                Age = 15,
                Married = "Yes"
            };

            ClickCommand = new Command(async (s) => 
            {
                //Here goes code referer to the buttons
                //Button btn = s as Button;
                await App.Current.MainPage.DisplayAlert("Title", s.ToString(), "OK");
            });
        }

    }
}
