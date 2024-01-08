namespace Gezi_Uygulamam;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
		
		Img.Source = Detail.ImgUrl;
		Title.Text = Detail.Title;
		Date.Text = Detail.Date.ToString();

	}
}