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
    public partial class AbilityModifier : ContentView
	{
        public static readonly BindableProperty ModifierProperty = BindableProperty.Create(
            nameof(Modifier),
            typeof(string),
            typeof(AbilityModifier),
            string.Empty);
        public static readonly BindableProperty ValueProperty = BindableProperty.Create(
            nameof(Value),
            typeof(string),
            typeof(AbilityModifier),
            string.Empty); 
        public static readonly BindableProperty ProficiencyProperty = BindableProperty.Create(
            nameof(Proficiency),
            typeof(int),
            typeof(AbilityModifier),
            0);
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(
            nameof(Command),
            typeof(Command),
            typeof(AbilityModifier),
            null);
        public static readonly BindableProperty LongCommandProperty = BindableProperty.Create(
            nameof(LongCommand),
            typeof(Command),
            typeof(AbilityModifier),
            null);

        public string Modifier
        {
            get => (string)GetValue(AbilityModifier.ModifierProperty);
            set => SetValue(AbilityModifier.ModifierProperty, value);
        }
        public string Value
        {
            get => (string)GetValue(AbilityModifier.ValueProperty);
            set => SetValue(AbilityModifier.ValueProperty, value);
        }
        public int Proficiency
        {
            get => (int)GetValue(AbilityModifier.ProficiencyProperty);
            set => SetValue(AbilityModifier.ProficiencyProperty, value);
        }
        public Command Command
        {
            get
            {
                return (Command)GetValue(AbilityModifier.CommandProperty);
            }
            set => SetValue(AbilityModifier.CommandProperty, value);
        }
        public Command LongCommand
        {
            get
            {
                return (Command)GetValue(AbilityModifier.LongCommandProperty);
            }
            set => SetValue(AbilityModifier.LongCommandProperty, value);
        }

        public AbilityModifier ()
		{
			InitializeComponent ();
		}
    }
}