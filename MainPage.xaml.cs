using System.Collections.ObjectModel;

namespace Gezi_Uygulamam
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Trip_List.ItemsSource = App.DBTrans.GetTrips();
        }

        private void add_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddingPage());
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            Trip_List.ItemsSource = App.DBTrans.GetTrips();
        }

        private void Trip_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = e.CurrentSelection.FirstOrDefault() as Trip;
            
            Detail.Title = selected.Title;
            Detail.ImgUrl = selected.ImgUrl;
            Detail.Date = selected.Date;
            Navigation.PushAsync(new DetailPage());
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchBar searchBar = (SearchBar)sender;
            Trip_List.ItemsSource = App.DBTrans.GetResults(searchBar.Text);
        }
    }

}
