using ShellLessonStep2.ViewModels;

namespace ShellLessonStep2.Views;

public partial class Cats : ContentPage
{
	public Cats(AnimalViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}