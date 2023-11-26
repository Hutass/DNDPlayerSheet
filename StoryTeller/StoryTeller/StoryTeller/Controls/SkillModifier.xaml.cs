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
    public partial class SkillModifier : ContentView
	{
        public static readonly BindableProperty ModifierProperty = BindableProperty.Create(
           nameof(Modifier),
           typeof(string),
           typeof(SkillModifier),
           string.Empty);
        public static readonly BindableProperty ValueProperty = BindableProperty.Create(
            nameof(Value),
            typeof(string),
            typeof(SkillModifier),
            string.Empty);
        public static readonly BindableProperty ProficiencyProperty = BindableProperty.Create(
            nameof(Proficiency),
            typeof(int),
            typeof(SkillModifier),
            0);
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(
            nameof(Command),
            typeof(Command),
            typeof(SkillModifier),
            null);
        public static readonly BindableProperty LongCommandProperty = BindableProperty.Create(
            nameof(LongCommand),
            typeof(Command),
            typeof(SkillModifier),
            null);

        public string Modifier
        {
            get => (string)GetValue(SkillModifier.ModifierProperty);
            set => SetValue(SkillModifier.ModifierProperty, value);
        }
        public string Value
        {
            get => (string)GetValue(SkillModifier.ValueProperty);
            set => SetValue(SkillModifier.ValueProperty, value);
        }
        public int Proficiency
        {
            get => (int)GetValue(SkillModifier.ProficiencyProperty);
            set => SetValue(SkillModifier.ProficiencyProperty, value);
        }
        public Command Command
        {
            get
            {
                return (Command)GetValue(SkillModifier.CommandProperty);
            }
            set => SetValue(SkillModifier.CommandProperty, value);
        }
        public Command LongCommand
        {
            get
            {
                return (Command)GetValue(SkillModifier.LongCommandProperty);
            }
            set => SetValue(SkillModifier.LongCommandProperty, value);
        }
        public SkillModifier ()
		{
			InitializeComponent ();
		}
	}
}