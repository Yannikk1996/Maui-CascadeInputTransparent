namespace CascadeInputTransparent
{
    public partial class MainPage : ContentPage
    {
        bool Transparent = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Transparent = !Transparent;
            if (Transparent)
            {
                CounterBtn.Text = $"Transparent";
                ScrollContainer.InputTransparent = true ;
            }
            else
            {
                CounterBtn.Text = $"Inputs enabled";
                ScrollContainer.InputTransparent = false;
            }

           
        }
    }

}
