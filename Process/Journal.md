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

The scripting logic was all done in blueprint (Many scripts), which I believe I will never learn to love.

The loss state UI also proved to be a challenge as the UI elements would not appear, requiring creative solutions and blueprint troubleshooting. A brand new UI widget needed to be created and redone several times to achieve the end screen, consisting of a death notice, retry and give up buttons.

## Improvements

I drafted several eerie piano soundtracks, but ultimately did not have the time to implement any sound. I created drafts of drones in synthesizers as well, and I anticipated to have directional footsteps (scurrying) of the enemy. I would have also liked to modify the environment and customize it, though time did not allow for such.


# Week 3 - Cube Dodger
### 05/02/26


## The Idea
- Physics
- Tags
- Sound
- Score & Printing

I was absent in the previous week, missed one assignment in this class as well as other classes so I was well...behind. So the best I could come up with without crashing out was modifying one of the tutorials from the textbook. I do follow along with the textbook readings and the videos, but don't usually do them the exact same way or keep them around my files. I did not go through any iterating or thinking really because...PANIK...so here we are, with a trash quality prototype but eh, I learned something.

## The Tutorial

I have used Unity before, but never in 3D. As 3D is my main artistic medium, it was obviously intriguing. Its 3D workflow is quite different from Unreal and I will get used to it eventually. I used the very first exercise in the book, titled "hello world", simply because well, it was easy and I did not do much last week or over the weekend from game jam crunch, my catch up session this weekend will be legendary. Getthing through the editor was a breeze as I am comfortable in Unity, scripting without having prompts is proving to be a challenge indeed, as the simplest mechanic of spawning a cube, I doubted I could think of on my own at this stage, so that's what I did. I went through the exercise once on paper, then tried my best to recreate it from memory inside Unity, with my own skill, and praying for proper syntax and no bugs.

That said, my first script was simply this attached to the camera to spawn the prefab, that's all, and I did end up needing to look around to get here, but hey, baby steps. The tutorial uses instantiate and never removes the cubes, so that is probably an implementation I sould have done. 

## Expansions

For the expansions, it was googling time. I initially created multiple scripts to create a modular workflow for each of my functions but that turned out to be a massive failure as I dumped all my code into my cube spawner (I deserve a slap) 

Looking at the base the tutorial had given me, I wanted to create some sort of raycasting mechanism that would allow the user to click the screen through the stationary camera and collide with the cubes. This being said, somewhat of a dodging game where the player would need to click where a cube was not, if they hit one, the game ends. It is really quite simple. 

I was using console statements throughout my script to ensure everything was working right.

### Mouse

I first tried to use the old input system and kept encountering errors, so I eventually figured out how to do it properly by going back to class content. I used a raycasting system by first finding the position of the mouse, then mapping it to the cube position on a 2D plane. An issue was enountered when the background objects were also triggering the game over state, despite only needing the cubes to be touched. Thus, a new tag had to be made. Me not being there last class also has its downsides as I spent 20 minutes banging my head against the wall when it would't find my cube tag...only to find out I needed to add it inside the editor.

### Printing

I simply used a counter to increase the score according to the mouse clicks, and printed them using a legacy text object, I could not get a tmp to drag into my variable slots for some reason. The game over is a bool within an if statement that is triggered when the cube is hit. 

### Sound
I truly am cursed with sound. Freesound it is...I am sad.

## See Cuuuuuuuube for project files

## Full script below: 

# Week 4 - Shadow
### 12/02/26


## The initial Idea

You know sometimes when you have a baller idea at 3am...yeah this was one of those days. I was talking to Marc the other day about starting independent research on emotional detachment and suppression in video games. Just a simple mechanic for now, working within this overarching idea, it's a start. I can try doing some art and sound just because, for funsies. The plan is to have some kind of framework to work towards in this class, even in the exploration prototypes, to somewhat scope out the ins and outs of said idea without pressure of fidelity or anything like that. No need to be deep, useful, can be extremely stupid, more so an overarching theme or aesthetic. I wanted to start thinking about aesthetics and what I wanted to do, so best to start early.

## Art

I started with the art as I explored some references, I thought about this foggy scratchy silouhette that doesn't have any soul or personality as the protagonist, just black. 
## Mechanics

##


