using DEINT_MVVM_Demo.MVVM.Models;

namespace DEINT_MVVM_Demo.MVVM.ViewModels
{
    public class PersonsViewModel
    {
        public List<Person> Persons { get; set; }

        public PersonsViewModel()
        {
            Persons = new List<Person>() { 
                new Person()
                {
                    Name = "Manuel Jesus",
                    Age = 3,
                    Married="Yes"
                },
                new Person()
                {
                    Name = "Carlos",
                    Age = 0,
                    Married="Yes"
                },
                new Person()
                {
                    Name = "Marta",
                    Age = 19,
                    Married="No"
                }
            };
        }

    }
}
