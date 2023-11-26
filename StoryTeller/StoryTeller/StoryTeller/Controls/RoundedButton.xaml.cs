using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoryTeller.Controls
{
    [DesignTimeVisible(true)]
    public partial class RoundedButton : ContentView
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(RoundedButton),
            string.Empty);
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(
            nameof(Command),
            typeof(Command),
            typeof(RoundedButton),
            null);

        public string Text
        {
            get => (string)GetValue(RoundedButton.TextProperty);
            set => SetValue(RoundedButton.TextProperty, value);
        }
        public Command Command
        {
            get => (Command)GetValue(RoundedButton.CommandProperty);
            set => SetValue(RoundedButton.CommandProperty, value);
        }

        public RoundedButton()
        {
            InitializeComponent();
        }
    }
}