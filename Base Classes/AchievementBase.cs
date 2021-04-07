using System;
using System.Collections.Generic;
using System.Text;
using BepInEx.Configuration;
using RoR2;
using UnityEngine;

namespace RoR2GenericModTemplate.Base_Classes
{
    public abstract class AchievementBase : ModdedUnlockable
    {
        //uniqie identifier for achievement
        public abstract override string AchievementIdentifier { get; }

        //unique identifier for unlockables
        public abstract override string UnlockableIdentifier { get; }

        //achievement name. does not have to be unique
        public abstract override string AchievementNameToken { get; }

        //identifier of prerequisite unlockable
        public abstract override string PrerequisiteUnlockableIdentifier { get; }

        //name of unlockable
        public abstract override string UnlockableNameToken { get; }

        //description of achievement
        public abstract override string AchievementDescToken { get; }

        //icon for achievement
        public abstract override Sprite Sprite { get; }

        //these two form how the unlockable looks depending on if you have it or not
        public abstract override Func<string> GetHowToUnlock { get; }

        public abstract override Func<string> GetUnlocked { get; }

        public abstract void Init(ConfigFile config);

        public abstract void Configs(ConfigFile config);

    }
}
