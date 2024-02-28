using ShellLessonStep2.ViewModels;

namespace ShellLessonStep2.Views;

public partial class Dogs : ContentPage
{
	public Dogs(AnimalViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}