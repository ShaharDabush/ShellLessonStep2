using ShellLessonStep2.ViewModels;

namespace ShellLessonStep2.Views;

public partial class Elephants : ContentPage
{
	public Elephants(AnimalViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}