# RoR2GenericModTemplate
 A generic mod template for Risk of Rain 2. Based heavily on modules provided by R2API, as well as some other projects for handling of specific helper classes. Credits in README.

## How To Use
 Inside the BASIC TEMPLATES folder there are zipped files. You will want to download the Project Template and place it in your Visual Studio templates folder, usually found in Documents/Visual Studio/Templates. If you use a project template, place it in the Project Templates folder. You may put it in one of the other folders inside that folder if you wish, but it is not necessary. Then, open Visual Studio and create a new project. The RoR2GenericModTemplate should be somewhere in the list. The project includes everything necessary to make a basic mod.
 
 - Optional: if you so choose, you can also download the Item Templates from that folder, and they will be used just like the project templates except, and I hope this is obvious, they will go in the Item Templates folder. This will make it so you can create new classes with everything already set up inside them. This is not necessary, but if you want to make a ton of classes quickly it might save you a few seconds per each. Please note that these individual class templates will not work correctly without the project, so if you have these you will need the project, or you're just wasting a lot of time for really on reason.

## Future Plans
 This template is far from complete. I intend to add bits for any basic mod idea someone may have, and make this a one stop shop for those sorts of deals. That includes Items, Survivors, Unlockables, Buffs, etc. That being said, if there is something I have not included that you would like to see added, please open an issue and let me know. Please understand that this is heavily a work in progress and since I am currently the sole developer, it will take time for things to get made.
 
 ## Disclaimers
  - This template is not a tutorial, but simply a guide to help you make things quicker and more easily. If you want a tutorial, look elsewhere.
  - While this project references R2API, it is not very dependent on it. This is simply so you can use things from that inside the project easily.
  - This template includes a stubbed and publicized reference to the game's Assembly-CSharp.dll. This allows you access to otherwise private fields without using reflection, but will not allow you to steal the game. So, legal stuff only.
  - This template is for making creation of simple ideas faster and easier. It is not a do-all be-all for modding. It will create the foundation on which your mod to be built, not build the mod for you. If you want something to work, you need to learn how to do so. I highly encourage you to research and know what you are doing.
