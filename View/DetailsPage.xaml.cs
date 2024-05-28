using PropertyApp.Model;

namespace PropertyApp.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage()
	{
		InitializeComponent();
	}

    public DetailsPage(Property selectedProperty)
    {
        SelectedProperty = selectedProperty;
    }

    public Property SelectedProperty { get; }
}