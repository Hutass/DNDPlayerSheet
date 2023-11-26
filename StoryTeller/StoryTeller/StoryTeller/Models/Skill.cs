using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StoryTeller.Models
{
    public class Skill
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Proficiency { get; set; }
        public string Modifier
        {
            get
            {
                return (Math.Round((double)(Ability.Value - 10) / 2, MidpointRounding.AwayFromZero) + Proficiency * ProficiencyModifier >= 0) ?
            "+" + (Math.Round((double)(Ability.Value - 10.5) / 2, MidpointRounding.AwayFromZero) + Proficiency * ProficiencyModifier).ToString() :
            (Math.Round((double)(Ability.Value - 10) / 2, MidpointRounding.AwayFromZero) + Proficiency * ProficiencyModifier).ToString();
            }
        }
        public string AverageValue
        {
            get
            {
                return (Convert.ToInt32(Modifier) + 10).ToString();
            }
        }
        public Ability Ability { get; set; }
        public int ProficiencyModifier { private get; set; }
        public ICommand ModifierInfoCommand { get; set; }
        public ICommand ModifierChangeCommand { get; set; }
        public ICommand RollCommand { get; set; }
        public ICommand AdvantageRollCommand { get; set; }
        public ICommand DisadvantageRollCommand { get; set; }

    }
}
