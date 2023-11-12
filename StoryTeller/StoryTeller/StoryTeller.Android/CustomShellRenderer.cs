using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Google.Android.Material.BottomNavigation;
using Java.Interop;
using StoryTeller;
using StoryTeller.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(TabbedPageRenderer), typeof(CustomTabbedPageRenderer))]
    namespace StoryTeller.Droid
{
    public class CustomTabbedPageRenderer : TabbedPageRenderer
    {
        private BottomNavigationView _bottomNavigationView;

        public CustomTabbedPageRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                _bottomNavigationView = (GetChildAt(0) as Android.Widget.RelativeLayout).GetChildAt(1) as BottomNavigationView;

            }
        }
        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
            ShapeDrawable line = new ShapeDrawable()
            {
                Alpha = 255
            };
            line.Paint.Color = Android.Graphics.Color.Argb(255,20, 20, 20);
            line.Paint.SetStyle(Paint.Style.Fill);
            var layerDrawable = new LayerDrawable(new Drawable[] { line });
            layerDrawable.SetLayerInset(0, 0, 0, 0, _bottomNavigationView.Height - 8);
            _bottomNavigationView.SetBackground(layerDrawable);
        }
    }
}