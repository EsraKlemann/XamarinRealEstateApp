using Android.Content;
using PropertyApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace PropertyApp.Droid
{
    public class CustomEntryRenderer : Xamarin.Forms.Platform.Android.EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
            }
        }
    }
}