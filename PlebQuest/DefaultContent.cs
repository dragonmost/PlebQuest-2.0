using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    internal static class DefaultContent
    {
        public static void Register(GameData data)
        {
            Item botteDuPereSylvain = new Item("Les bottes du père Sylvain")
            {
                Stats = new()
                {
                    CharacterStats = new()
                    {
                        Dexterity = 1
                    }
                }
            };

            data.ItemTemplates.Add(new UniqueItemTemplate(botteDuPereSylvain with
            {
                Name = $"{botteDuPereSylvain.Name} (Left)",
                Requirements = new()
                {
                    Slot = ItemSlot.LeftFoot
                }
            }));

            data.ItemTemplates.Add(new UniqueItemTemplate(botteDuPereSylvain with
            {
                Name = $"{botteDuPereSylvain.Name} (Right)",
                Requirements = new()
                {
                    Slot = ItemSlot.RightFoot
                }
            }));

            data.ItemTemplates.Add(new RandomItemTemplate("Goblin balls",
                new CharacterStatsRange
                {
                    Min = new()
                    {
                        Constitution = 2,
                        Strength = 4
                    },
                    Max = new()
                    {
                        Constitution = 5,
                        Strength = 10
                    }
                },
                new ItemRequirements
                {
                    Slot = ItemSlot.LeftHand | ItemSlot.RightHand
                }));
        }
    }
}
