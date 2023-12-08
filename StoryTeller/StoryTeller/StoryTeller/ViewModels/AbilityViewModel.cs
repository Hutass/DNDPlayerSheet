using StoryTeller.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace StoryTeller.ViewModels
{
    public class AbilityViewModel
    {
        public virtual ICollection<SkillViewModel> Skills { get; set; }
        public Ability Ability { get; set; }
        public ICommand ModifierInfoCommand { get; set; }
        public ICommand ModifierChangeCommand { get; set; }
        public ICommand RollCommand { get; set; }
        public ICommand AdvantageRollCommand { get; set; }
        public ICommand DisadvantageRollCommand { get; set; }
    }
}
