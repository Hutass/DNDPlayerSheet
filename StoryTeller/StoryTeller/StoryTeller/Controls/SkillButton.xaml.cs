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
    public partial class SkillButton : ContentView
	{
        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(SkillButton),
            string.Empty);
        public static readonly BindableProperty ModifierProperty = BindableProperty.Create(
            nameof(Modifier),
            typeof(string),
            typeof(SkillButton),
            string.Empty);
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(
            nameof(Command),
            typeof(Command),
            typeof(SkillButton),
            null);
        public static readonly BindableProperty LeftSwipeCommandProperty = BindableProperty.Create(
            nameof(LeftSwipeCommand),
            typeof(Command),
            typeof(SkillButton),
            null);
        public static readonly BindableProperty RightSwipeCommandProperty = BindableProperty.Create(
            nameof(RightSwipeCommand),
            typeof(Command),
            typeof(SkillButton),
            null);

        public string Text
        {
            get => (string)GetValue(SkillButton.TextProperty);
            set => SetValue(SkillButton.TextProperty, value);
        }
        public string Modifier
        {
            get => (string)GetValue(SkillButton.ModifierProperty);
            set => SetValue(SkillButton.ModifierProperty, value);
        }
        public Command Command
        {
            get
            {
                return (Command)GetValue(SkillButton.CommandProperty);
            }
            set => SetValue(SkillButton.CommandProperty, value);
        }
        public Command LeftSwipeCommand
        {
            get => (Command)GetValue(SkillButton.LeftSwipeCommandProperty);
            set => SetValue(SkillButton.LeftSwipeCommandProperty, value);
        }
        public Command RightSwipeCommand
        {
            get => (Command)GetValue(SkillButton.RightSwipeCommandProperty);
            set => SetValue(SkillButton.RightSwipeCommandProperty, value);
        }

        public SkillButton ()
		{
			InitializeComponent ();
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