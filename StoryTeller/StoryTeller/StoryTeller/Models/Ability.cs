using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace StoryTeller.Models
{
    public class Ability
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Modifier 
        {
            get 
            {
                return (Math.Round((double)(Value - 10) / 2, MidpointRounding.AwayFromZero) + ProficiencyModifier * Proficiency >= 0) ?
                    "+" + (Math.Round((double)(Value - 10.5) / 2, MidpointRounding.AwayFromZero) + ProficiencyModifier * Proficiency).ToString() :
                    (Math.Round((double)(Value - 10) / 2, MidpointRounding.AwayFromZero) + ProficiencyModifier * Proficiency).ToString();
            } 
        }
        public string AverageValue
        {
            get
            {
                return (Convert.ToInt32(Modifier) + 10).ToString();
            }
        }
        public int Value { get; set; }
        public int Proficiency { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public int ProficiencyModifier { private get; set; }
        public ICommand ModifierInfoCommand { get; set; }
        public ICommand ModifierChangeCommand { get; set; }
        public ICommand RollCommand { get; set; }
        public ICommand AdvantageRollCommand { get; set; }
        public ICommand DisadvantageRollCommand { get; set; }
    }
}
