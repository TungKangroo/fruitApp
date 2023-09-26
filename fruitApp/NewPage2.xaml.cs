namespace fruitApp;

public partial class NewPage2 : ContentPage
{
	public NewPage2(string UserName)
	{
		InitializeComponent();
        lb1UserName.Text = UserName;

	}
}