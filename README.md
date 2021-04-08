# RoR2GenericModTemplate
 A generic mod template for Risk of Rain 2. Based heavily on modules provided by R2API, as well as some other projects for handling of specific helper classes. Credits in README.
 
 ***WARNING: this template is not a tutorial and should not be treated as such. For tutorials, please use the Risk of Thunder modding wiki.***

## How To Install Template
 Inside the BASIC TEMPLATES folder there are zipped files. You will want to download the Project Template and place it in your Visual Studio templates folder, usually found in Documents/Visual Studio/Templates. If you use a project template, place it in the Project Templates folder. You may put it in one of the other folders inside that folder if you wish, but it is not necessary. Then, open Visual Studio and create a new project. The RoR2GenericModTemplate should be somewhere in the list. The project includes everything necessary to make a basic mod.
 
## Basic Use
 ### Unity Package
  The template includes a pre-designed Unity Package to make setting up a unity project a little bit easier. In addition to this, it also includes a premade AssetBundle, but more on that later.
  
  To use the Unity Package, you must have the right version of Unity installed. This can be found on the Risk of Thunder modding wiki, and I point here because it has better documentation. Create a Unity Project and delete every object in the 'Scene' on the left. Then, delete the Scenes folder in the explorer at the bottom. Then, go to the Assets tab and find 'Import Package'. Click 'Custom Package' and navigate to your Visual Studio project folder. Select the Unity Package here (it should be the only one), and the Unity Project should update with a bunch of folders. This is a good thing. Create all necessary components, and be sure to add them to the 'mod_template' AssetBundle by selecting your item and in the bottom right of Unity there is an AssetBundle selector for you to categorize your items by bundle.
  
  When you are ready to export your bundle, go to the 'Window'tab and select 'Package Manager' and install the AssetBundleBrowser. When it is finished, go to the 'Window' tab again and click on 'AssetBundleBrowser'. Verify all of your items you want to export are in side the bundle, then go to the 'Build' tab. Use the 'Browse' button to navigate the output to your Visual Studio project folder, then click 'Build'. This will update the AssetBundle in your mod project and you are ready to go to the code portion of mod making.
  
 ### Visual Studio
  Do not mess with any files inside of folders. The Examples folder needs to be deleted before you build your mod, but for now it can be used as reference for how you should make your classes. You are free to edit the Example classes, but it is not recommended. There should be a folder that designates where to create your own classes. While it is not necessary to use this folder, it does make your project slightly more organized. Create a new class and setup your normal using statements at the top of the class. Be sure to include a statement that reads "using $ProjectName$.Base_Classes;" so your code can see these classes. Make your class inherit from the Base class that is necessary for that part of the mod. For instance, if you are creating an Item, inherit from ItemBase. Visual Studio will show an error, and if you use its suggested fix, it will implement all the inherited information necessary. 

## Future Plans
 This template is far from complete. I intend to add bits for any basic mod idea someone may have, and make this a one stop shop for those sorts of deals. That includes Items, Survivors, Unlockables, Buffs, etc. That being said, if there is something I have not included that you would like to see added, please open an issue and let me know. Please understand that this is heavily a work in progress and since I am currently the sole developer, it will take time for things to get made.
 
 ## Disclaimers
  - This template is not a tutorial, but simply a guide to help you make things quicker and more easily. If you want a tutorial, look elsewhere.
  - This template includes a stubbed and publicized reference to the game's Assembly-CSharp.dll. This allows you access to otherwise private fields without using reflection, but will not allow you to steal the game. So, legal stuff only.
  - This template is for making creation of simple ideas faster and easier. It is not a do-all be-all for modding. It will create the foundation on which your mod to be built, not build the mod for you. If you want something to work, you need to learn how to do so. I highly encourage you to research and know what you are doing. This template will not include everything, and uncommon or niche requests will likely go ignored. This template is targeted for those who wish to get into modding but aren't fully sure how to begin, and as such will only include what I deem common enough in the modding community as a need to have a template for. Because of this, Interactables will likely not be included as part of the template unless a lot of people ask for it.
