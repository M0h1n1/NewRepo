using PropertyApp.Model;
using PropertyApp.ViewModel;

namespace PropertyApp.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage()
	{
		InitializeComponent();
	}

    public DetailsPage(Property selectedProperty)
    {
        InitializeComponent();
        var viewModel = new DetailsViewModel() { SelectedProperty = selectedProperty };

        viewModel.PropertyImages = selectedProperty.Images.Take(count: 2).ToList();
        viewModel.MoreItems = selectedProperty.Images.Count - 2;

        this.BindingContext = viewModel;

        SetViewPositions();
        Loaded += (s, e) =>
        {

            FadeAndScale(detailsBtn);
            RotateView(detailsBtn);
            FadeAndTranslate(imagesView);

            Task.Delay(millisecondsDelay: 500);

            FadeAndTranslate(popView, fadeLength:1000, translateLength:1000);
            FadeAndTranslate(addressView, fadeLength:1000, translateLength:1000);
            FadeAndScale(buyBtn, fadeLength:1000, scaleLength: 1000);
        };
    }

    private void SetViewPositions()
    {
        detailsBtn.Opacity = 0;
        detailsBtn.Scale = 0.2;
        detailsBtn.Rotation = 300;

        imagesView.TranslationX = 300;
        imagesView.Opacity = 0;

        addressView.TranslationX = addressView.TranslationY = -30;

        buyBtn.Opacity = 0;
        buyBtn.Scale = 0.2;

        popView.TranslationY = 300;
        popView.Scale = 0.5;
    }
    private void FadeAndTranslate(VisualElement view, uint fadeLength = 1000, uint translateLength = 1500)
    {
        view.FadeTo(opacity: 1, fadeLength, Easing.SinInOut);
        view.TranslateTo(x: 0, y:0, translateLength, Easing.SinInOut);
    }
    private void FadeAndScale(VisualElement view, uint fadeLength = 1000, uint scaleLength = 1500)
    {
        view.FadeTo(opacity: 1, fadeLength, Easing.SinInOut);
        view.ScaleTo(scale: 1, scaleLength, Easing.SinInOut);
    }


    private void RotateView(VisualElement view) => view.RotateTo(rotation: 0, length:1500, Easing.SinInOut);

}