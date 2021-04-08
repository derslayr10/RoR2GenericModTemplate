using System;
using System.Collections.Generic;
using System.Text;
using BepInEx.Configuration;
using RoR2;
using RoR2GenericModTemplate.Base_Classes;
using UnityEngine;

namespace RoR2GenericModTemplate.EXAMPLES
{
    class EXAMPLE_ACHIEVEMENT : AchievementBase
    {
        public override string AchievementIdentifier => "EXAMPLE_CLASS_ACH_ID";

        public override string UnlockableIdentifier => "EXAMPLE_CLASS_UNLK_ID";

        public override string AchievementNameToken => "EXAMPLE_CLASS_ACH_NAME";

        public override string PrerequisiteUnlockableIdentifier => "";

        public override string UnlockableNameToken => "EXAMPLE_CLASS_UNLK_NAME";

        public override string AchievementDescToken => "EXAMPLE_CLASS_ACH_DECS";

        //you would just load from your asset bundle here using: Main.Assets.LoadAsset<Sprite>("pathtosprite");
        public override Sprite Sprite => throw new NotImplementedException();

        public override Func<string> GetHowToUnlock { get; } = (() => Language.GetStringFormatted("UNLOCK_VIA_ACHIEVEMENT_FORMAT", new object[] {

            //copy the string for AchievementNameToken
            Language.GetString("EXAMPLE_CLASS_ACH_NAME"),
            //copy the string for AchievementDescToken
            Language.GetString("EXAMPLE_CLASS_ACH_DECS")

        }));

        public override Func<string> GetUnlocked { get; } = (() => Language.GetStringFormatted("UNLOCKED_FORMAT", new object[] {

            Language.GetString("EXAMPLE_CLASS_ACH_NAME"),
            Language.GetString("EXAMPLE_CLASS_ACH_DECS")

        }));

        public override void Configs(ConfigFile config)
        {
            //configs go here
        }

        public override void Init(ConfigFile config)
        {
            Configs(config);
            Unlockables.AddUnlockable<EXAMPLE_ACHIEVEMENT>(true);
        }

        //for each hook you have, run += here
        public override void OnInstall()
        {
            base.OnInstall();
        }

        //and -= here
        public override void OnUninstall()
        {
            base.OnUninstall();
        }

    }
}
