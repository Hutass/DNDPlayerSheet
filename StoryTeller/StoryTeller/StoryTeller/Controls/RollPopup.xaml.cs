using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamanimation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoryTeller.Controls
{
    [DesignTimeVisible(true)]
    public partial class RollPopup : ContentView
	{
        public static readonly BindableProperty ResultProperty = BindableProperty.Create(
            nameof(Result),
            typeof(string),
            typeof(RollPopup),
            string.Empty);
        public static readonly BindableProperty NameProperty = BindableProperty.Create(
            nameof(Name),
            typeof(string),
            typeof(RollPopup),
            string.Empty);
        public static readonly BindableProperty ExpressionProperty = BindableProperty.Create(
            nameof(Expression),
            typeof(string),
            typeof(RollPopup),
            string.Empty);
        public static readonly BindableProperty ExpressionResultProperty = BindableProperty.Create(
            nameof(ExpressionResult),
            typeof(string),
            typeof(RollPopup),
            string.Empty);
        public static readonly BindableProperty AdvantageProperty = BindableProperty.Create(
            nameof(Advantage),
            typeof(int),
            typeof(RollPopup),
            0);

        public string Result
        {
            get => (string)GetValue(RollPopup.ResultProperty);
            set => SetValue(RollPopup.ResultProperty, value);
        }
        public string Name
        {
            get => (string)GetValue(RollPopup.NameProperty);
            set => SetValue(RollPopup.NameProperty, value);
        }
        public string Expression
        {
            get => (string)GetValue(RollPopup.ExpressionProperty);
            set => SetValue(RollPopup.ExpressionProperty, value);
        }
        public string ExpressionResult
        {
            get => (string)GetValue(RollPopup.ExpressionResultProperty);
            set => SetValue(RollPopup.ExpressionResultProperty, value);
        }
        public int Advantage
        {
            get => (int)GetValue(RollPopup.AdvantageProperty);
            set => SetValue(RollPopup.AdvantageProperty, value);
        }
        public RollPopup ()
		{
            InitializeComponent();
            this.Margin = new Thickness (this.X - 300,0,0,0);
            TranslateToAnimation startTranslateToAnimation = new TranslateToAnimation()
            {
                TranslateX = 300,
                Duration = "300",
                Easing = EasingType.Linear,
            };
            TranslateToAnimation endTranslateToAnimation = new TranslateToAnimation()
            {
                TranslateX = -300,
                Duration = "400",
                Delay = 7000,
                Easing = EasingType.CubicIn,
            };
            this.Animate(startTranslateToAnimation);
            this.Animate(endTranslateToAnimation);
        }
        private void OnCreated(object sender, EventArgs e)
        {
            
        }
    }
}