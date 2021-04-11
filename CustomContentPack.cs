using RoR2;
using RoR2GenericModTemplate.Utils;
using RoR2GenericModTemplate.Base_Classes;

namespace RoR2GenericModTemplate
{
    public static class CustomContentPack
    {

        public static ContentPack customContentPack;

        internal static void Init() {

            //this will create the lists necessary for adding to the content pack
            //simply run the Create() of the class you want to add here
            Items.Create();
            Unlockables.Create();

            customContentPack = new ContentPack {

                //adds custom items to the content pack
                itemDefs = Items.itemDefs,
                unlockableDefs = Unlockables.unlockableDefs,
            
            };

            AddContentPack(customContentPack);
        
        }

        //this method actually puts our content in the game
        private static void AddContentPack(ContentPack customContentPack)
        {
            On.RoR2.ContentManager.SetContentPacks += (orig, contentPackList) => {

                contentPackList.Add(customContentPack);
                orig(contentPackList);
            
            };

        }

    }

    //more or less a helper class for each set of items being added to the game
    public static class Items {

        //item def array that holds all your items
        public static ItemDef[] itemDefs;

        public static void Create() {

            itemDefs = ListHandlers.ItemDefList.ToArray();
        
        }
    
    }

    public static class Unlockables {

        public static UnlockableDef[] unlockableDefs;

        public static void Create() {

            unlockableDefs = UnlockableBase.unlockableDefs.ToArray();
        
        }

    }

}
