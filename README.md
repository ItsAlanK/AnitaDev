# I'm Anita Project

The Basis for my MSc Thesis Project with the working title "I'm Anita". This will also be used for several CA's on the way towards the final project as these will involve building elements of what will become the final game. Development Log can be found on [my website](https://itsalank.com/blogs/msc-game-dev-final-project-log)

## Engine
The project is being developed in Unreal Engine 5.4.4

## Maps

- SE-CA1_PrototypeEnvironment.umap - Is a prototype level to develop mechanics (May also transition to Software engineering CA environment)

## Mechanics & Testing

- Bounce Pad functions
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
- Toxic Pool
	- Simple BP that checks for player overlap and deals damage with the player BP DealDamage event dispatcher
	- Should be refactored to be a Parent hazard class that can then be used in more situations similar to interactibles.
	- Checking which actor overlaps needed to change to checking the correct class so testing can be done with not player controller
- Interaction System
	- Flow: Overlap begins > Add overlap interact object to array in player BP > Player BP is always checking interactions list to see if array has changed and set which interactible is available > Available interactible is saved to variable which is being updated > When interact button is pressed, if there is a valid interactible, its interact function is triggered
	- Reference: https://www.youtube.com/watch?v=NhhATcTBqMA&list=PL5ADyRqL3M8HZru3SHTWF_iL28V25WaIp&index=3
