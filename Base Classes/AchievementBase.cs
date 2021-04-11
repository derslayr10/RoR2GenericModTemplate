using System;
using System.Collections.Generic;
using System.Text;
using BepInEx.Configuration;
using RoR2;
using RoR2.Achievements;
using UnityEngine;
using R2API;
using static RoR2GenericModTemplate.Base_Classes.UnlockableBase;
using System.Reflection;

namespace RoR2GenericModTemplate.Base_Classes
{
    public abstract class AchievementBase : BaseAchievement, IModdedUnlockableDataProvider
    {
        #region Implementation
        public void Revoke()
        {
            if (base.userProfile.HasAchievement(this.AchievementIdentifier))
            {
                base.userProfile.RevokeAchievement(this.AchievementIdentifier);
            }

            base.userProfile.RevokeUnlockable(UnlockableCatalog.GetUnlockableDef(this.UnlockableIdentifier));
        }
        #endregion

        #region Contract
        public abstract string AchievementIdentifier { get; }
        public abstract string UnlockableIdentifier { get; }
        public abstract string AchievementNameToken { get; }
        public abstract string PrerequisiteUnlockableIdentifier { get; }
        public abstract string UnlockableNameToken { get; }
        public abstract string AchievementDescToken { get; }
        public abstract Sprite Sprite { get; }
        public abstract Func<string> GetHowToUnlock { get; }
        public abstract Func<string> GetUnlocked { get; }

        public abstract void Init(ConfigFile config);

        public abstract void Config(ConfigFile config);

        private readonly static MethodInfo GenericAddUnlock = typeof(UnlockableBase).GetMethod("AddUnlockable");

        protected void CreateAchievement() {

            GenericAddUnlock.MakeGenericMethod(this.GetType()).Invoke(null, new object[] { true });
        
        }

        #endregion

        #region Virtuals
        public override void OnGranted() => base.OnGranted();
        public override void OnInstall()
        {
            base.OnInstall();
        }
        public override void OnUninstall()
        {
            base.OnUninstall();
        }
        public override Single ProgressForAchievement() => base.ProgressForAchievement();
        #endregion
    }
}
