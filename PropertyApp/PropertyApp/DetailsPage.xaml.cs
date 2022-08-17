using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PropertyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(Property property)
        {
            InitializeComponent();
            Property = property;
            this.BindingContext = this;
        }

        public Property Property { get; set; }

        private void GoBack(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DetailsView.TranslationX = 600;
            DetailsView.TranslateTo(0, 0, 500, Easing.SinInOut);
        }
    }
}