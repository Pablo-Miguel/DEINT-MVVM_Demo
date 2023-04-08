using PropertyChanged;

namespace DEINT_MVVM_Demo.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Married { get; set; }

    }
}
