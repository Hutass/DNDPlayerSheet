using StoryTeller.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StoryTeller.ViewModels
{
    public class CharacterViewModel : BaseViewModel
    {
        public ObservableCollection<Ability> Abilities { get; set; }
        public ObservableCollection<Roll> Rolls { get; set; }
        public CharacterViewModel()
        {
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            Abilities = new ObservableCollection<Ability>();
            Rolls = new ObservableCollection<Roll>();

            int proficiencyModifier = 2;

            Abilities.Add(new Ability
            {
                Id = "strength",
                Name = "сила",
                Value = 13,
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Skills = new ObservableCollection<Skill>()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "athletics",
                Name = "атлетика",
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Add(new Ability
            {
                Id = "dexterity",
                Name = "ловкость",
                Value = 18,
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Skills = new ObservableCollection<Skill>()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "acrobatics",
                Name = "акробатика",
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "sleightOfHand",
                Name = "ловкость рук",
                Proficiency = 1,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "stealth",
                Name = "скрытность",
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Add(new Ability
            {
                Id = "constitution",
                Name = "телосложение",
                Value = 13,
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Skills = new ObservableCollection<Skill>()
            });
            Abilities.Add(new Ability
            {
                Id = "intelligence",
                Name = "интеллект",
                Value = 18,
                Proficiency = 1,
                ProficiencyModifier = proficiencyModifier,
                Skills = new ObservableCollection<Skill>()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "arcana",
                Name = "магия",
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "history",
                Name = "история",
                Proficiency = 1,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "investigation",
                Name = "анализ",
                Proficiency = 2,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "nature",
                Name = "природа",
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "religion",
                Name = "религия",
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Add(new Ability
            {
                Id = "wisdom",
                Name = "мудрость",
                Value = 12,
                Proficiency = 1,
                ProficiencyModifier = proficiencyModifier,
                Skills = new ObservableCollection<Skill>()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "animalHandling",
                Name = "обращение с животными",
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "insight",
                Name = "проницательность",
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "medicine",
                Name = "медицина",
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "perception",
                Name = "восприятие",
                Proficiency = 1,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "survival",
                Name = "выживание",
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Add(new Ability
            {
                Id = "charisma",
                Name = "харизма",
                Value = 10,
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Skills = new ObservableCollection<Skill>()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "deception",
                Name = "обман",
                Proficiency = 1,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "intimidation",
                Name = "запугивание",
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "performance",
                Name = "выступление",
                Proficiency = 0,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Abilities.Last().Skills.Add(new Skill
            {
                Id = "persuation",
                Name = "убеждение",
                Proficiency = 1,
                ProficiencyModifier = proficiencyModifier,
                Ability = Abilities.Last()
            });
            Random random = new Random();
            foreach(var a in Abilities)
            {
                a.RollCommand = new Command(async () =>
                {
                    int value = random.Next(1, 21);
                    Roll roll = new Roll()
                    {
                        Advantage = 0,
                        Name = a.Name,
                        Result = (value + Convert.ToInt32(a.Modifier)).ToString(),
                        Expression = "1d20" + a.Modifier,
                        ExpressionResult = "(" + value + ")" + a.Modifier,
                    };
                    Rolls.Add(roll);
                    await Task.Delay(7500);
                    Rolls.Remove(roll);
                });
                a.AdvantageRollCommand = new Command(async () =>
                {
                    int value1 = random.Next(1, 21);
                    int value2 = random.Next(1, 21);
                    Roll roll = new Roll()
                    {
                        Advantage = 1,
                        Name = a.Name,
                        Result = (Math.Max(value1, value2) + Convert.ToInt32(a.Modifier)).ToString(),
                        Expression = "1d20↑" + a.Modifier,
                        ExpressionResult = "(" + value1+","+value2 + ")" + a.Modifier,
                    };
                    Rolls.Add(roll);
                    await Task.Delay(7500);
                    Rolls.Remove(roll);
                });
                a.DisadvantageRollCommand = new Command(async () =>
                {
                    int value1 = random.Next(1, 21);
                    int value2 = random.Next(1, 21);
                    Roll roll = new Roll()
                    {
                        Advantage = 2,
                        Name = a.Name,
                        Result = (Math.Min(value1, value2) + Convert.ToInt32(a.Modifier)).ToString(),
                        Expression = "1d20↓" + a.Modifier,
                        ExpressionResult = "(" + value1 + "," + value2 + ")" + a.Modifier,
                    };
                    Rolls.Add(roll);
                    await Task.Delay(7500);
                    Rolls.Remove(roll);
                });
                foreach (var s in a.Skills)
                {
                    s.RollCommand = new Command(async () =>
                    {
                        int value = random.Next(1, 21);
                        Roll roll = new Roll()
                        {
                            Advantage = 0,
                            Name = s.Name,
                            Result = (value + Convert.ToInt32(s.Modifier)).ToString(),
                            Expression = "1d20" + s.Modifier,
                            ExpressionResult = "(" + value + ")" + s.Modifier
                        };
                        Rolls.Add(roll);
                        await Task.Delay(7500);
                        Rolls.Remove(roll);
                    });
                    s.AdvantageRollCommand = new Command(async () =>
                    {
                        int value1 = random.Next(1, 21);
                        int value2 = random.Next(1, 21);
                        Roll roll = new Roll()
                        {
                            Advantage = 1,
                            Name = s.Name,
                            Result = (Math.Max(value1, value2) + Convert.ToInt32(s.Modifier)).ToString(),
                            Expression = "1d20↑" + s.Modifier,
                            ExpressionResult = "(" + value1 + "," + value2 + ")" + s.Modifier,
                        };
                        Rolls.Add(roll);
                        await Task.Delay(7500);
                        Rolls.Remove(roll);
                    });
                    s.DisadvantageRollCommand = new Command(async () =>
                    {
                        int value1 = random.Next(1, 21);
                        int value2 = random.Next(1, 21);
                        Roll roll = new Roll()
                        {
                            Advantage = 2,
                            Name = s.Name,
                            Result = (Math.Min(value1, value2) + Convert.ToInt32(s.Modifier)).ToString(),
                            Expression = "1d20↓" + s.Modifier,
                            ExpressionResult = "(" + value1 + "," + value2 + ")" + s.Modifier,
                        };
                        Rolls.Add(roll);
                        await Task.Delay(7500);
                        Rolls.Remove(roll);
                    });
                }
            }
        }

        public ICommand OpenWebCommand { get; }
        public ICommand RollCommand { get; }
    }
}