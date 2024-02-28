using ShellLessonStep2.ViewModels;

namespace ShellLessonStep2.Views;

public partial class AnimalDetailsView : ContentPage
{
	public AnimalDetailsView(AnimalDetailsViewModels vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}