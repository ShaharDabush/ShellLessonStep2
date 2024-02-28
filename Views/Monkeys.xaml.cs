using ShellLessonStep2.ViewModels;

namespace ShellLessonStep2.Views;

public partial class Monkeys : ContentPage
{
	public Monkeys(AnimalViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}