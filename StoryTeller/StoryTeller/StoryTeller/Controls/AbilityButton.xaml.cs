using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamanimation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace StoryTeller.Controls
{
    [DesignTimeVisible(true)]
    public partial class AbilityButton : ContentView
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(AbilityButton),
            string.Empty);
        public static readonly BindableProperty ModifierProperty = BindableProperty.Create(
            nameof(Modifier),
            typeof(string),
            typeof(AbilityButton),
            string.Empty);
        public static readonly BindableProperty ValueProperty = BindableProperty.Create(
            nameof(Value),
            typeof(string),
            typeof(AbilityButton),
            string.Empty);
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(
            nameof(Command),
            typeof(Command),
            typeof(AbilityButton),
            null);
        public static readonly BindableProperty LeftSwipeCommandProperty = BindableProperty.Create(
            nameof(LeftSwipeCommand),
            typeof(Command),
            typeof(AbilityButton),
            null);
        public static readonly BindableProperty RightSwipeCommandProperty = BindableProperty.Create(
            nameof(RightSwipeCommand),
            typeof(Command),
            typeof(AbilityButton),
            null);

        public string Text
        {
            get => (string)GetValue(AbilityButton.TextProperty);
            set => SetValue(AbilityButton.TextProperty, value);
        }
        public string Modifier
        {
            get => (string)GetValue(AbilityButton.ModifierProperty);
            set => SetValue(AbilityButton.ModifierProperty, value);
        }
        public string Value
        {
            get => (string)GetValue(AbilityButton.ValueProperty);
            set => SetValue(AbilityButton.ValueProperty, value);
        }
        public Command Command
        {
            get
            {
                return (Command)GetValue(AbilityButton.CommandProperty);
            }
            set => SetValue(AbilityButton.CommandProperty, value);
        }
        public Command LeftSwipeCommand
        {
            get => (Command)GetValue(AbilityButton.LeftSwipeCommandProperty);
            set => SetValue(AbilityButton.LeftSwipeCommandProperty, value);
        }
        public Command RightSwipeCommand
        {
            get => (Command)GetValue(AbilityButton.RightSwipeCommandProperty);
            set => SetValue(AbilityButton.RightSwipeCommandProperty, value);
        }

        public AbilityButton()
        {
            InitializeComponent();
        }

        private void OnTapped(object sender, EventArgs e)
        {
            ColorAnimation animationIn = new ColorAnimation()
            {
                
                ToColor = Color.FromHex("FFD0CBBC"),
                Delay = 0,
                Duration = "200",
                Easing = EasingType.CubicIn,
            };
            ColorAnimation animationOut = new ColorAnimation()
            {
                ToColor = Color.FromHex("F8F4E3"),
                Delay = 300,
                Duration = "300",
                Easing = EasingType.CubicOut
            };
            buttonBackground.Animate(animationIn);
            buttonBackground.Animate(animationOut);
        }
        private void OnRightSwiped(object sender, EventArgs e)
        {
            ColorAnimation animationIn = new ColorAnimation()
            {

                ToColor = Color.FromHex("FFAFAAD9"),
                Delay = 0,
                Duration = "200",
                Easing = EasingType.CubicIn,
            };
            ColorAnimation animationOut = new ColorAnimation()
            {
                ToColor = Color.FromHex("F8F4E3"),
                Delay = 300,
                Duration = "300",
                Easing = EasingType.CubicOut
            };
            buttonBackground.Animate(animationIn);
            buttonBackground.Animate(animationOut);
        }
        private void OnLeftSwiped(object sender, EventArgs e)
        {
            ColorAnimation animationIn = new ColorAnimation()
            {

                ToColor = Color.FromHex("FFF48A7B"),
                Delay = 0,
                Duration = "200",
                Easing = EasingType.CubicIn,
            };
            ColorAnimation animationOut = new ColorAnimation()
            {
                ToColor = Color.FromHex("F8F4E3"),
                Delay = 300,
                Duration = "300",
                Easing = EasingType.CubicOut
            };
            buttonBackground.Animate(animationIn);
            buttonBackground.Animate(animationOut);
        }
    }
}