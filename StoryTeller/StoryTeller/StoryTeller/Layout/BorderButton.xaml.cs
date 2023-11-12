﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StoryTeller.Layout
{
	[DesignTimeVisible(true)]
	public partial class BorderButton : ContentView
	{
        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(BorderButton),
            string.Empty);
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(
            nameof(Command),
            typeof(Command),
            typeof(BorderButton),
            null);

        public string Text
		{
			get => (string)GetValue(BorderButton.TextProperty);
			set => SetValue(BorderButton.TextProperty, value);
		}
        public Command Command
        {
            get => (Command)GetValue(BorderButton.CommandProperty);
            set => SetValue(BorderButton.CommandProperty, value);
        }

        public BorderButton()
        {
            InitializeComponent();
        }
    }
}