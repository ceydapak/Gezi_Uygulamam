
using System.Collections.Immutable;

namespace Gezi_Uygulamam;

public partial class AddingPage : ContentPage
{
    public string AddingImgUrl;
	public AddingPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var trip = new Trip();
        trip.Title = Title.Text;
        trip.ImgUrl = AddingImgUrl;
        trip.Date = DateTime.Now;
        App.DBTrans.InsertTrip(trip);
        Navigation.PushAsync(new MainPage());

    }
    

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        FileResult result = await MediaPicker.Default.PickPhotoAsync();

        if (result != null)
        {
            string path = Path.GetFullPath(result.FullPath);
            AddingImgUrl = path; 

        }

    }
}