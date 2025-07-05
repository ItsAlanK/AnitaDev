# I'm Anita Project

The Basis for my MSc Thesis Project with the working title "I'm Anita". This will also be used for several CA's on the way towards the final project as these will involve building elements of what will become the final game. Development Log can be found on [my website](https://itsalank.com/blogs/msc-game-dev-final-project-log)

## Engine
The project is being developed in Unreal Engine 5.4.4

## Level Overview

The main playable level is now contained in `Env-Puzzle-Level.umap`. This redesigned environment features three puzzle zones, each of which supports the core research question:  
**“Do environmental diegetic tutorials foster stronger retention, autonomous problem-solving, and curiosity-driven exploration than directive tutorials in 3D platformer puzzle environments?”**

Each section of the level is tailored to collect gameplay data, with the environment either teaching implicitly through spatial design or explicitly through instructional UI. This level is used in player testing and is the version submitted for the Alpha milestone.

## Maps

- SE-CA1_PrototypeEnvironment.umap - Is a prototype level to develop mechanics (May also transition to Software engineering CA environment)

## Mechanics & Testing

- Bounce Pad functions (✅ Now fully functional and used in main puzzle areas)  
	- Needs more base unit tests as well as existing functional tests with char  
	- Tests are slow and I think it is these ones causing it  

- Respawn + Damage feature functions  
	- Player has 3 Hit Points and an event and function bound on construction to take damage.  
	- Take Damage function can be called by other BP's using casting to allow things like hazards to deal damage.  
	- This allows for different damage input values and has checks to validate inputs.  
	- Any time damage is dealt, it checks if HP is above 0 and if not, destroys actor which triggers respawn through GameMode BP  
	- Had to move events binding for taking damage into constructor to work with respawned player actors  
	- Discovered need for negative value checks in damage application function when building tests. Not whole number tests not needed as blueprint requires ints  
	- IsPlayerAlive function doesn't return anything, just destroys player actor if health is <= 0 so test checks if player object is valid. Each test requires its own player character instance to avoid being dependant on each other and the order the tests run.  
	- Expected Health values not hardcoded in case base health changes  

- Toxic Pool (⚠️ Logic implemented but not currently used in main level)  
	- Simple BP that checks for player overlap and deals damage with the player BP DealDamage event dispatcher  
	- Should be refactored to be a Parent hazard class that can then be used in more situations similar to interactibles.  
	- Checking which actor overlaps needed to change to checking the correct class so testing can be done with not player controller  

- Interaction System  
	- Flow: Overlap begins > Add overlap interact object to array in player BP > Player BP is always checking interactions list to see if array has changed and set which interactible is available > Available interactible is saved to variable which is being updated > When interact button is pressed, if there is a valid interactible, its interact function is triggered  
	- Parent BP exists with common functionality as a template then each individual child can have their own mesh, scale and text box settings.  
	- Interactibles have an optional text box system that takes an array of text lines that can be cycled through and resets when walking away  
	- Reference: https://www.youtube.com/watch?v=NhhATcTBqMA&list=PL5ADyRqL3M8HZru3SHTWF_iL28V25WaIp&index=3  

- Collection System (⚠️ Implemented and testable but not in active use in current level)  
	- Collection system is extensible similar to interaction system where a parent BP exists with common functionality as a template then each individual child can have their own mesh, scale and other aspects tailored.  
	- Health Collectible respawns and triggers players addHealth function to replenish lost health but not overheal  
	- Coin Collectibles serve as breadcrumbs in the world and trigger player char addCoin function to increase coin count shown onscreen.  

## Placeholder Assets (❌ No longer used in `Env-Puzzle-Level`) :
- [Kenney Fantasy Town Kit](https://kenney.nl/assets/fantasy-town-kit)  
- [Kenney Platformer Kit](https://kenney.nl/assets/platformer-kit)  
- [Kenney UI Pack](https://kenney.nl/assets/ui-pack-adventure)
