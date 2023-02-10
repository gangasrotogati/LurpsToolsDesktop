using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LurpsTools
{
    public class Character
    {
        public string Name;
        public string Race;
        public string RacialTrait1;
        public string RacialTrait2;
        public List<Skill> SkillsList;
        public List<string> FeatsList;
        public List<string> FlawsList;
        public List<Item> ItemsList;
        public List<Note> NotesList;
        public int CharacterValue;
        public int CharacterHealth;
        public int CharacterSpeed;
        public int CharacterMana;
        public int CharacterHealthMax;
        public int CharacterSpeedMax;
        public int CharacterManaMax;
        public int Inspiration;
        public int CombatDice;
        public int PerformanceDice;
        public int CharacterPoints;

        public Character()
        {
            Name = "unnamed character";
            Race = "Human";
            SkillsList = new List<Skill>();
            //Skill unarmedSkill = new Skill();
            //unarmedSkill.SkillName = CharacterSkill.UnarmedAndGrappling;
            //unarmedSkill.SkillLevel = 2;
            //SkillsList.Add(unarmedSkill);
            FeatsList = new List<string>();
            FlawsList = new List<string>();
            ItemsList = new List<Item>();
            NotesList = new List<Note>();
            CharacterHealth = 10;
            CharacterSpeed = 10;
            CharacterMana = 10;
            CharacterHealthMax = 10;
            CharacterSpeedMax = 10;
            CharacterManaMax = 10;
            CharacterValue = 0;
        }

        public enum CharacterRace
        {
            Human = 0,
            Rooskald = 1,
            Erlkin = 2,
            Dwarf = 3,
            Orc = 4,
            Goblin = 5,
            Satyr = 6,
            Kobold = 7
        }

        public enum CharacterSkill
        {
            AlchemyAndPoisons = 0,
            BarterAndAppraise = 1,
            BluffAndFastTalk = 2,
            ClimbingAndAcrobatics = 3,
            CombatStrategyAndLeadership = 4,
            DiplomacyAndPersuation = 5,
            EngineeringAndArchitecture = 6,
            FantasticPlacesAndMagicalCreatures = 7,
            FeatOfStrengthAndResistance = 8,
            ForgeryLogicAndCodes = 9,
            GatherInformationAndStreetwise = 10,
            HistoryAndGeography = 11,
            IdentifySpellsAndArcaneItems = 12,
            IntimidateAndInterrogate = 13,
            MedicalApplicationAndPhysiology = 14,
            MundaneFaunaFloraAndFungi = 15,
            PerformanceAndArt = 16,
            PickLocksAndEscapeArtist = 17,
            PickpocketGamesAndSleightOfHand = 18,
            ReligionAndNobiliy = 19,
            RidingAndAnimalTrianing = 20,
            SailingAndVehicles = 21,
            SavoirFaireAndInfiltrations = 22,
            SearchingAndPerception = 23,
            SenseMotiveAndSocialInsight = 24,
            StealthAndDisguse = 25,
            SurvivalAndSwim = 26,
            TinkeringAndCraftin = 27,
            TrapsAndEscapology = 28,
            WitsAndDialect = 29,
            SlashingWeapons = 30,
            CrushingWeapons = 31,
            PiercingWeapons = 32,
            UnarmedAndGrappling = 33,
            BowsAndCrossbows = 34,
            GunpowderAndGrenades = 35,
            FireAndLight = 36,
            EarthAndNature = 37,
            AirAndLightning = 38,
            WaterAndIce = 39,
            HealingAndAbjuration = 40,
            NecromancyAndEnchantment = 41,
            ShadowAndIllusion = 42,
            MetalAndTransmutation = 43,
            MotionAndLevitation = 44,
            DivinationAndPrediction = 45
        }

        public enum CharacterFeat
        {
            AnimalAffinity = 0,
            ArmourExpert = 1,
            ArrowSnatch = 2,
            BeneathNotice = 3,
            BetterStaunching = 4,
            BlueBlood = 5,
            BowstaffTraining = 6,
            Brewmaster = 7,
            CombatArchery = 8,
            DayMagic = 9,
            Druidic = 10,
            Duellist = 11,
            EnsorcellItem = 12,
            FantasticShot = 13,
            ForgettableFace = 14,
            FullyLiterate = 15,
            Healthy = 16,
            HorsebackArcher = 17,
            ImprovedCharge = 18,
            ImprovedDisarming = 19,
            ImprovedDuelWeaponFighting = 20,
            InspirationalLeader = 21,
            LipReader = 22,
            MagicFingers = 23,
            ManaSensitive = 24,
            MilitaryRank = 25,
            MindAndBody = 26,
            NightMagic = 27,
            PiercingShot = 28,
            PinningShot = 29,
            PlentifulAmmo = 30,
            PolearmMaster = 31,
            PreciseShot = 32,
            Prepared = 33,
            PressTheAttack = 34,
            QuickDraw = 35,
            QuintessenceMagic = 36,
            Rage = 37,
            SkillFocus = 38,
            Skirmisher = 39,
            SorcerousFamiliar = 40,
            Tough = 41,
            VolleyFire = 42,
            Warmage = 43,
            WeaponFocusMelee = 44,
            WeaponFocusRange = 45,
            WizardlyTraining = 46,
            ForcefulSpell = 47,
            PenetratingSpell = 48,
            PersistentSpell = 49,
            ReachingSpell = 50,
            SeekingSpell = 51,
            SilentSpell = 52,
        }

        public enum CharacterFlaw
        {
            Addictions = 0,
            AlchemicalDistrust = 1,
            Amnesia = 2,
            AuraOfBadMagic = 3,
            BadTemper = 4,
            BlabberMouth = 5,
            Bloodlust = 6,
            BurnTheWitch = 7,
            CannotRide = 8,
            Claustrophobia = 9,
            CleanFreak = 10,
            CodeOfHonour = 11,
            ColourBlind = 12,
            DominantHanded = 13,
            Duty = 14,
            EldrichObsessions = 15,
            ExArmy = 16,
            Fat = 17,
            FineryFirst = 18,
            Frugal = 19,
            Glutton = 20,
            Grandiose = 21,
            HeritageDemonic = 22,
            HeritageFey = 23,
            HeritageVampiric = 24,
            Honest = 25,
            Illiteracy = 26,
            Imaptient = 27,
            Mania = 28,
            Miopic = 29,
            Narcissistic = 30,
            NeedSourceOfElementToCastSpells = 31,
            Nosy = 32,
            OverSpender = 33,
            Paranoia = 34,
            Phobia = 35,
            Pious = 36,
            Possessive = 37,
            Pride = 38,
            Queasy = 39,
            Racist = 40,
            ReligiousZealot = 41,
            Reputation = 42,
            StrictDiet = 43,
            Sickly = 44,
            Slow = 45,
            SlowHealer = 46,
            Snobby = 47,
            SocialStigma = 48,
            Ugly = 49,
            UnstableCasting = 50,
            Vertigo = 51
        }

        public enum CharacterItem
        {
            BallOfHighQualityString = 0,
            BearTrap = 1,
            BellsOnString = 2,
            Book = 3,
            BootPolish = 4,
            BoxOfWaterProofMatches = 5,
            BullseyeLantern = 6,
            Caltrops = 7,
            Candle = 8,
            Chalk = 9,
            Charcoal = 10,
            Chisel = 11,
            CloakHooded = 12,
            Clothing = 13,
            Compass = 14,
            DesertClothes = 15,
            DyeInk = 16,
            ExceptionallyFancyHat = 17,
            ExtendablePole = 18,
            FlintAndSteel = 19,
            Hammer = 20,
            HandcuffsAndShackles = 21,
            HolyWater = 22,
            LampOil = 23,
            Lantern = 24,
            LegQuiver = 25,
            Marbles = 26,
            NeedleAndThread = 27,
            NetTenByTenFoot = 28,
            NobleClothing = 29,
            PadlockAndKey = 30,
            PaperParchment = 31,
            Piton = 32,
            PocketWatch = 33,
            Potion = 34,
            RabbitSnare = 35,
            Ration = 36,
            RazorWire = 37,
            RopeFiftyFeet = 38,
            Sack = 39,
            SignetRing = 40,
            SlowMatch = 41,
            SoapExtraSlippery = 42,
            Telescope = 43,
            TrapComponents = 44,
            WaterSkin = 45,
            WinterClothoes = 46,
            WizardyLookingRobesAndHat = 47,
            AlchemySet = 48,
            MedicalKit = 49,
            RepairKit = 50,
            LockpickSet = 51,
            HuntersKit = 52,
            GamblersKit = 53
        }
    }
}
