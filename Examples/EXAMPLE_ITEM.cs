using System;
using System.Collections.Generic;
using System.Text;
using BepInEx.Configuration;
using R2API;
using RoR2;
using RoR2GenericModTemplate.Base_Classes;
using RoR2GenericModTemplate.Utils;
using UnityEngine;
using static RoR2GenericModTemplate.Utils.ItemHelper;

namespace RoR2GenericModTemplate.Examples
{
    public class EXAMPLE_ITEM : ItemBase
    {
        public override string ItemName => "EXAMPLE_ITEM";

        public override string ItemLangTokenName => "EXAMPLE_ITEM";

        public override string ItemPickupDesc => "EXAMPLE_ITEM";

        public override string ItemFullDescription => "EXAMPLE_ITEM";

        public override string ItemLore => "EXAMPLE_ITEM";

        public override ItemTier Tier => ItemTier.NoTier;

        public override string ItemModelPath => "EXAMPLE_ITEM";

        public override string ItemIconPath => "EXAMPLE_ITEM";

        public override void CreateConfig(ConfigFile config)
        {
            //configs go here
        }

        public override ItemDisplayRuleDict CreateItemDisplayRules()
        {
            ItemBodyModelPrefab = Main.Assets.LoadAsset<GameObject>(ItemModelPath);
            var itemDisplay = ItemBodyModelPrefab.AddComponent<ItemDisplay>();
            itemDisplay.rendererInfos = ItemDisplaySetup(ItemBodyModelPrefab);

            ItemDisplayRuleDict rules = new ItemDisplayRuleDict(new RoR2.ItemDisplayRule[]
            {

                new RoR2.ItemDisplayRule
               {
                    ruleType = ItemDisplayRuleType.ParentedPrefab,
                    followerPrefab = ItemBodyModelPrefab,
                    childName = "Chest",
                    localPos = new Vector3(0, 0, 0),
                    localAngles = new Vector3(0, 0, 0),
                    localScale = new Vector3(1, 1, 1)
                }

            });

            return rules;
        }

        public override void Hooks()
        {

            //insert hooks here
            
        }

        public override void Init(ConfigFile config)
        {

            CreateConfig(config);
            CreateItemDisplayRules();
            CreateLang();
            CreateItem();
            Hooks();

        }
    }
}
