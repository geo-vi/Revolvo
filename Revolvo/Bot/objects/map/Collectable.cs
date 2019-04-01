using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Bot.objects.map
{
    public enum Collectables
    {
        SHIP_LOOT_GRAY = 0,
        SHIP_LOOT = 1,
        BONUS_BOX = 2,
        EASTER_EGG = 3,
        BIG_PUMPKIN = 5,
        ORANGE_PUMPKIN = 6,
        TURKEY = 7,
        BIG_XMAS_STAR = 8,
        STD_XMAS_STAR = 9,
        FLOWER_MOTHERSDAY = 10,
        ITALIAN_BOX = 11,
        CREST_AND_STAR = 14,
        POLISH_BONUS_BOX = 15,
        WINTER_GIFT_BOX = 16,
        CARNIVAL_BOX = 17,
        BONUS_BOX_SUN = 19,
        PET_WEEK_BOX = 20,
        PIRATE_BOOTY_BOX = 21,
        PIRATE_BOOTY_GOLD = 22,
        HUNGARIAN_REVOLUTION = 23,
        ST_PATRICKS_DAY = 24,
        TITANIC_BOX = 25,
        BRAZIL_BOX = 26,
        VICTORY_FR_BOX = 27,
        VICTORY_RU_BOX = 28,
        VICTORY_CZ_BOX = 29,
        BOX_STAR = 30,
        PIRATE_BOOTY_RED_BOX = 31,
        PIRATE_BOOTY_BLUE_BOX = 32,
        VICTORY_FR = 33,
        MEXICAN_BONUS_BOX = 34,
        BOX_ANTEC = 35,
        GERMAN_UNIFICATION_DAY = 36,
        HISPANIC_DAY_BOX = 37,
        CANDY_BOX = 38,
        BIRTHDAY_BOX = 39,
        TREASURE_CHEST_BOX = 40
    }

    public class Collectable
    {
        public string Hash { get; set; }
        public Vector Position { get; set; }
        public Collectables Type { get; set; }

        public Collectable(string hash, Vector pos, Collectables type)
        {
            Hash = hash;
            Position = pos;
            Type = type;
        }
    }
}
