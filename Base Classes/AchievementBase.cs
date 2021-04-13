using System;
using BepInEx.Configuration;
using RoR2;
using RoR2.Achievements;
using UnityEngine;
using R2API;
using System.Reflection;

namespace RoR2GenericModTemplate.Base_Classes
{
    //creates the class and has it inherit the BaseAchievement from the base game and IModdedUnlockableDataProvider for use in adding the achievement via UnlockableAPI
    public abstract class AchievementBase : BaseAchievement, IModdedUnlockableDataProvider
    {
        //NOTE: MOST OF THIS CLASS HAS BEEN TAKEN FROM CODE I DID NOT WRITE SO EXPLANATIONS MAY BE LIMITED TO SOME CONTENT
        //#region used as section identifier
        #region Implementation
        //method to remove the unlockable and achievement if the mod is uninstalled
        public void Revoke()
        {
            //checks to see if the user has the achievement
            if (base.userProfile.HasAchievement(this.AchievementIdentifier))
            {
                //removes the achievement from the player
                base.userProfile.RevokeAchievement(this.AchievementIdentifier);
            }

            //removes the unlockable from the user
            base.userProfile.RevokeUnlockable(UnlockableCatalog.GetUnlockableDef(this.UnlockableIdentifier));
        }
        #endregion

        #region Contract
        //string to identify the achievement. MUST BE UNIQUE
        public abstract string AchievementIdentifier { get; }
        //string to identify the unlockable. MUST BE UNIQUE
        public abstract string UnlockableIdentifier { get; }
        //string to identify the achievement by a name token. Does not have to be unique
        public abstract string AchievementNameToken { get; }
        //string to identify a prerequisite for this achievement using the prereq's UnlockableIdentifier
        public abstract string PrerequisiteUnlockableIdentifier { get; }
        //string to identify the Unlockable by a name token. Does not have to be unique
        public abstract string UnlockableNameToken { get; }
        //string that provides the description for the achivement
        public abstract string AchievementDescToken { get; }
        //this is the icon the achievement will use. Loaded from the asset bundle
        public abstract Sprite Sprite { get; }
        //these two methods are weird, they set the description for the achivement based on whether the player has unlocked it
        public abstract Func<string> GetHowToUnlock { get; }
        public abstract Func<string> GetUnlocked { get; }

        //initialize the achievement
        public abstract void Init(ConfigFile config);

        //create a method to run configs
        public abstract void Config(ConfigFile config);
        
        //this is used to make AddUnlockable generic to allow a dynamic call to it in classes that inherit AchievementBase
        private readonly static MethodInfo GenericAddUnlock = typeof(UnlockableAPI).GetMethod("AddUnlockable");

        //makes the call to UnlockableAPI.AddUnlockable on classes that inherit AchievementBase
        protected void CreateAchievement() {

            //adds the achievement to the game with the arguments of AddUnlockable<TheClassName>(true) where TheClassName inherits AchievementBase
            //(in this case) and true means the achievement is server tracked
            GenericAddUnlock.MakeGenericMethod(this.GetType()).Invoke(null, new object[] { true });
        
        }

        #endregion
        //this section handles how to handle granting the achievement, what happens when the mod is installed and uninstalled, and how progression for the mod is handled
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
