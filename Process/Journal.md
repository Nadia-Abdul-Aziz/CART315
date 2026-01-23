# Week 1 - Make A Thing
### 22/01/26


## The initial Idea

I pondered what I could make in one week that would be worth my time, and had initially settled on something I called the settings simulator, interim titled “This is totally a game”

The settings simulator would consist of a normal working settings menu, except, inspired by the worst volume control UI entries online, each parameter would entail infuriating mechanics to maneuver. For example, a recreation of the infamous slingshot volume controller. 

The final apply button would also change text on click in the following manner:

- Apply

- Apply?

- Are you sure?

- This will make you bad at the game.

Etc.

Perhaps up to 10 text options before the game auto-rage quits by itself to desktop (Game exists)

This was an interesting and quite witty idea I had to build in Unity, but ultimately, I got caught up in my other assignments for the days preceding the presentation Thursday. 


## The updated idea

The new idea hinged on a platform I was somewhat familiar with, but hated, never want to see ever again, and well…also makes me suffer. This platform is Unreal Engine, given that I am so intimidated by it, despite my experience, I took the opportunity to actually make a functioning game inside the engine, not just an environment, that I had never done successfully before. 

I found several tutorials online for games I could build realistically in a few hours (even if the tutorials were 10 minutes long) and I ended up choosing a horror game with an intelligent enemy system.

I chose to use a tutorial for the bulk of the work, as I am very inefficient, and tend to wing things then proceed to beat myself up when it doesn’t work. So, what better opportunity to force myself to actually learn properly, with proper blueprint management, file structures, organization and so on. I also opted to use a pre-built UE template to allow me to focus on the goal rather than getting distracted by aesthetics or environment building. This is my final plea at making UE my friend before I move on.

## The game & specifics

The game itself was based on the following tutorial:

https://www.youtube.com/watch?v=Tc6djD1MfgY

The premise is simply to hide and run away from a monster that is able to detect the player, as it moves across the environment. Upon collision, the player is killed. My goal was to build an enemy that was escapable, but difficult.

It utilizes the first person horror template, which I did not even know existed, it definitely made life very convenient. It came pre-built with an eerie environment as well as a stamina/run function.

I used the models provided by the tutorial, as I began importing the assets. The tutorial was made with a different editor version, so some nuances were present and I needed to troubleshoot from the very beginning, specifically in the animation blending at this stage. I used the animations given to assign different states to the enemy, before implementing the intelligence.


