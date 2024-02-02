namespace ShazamMaui
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {

        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new NewPage1());

            await Shell.Current.GoToAsync("newlibrary");

        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("newchat");
            // await Navigation.PushAsync(new Charts());
        }


 /*       private  Task ImageButton_Clicked_2()
        {
            //object sender, EventArgs e
           while (true)
            {
                await TapToShazamName.RotateTo(360, 2000); // Rotate 360 degrees in 2 seconds
                TapToShazamName.Rotation = 0; // Reset rotation
            }
 
        }
 */

      //  protected override async void OnAppearing()
//{
      //      base.OnAppearing();
          // await ImageButton_Clicked_2(); // Start the animation when the page appears
     //   }

        private async void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
        {
            while (true)
            {
                await TapToShazamName.RotateTo(360, 2000); // Rotate 360 degrees in 2 seconds
              TapToShazamName.Rotation = 0; // Reset rotation
            }

        }



    }

}
