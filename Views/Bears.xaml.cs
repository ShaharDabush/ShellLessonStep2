using ShellLessonStep2.ViewModels;

namespace ShellLessonStep2.Views;

public partial class Bears : ContentPage
{
	public Bears(AnimalViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}