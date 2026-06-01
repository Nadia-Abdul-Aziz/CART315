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

- Attempted spawning children objects (Removed)
- Prefabs
- Self-made sprites & animation

## The initial Idea

You know sometimes when you have a baller idea at 3am...yeah this was one of those days. I was talking to Marc the other day about starting independent research on emotional detachment and suppression in video games. Just a simple mechanic for now, working within this overarching idea, it's a start. I can try doing some art and sound just because, for funsies. The plan is to have some kind of framework to work towards in this class, even in the exploration prototypes, to somewhat scope out the ins and outs of said idea without pressure of fidelity or anything like that. No need to be deep, useful, can be extremely stupid, more so an overarching theme or aesthetic. I wanted to start thinking about aesthetics and what I wanted to do, so best to start early.

## Mechanics
The main idea consisted of a characted progressively taking on more burdens, and I thought about how I can do so quickly for just an exploratory concept. Thus, I converged on the idea of an endless runner. A runner where progressively larger "obstacles" would spawn and would somehow obstruct either the look or path of the character.

The initial outcome would be for the character to become more and more scribbled or unclear, and slow down, to represent how the burden weighs on them. The obstacle would fall, some kind of dialogue would appear such as:

- "I need to hang on to this..."
  
- "I can't go on without this..."

Lines of dialogue that imply the reluctance to let go, or the notion that they must carry the burden with them.

In development, I switched paths, and opted to have the obstacles obstruct the path of the character, and progressively cover the clickability of the text they need to click to go forward, Thus, after the 6th and largest obstacle, the game ends.

<img src="https://github.com/Nadia-Abdul-Aziz/CART315/blob/main/Process/Media/Screenshot%202026-02-12%20172658.png">

Instead of visibly going slower and heavier (I did not have time to implement the animations), the obstacles spawn at larger and larger intrvals.

## Art

I started with the art as I explored some references, I thought about this foggy scratchy silouhette that doesn't have any soul or personality as the protagonist, just black. The first thing I did was sketch out a menu screen (Which i did not use...) to explore the aesthetics within gameplay that I wanted, because I need to start caring about that:

<img src="https://github.com/Nadia-Abdul-Aziz/CART315/blob/main/Process/Media/Screenshot%202026-02-12%206.02.50%20PM.png">

(Yes, the button becomes brighter as another sprite that would switch when clicked)
I then created a simple walk cycle of a character.

<img src="https://github.com/Nadia-Abdul-Aziz/CART315/blob/main/Process/Media/Screenshot%202026-02-12%206.06.59%20PM.png">

Then this final drawing of the background:

<img src="https://github.com/Nadia-Abdul-Aziz/CART315/blob/main/Process/Media/sketch1770926110868.png">

The obstacles, considering my initial goal of de-clarifying the player, I opted for these scribbles that I could animate over the character.

<img src="https://github.com/Nadia-Abdul-Aziz/CART315/blob/main/Process/Media/Screenshot%202026-02-12%206.02.01%20PM.png">

## Programming

I followed an endless runner tutorial to begin, and adapted it HEAVILY...very HEAVILY, and essentially only used the spawner logic really. The original tutorial actually did include children objects with different variables, but I ultimately removed them to move towards my goal, and never re-incorporated them before submission. The player movement is quite simple with simple left and right movement with colliders and a rigid body.
The collision system and spawner is uh....I don't wanna talk about it, it doesn't work amazingly, and the first obstacle was stopping way before it was supposed to so I just...removed the collider for the purposes of the prototype. 

## Future

Will I continue this? HELL YEAH, I like the idea, it just sucks at the moment and is super simple. I think the art works well and was a successful exploration in that sense, but needs some refinement since it looks a little inconsistent at times. The programming is well, a mess (That's what I'm here to learn anyway lol) so we're gonna get somewhere. I'll most likely expand on it in the coming days, with a new journal note. 

# Week 5 - Shadow Contd.
### 19/02/26

- More drawing and animation implementation!

## The Prototype Idea
This week follows the prototype that I was developping last week, I did not do much this week though since I had already done so much in the previous week. The idea has been further developped narratively outside the scope of this class. I've developped this potential idea of using the shadow as a vessel to contain emotional turmoil to rid the host from the pain. That said, it can function as a container, but will eventually overfill, so I eventually want to develop it into some kind of "purge" of sorts that needs to happen peridically, and conversely if the shadow does not return to normal after the purge, then the host experiences the brunt of the emotional pain. I think this is a good idea to play on the theoretical idea of suppression and depersonalization.

## Implementation
The implementation followed the basic class instructions that were given (P.S, I would love class recordings of the demos), as well as the following tutorial:

https://www.youtube.com/watch?v=AdQz2wStdLY

I unfortunately drew the animations but could not implement them last week! SO NOW I DID AAAAA!!!

The sizing out of my drawing application was not scaling well within unity and required some troubleshooting for some reason that I did not expect. The walking animations also did not provide as much motion as I would have liked, so in the event of improvement, I could go back and redo the walk cycle.

A new animation was added to further accentuate the accumulation of weight as the character progresses. I added animations that progressively increase the scribbles on the body to illustrate the mental turmoil of carrying these weights. The scribbles added an amazing touch to the character towards communicating the message.

I also improved the menu screen by adjusting colors


## Future

I don't think this is viable as a final project as it currently stands though with some tweaks it can be in the case that I do the final project individually. If not, then will likely develop the idea for independent work, since I think there is some potential here.

# EXTRA EXTRA EXTRA!!! - Superliminal

I have chosen a game at random for my review, and I am also challenging myself to write this without yapping and without excessive amounts of research, mostly from my own brain. Superliminal is a game that I played around a year ago an finished it in a few days, but it stuck with me, partly because of its simple mechanics yet masterful execution. It did happen to arrive in my steam during a time where I was obsessed with generating impossible objects in blender and play with optical illusions, so it stuck well, though I took a lot from the game and some elements still stick out to me to this day.

## Mechanics & Narrative
From a game design perspective, Superliminal is actually legit awesome because its core mechanic isn't really puzzles it reshapes the player’s understanding of reality. Instead of challenging the player's logic in a difficult manner like The talos principle (Okay, please don't get me started, I could write a paper on that game, but the puzzles themselves are created to test logical reasoning), superliminal challenges the viewer's perception and urges you to think outside the box. 

I believe its main mechanic is dubbed forced perspective, so instead of mastering a system, the player must change how they see to progress. They are not governed by fixed scale or truth, only how they appear in our eyes. A small chess piece held close to the camera becomes a towering object when placed further away. A moon becomes a marble. A door can exist simply because the painting of one appears (I think this was in one of the rooms). This essentially removes the barrier between player cognition and avatar action and creates a design loop built not on skill mastery but on conceptual shifts.

This mechanic only works because the game operates within non eulidean space (Similar to Antichamber or Manifold garden). Traditional games operate within stable, Euclidean space, distances are fixed, scale is consistent, and objects obey predictable...ish spatial rules. Even in fantasy, geometry behaves the way...it's supposed to, but in superliminal it doesn't. Size is not intrinsic, but relational, distance is not fixed, but collapsible, geometry is not stable, but viewpoint-dependent. An object does not have a “real” size, it has a seen size. When the player picks something up, they are not holding mass. Thus, puzzles can arise from contradictions, like a staircase that is both small and climbable, fundamentally non-Euclidean interactions, spaces that cannot exist in consistent three-dimensional geometry but are made functional through player perspective.

Thus, it also removes some of the common pitfalls to puzzle games, whether exhaustion through complexity escalation, introducing more systems, and more, it just deepens the implications of the one. Each new puzzle feels fresh not because new mechanics are added, but because the meaning of the mechanic evolves.

This is also very interesting from a narrative standpoint, as reality is in the eye of the beholder, specifically the brain’s reliance on visual cues to infer depth and scale, the game turns a cognitive shortcut into a systemic rule. Thus, this feeds into the narrative rooded in perceptual psychology of redefining your life.

Narratively, Superliminal works because its story is inseparable from its mechanics. The game’s dream-therapy setting reframes its spatial distortions not as abstract puzzle gimmicks really, they're manifestations of the base theme of mindset change and interpretation. The writing is effective because it mirrors the gameplay’s gradual destabilization and reconstruction of certainty, as calm instructional voices become unreliable. I could go on about this all day, but this is getting long...BUT AAAAAH THE AESTHETIC AND USE OF LIMINAL SPACE FOR THE THEME!!

# Week 6 - Disability centered game design.
### 19/02/26

- Literature Review (Nadia)
- Short story and fiction research (Nadia)
- Game inspiration Research (Nadia & Nat)
- Pinterest moodboarding (All)
- Palette extraction (Alex)
- Sketching (Alex)
- Figma prototyping (ALL)

## The process to get here

So basically, in summary, me and Alex decided we might want to work together, so we started brainstorming and had a full page of content (I have not recieved consent to share it because it's a disaster...mostly my fault tbh), and one of our ideas centered around disability, then we went in for the workshop, and Alex and Nat were PRODUCTIVE...so nat was added to the team and here we are.

## The Prototype Idea

This game flips the traditional narrative of disability by placing the player in a world where everyone else is disabled, except you. Difference becomes the source of isolation. We are currently debating whether the player is perceived as strange and an object of fear, or one of admiration, provoking jealousy, discomfort, or rejection from those around them. Rather than positioning disability as lack, the game reframes normality itself as a form of absence, rather something unremarkable, uninteresting, and missing. We are still unsure on the mechanics, as we will be discussing that next week, but we do know that we want it to be 3D, and 1st or 3rd person is undecided. We want the game to function by having the main character interact with npcs, and these interactions will give the main character a piece of insight towards their mindset and identity. The game will be structured in a series of areas, with each area becoming progressively claustrophobic and grim. The nature of the interactions will also increase in intensity and distress as he areas pass. Sensitive topics such as sucicidal ideation, eating disorders and metal health will be adressed, and a trigger warning is being considered. These are some questions we thought about:

- Illustrating the questioning of legitimacy but peers
- Showing internal doubt and rumination from perceived difference
- Exploring identity through imposed deficiency (Normal but framed as deficient)
- Framing normality as structural failure
- Anxiety of not being “enough” or "they way I should be"
- Examining envy toward others
- Rendering social comparison as violence
- Treating disabilities as an internal experience, rather than a visible one
- Reflecting the burden of having no infrastructure
- Depicting exclusion without hostility
- Exhaustion of constant self-justification
- Showing how admiration can isolate
- Visualizing alienation through spatial design
- Portraying empathy as selective
- Longing for visible struggle
- Showing internal conflict between pride and shame
- Illustrating the desire to be “fixed” socially
- Exploring absence as a form of stigma
- Silence as a social barrier
- Resilience becomes expectation
- Compliments come across as dismissive
- How others cannot believe the severity of the matter
- Others unknowingly poking at insecurities
- Mental construction of self-image
- Elements of psychosis (Need to be fleshed out)
- How the collective experience can impact self image

## Look & Feel

This week, we focused on solely the aesthetic and atmosphere of the game as a whole: please see the figma files below for the full mind map.

https://www.figma.com/board/96Agl9qXBoQBG0pwlN38Df/CART315-look-feel-prototype?node-id=0-1&t=ECnj30gX93joJRnS-1

We began by making a pinterest board collaboratively to converge on a vision, then extracted two main aesthetics, one that is bleak and another that is chaotic. We compromised on a painterly style that is serene and eerie yet chaotic with visible brushstrokes. We extracted the palettes from the images but debated them heavily that they were overused. Alex then came across a random image, with a purple color scheme, and we thought it provides a rather melancholy vibe to the atmosphere as opposed to the overused green undertones in film and media when representing distress. With some iteration, we settled on a final palette and style. As we want this to be in Unity 3D, we will be using Blender for the modeling with the grease pencil function, and procreate and perhaps substance painter as needed. 

The figma file below detailes the style and color moodboard more:

https://www.figma.com/design/DMQOIKNevP8mTI4C5B4ILA/CART315-Look-feel-prototype-moodboard?node-id=1-2&t=T8cN86bUOYaafqvr-1

We then began looking for narrative inspiration, first beginning in the form of other games. Most of the games provide either a narrow view of some themes, and we noticed an overwhelming tendency to avoid distress and triggering topics in independent games. The amount of games whose main themes centered around disability or mental health proved to be low (Though we did find a few more after making the figma file, Depression Quest and more). I then moved to literature review where lots of appealing stories came through, such as Harrison Bergeron whose themes of ignorance, fear and egalitarianism are interesting to us. In flowers for algernon, the internal monologue of the main character as he processes the stages of his cognition as well as his social interactions are of much interest to us. In the yellow wallpaper, the subtle poetry of being misunderstood and ignored is an amazing reference. In acedemic literature review, we found much talk on the misrepresentation of diabilities and where the gaps lie, interestingly, we also found a paper directly surveying neurodivergent gamers on the representation they would like to see.

## Next week

We will be meeting to discuss mechanics early next week and aim to have a crude Unity or paper prototype prepared soon. We plan on starting a twine to flesh out the narrative or at least come up with a few npc personas + personal map of the main character (Design values, personality traits, desired outcomes, mental states to explore, etc). Additionally, we'd ideally want to start the unity project somehow, at least basic scripts.

# Week 8 - Disability centered game design: contd.

- Narrative script & Dialogue(Nat)
- Character personality sketches (Nat - In progress)
- NPC Drafting (Alex)
- Texturing (Alex)
- Sculpting (Nadia)
- Hard modeling (Nadia)
- Unity level design (Nadia - In progress)
- Mechanics finalization (All)
- Gameplay finalisation (All)

## The Meeting

The three of us met at TAG one day and sprawled everything on the whiteboard. We went over the mechanics we wanted as well as how we wanted the game to flow. We ultimately decided that our character would spawn outdoors in a park, surrounded by people, and progressively enter more and more suffocating and claustrophobic spaces as follows:

- Outside
- Cafe
- Job fair
- Clinic
- Job fair 5@7
↓
- Character dissociates to their bedroom

While in any of these areas, the player can return outside, which reflects the notion of if the player is overwhelmed by the society they may retreat.

<img src="https://github.com/Nadia-Abdul-Aziz/CART315/blob/main/Process/Media/20260301_145235.jpg">

The transitions between each of these locations would be dictated by dialogue by the NPCs that come up to the player. A group favorite design decision was the behaviour of the NPCs, that all NPCs can be listened to, essentially eavesdropping on conversations. As the character progresses into insecurity, the topics of conversation become more and more relevant to the character's self. Thus NPC mechanics are the main driving factor of the game, and are as follows;

For the player:
- Approach a group of NPCs to listen in
- Any individual NPC can be directly interacted with using A
- Important narrative driving NPCs will get the attention of the player but the player can choose to ignore or interact

For the dialogue array:
- NPC group dialogue is stored by area of the game, and within an area, each time the player listens in, will recieve a random seed.
- Once A is pressed on any NPC to interact directly, a random "Interact" dialogue from the area will be pushed.
- Any driving dialogue will be stored seperately (once again by area) but will be pushed in order, if the player ignores one NPC, the same dialogue will be pushed to the next one.

We then spoke about accessibility notions in the controls and gameplay, and decided we wanted to cater to colorblindness, implement customizable controls, and show the player where to go with an arrow.

We made a scene brainstorm for outside, arguably our most important scene, while making a prop list. 

## Modeling & Sculpting

From then my role shifted to the main 3D artist as I have experience blocking out levels in UE and asset making in Blender. Myself and Alex needed a way to test the aesthetics and pipeline between Blender and procreate. I wanted to create the leaves as image planes to minimize the amount of polies needed so well...I needed to make a leaf. I adhered to the painterly style we laid out, so that it could be turned into a sheet and converted into a blender particle system. The tree itself was created by hard modeling in blender in as low polies as I could, as I have a tendency to create extremely high poly assets.

<img src="https://github.com/Nadia-Abdul-Aziz/CART315/blob/main/Process/Media/227b610b-7112-429f-89f0-a477f8a782e3.png">
<img src="https://github.com/Nadia-Abdul-Aziz/CART315/blob/main/Process/Media/tree.png">

Given the list above, I made a bench, that I could then UV unwrap easily and send over to Alex to texture.

<img src="https://github.com/Nadia-Abdul-Aziz/CART315/blob/main/Process/Media/image2.png">

Oh I also made a garbage can earlier but meh.

I will be needing to sculpt NPCs, I have not decided whether sculpting them myself or using Metahuman is the right way to go given our painterly texturing plans, so that has been shoved aside for now. Instead I am sculpting a dog...yes a doggo...our doggo is very important.

### The Dog

So the doggo appears twice, at the very beginning and the very end. Upon character spawn in the park, they are met with a monument that represents resilience, which will (tbd) be the dog, then at the very end, using our color palette to communicate overwhelm, in a fully purple room, the dog emerges in the back of the room in fully yellow. It represents solace in this grim environment, and escape for the player, resilience. I began sculpting it in Nomad, and have purchased a few brush sets to complete it.

<img src="https://github.com/Nadia-Abdul-Aziz/CART315/blob/main/Process/Media/image.png">

Another design was conceptualized instead of the dog, based on a nude statue of an average man seemingly normal from the front, yet hunched from the side.

<img src="https://github.com/Nadia-Abdul-Aziz/CART315/blob/main/Process/Media/Screenshot_2026-03-02_6.36.57_PM.png">

## The unity 

The unity project has been created and shared, but is currently empty. 

That is essentially all on my end for the week!

# Week 9 - Unity? 

Yeah so basically, we're all gonna just meet up not next weekend, the next one and just crank this baby out like a game jam probably...

# Week 10 - THE STRESS OF PROCRASTINATION HAS ARRIVED AAAAAAAAAAAAAAHHHHHHH

Right, so we have done jack shit this week...I mean that, some stray things here and there but pretty much nothing. The goal I guess is to just crank it out in one weekend a semi-completed prototype as prototype 1, then move to refinement for prorotype 2 prior to the submission deadline and for playtesting. 

You know when you tell yourself you're gonna do something but then you're just like bleeeeeergh and do nothing, yeah so that happened to all of us and here we are, my week went something like this and why should I hide it because it's lowkey funny:

Friday: I need to do the unity thingy

Weekend: I was stupid and did a shrek game jam...but maaaaaaybe I can squeeze in the unity

Monday: I need to do the damn unity

Tuesday: I need to really get my act together and do the unity AAAAAAAA *Stress makes foccacia for bestie*

Wednesday: ??? Random sound thingy ??? huh ???

Thursday morning: *Insert random gurgling noises*...K.O

So yeah, in summary, we are cooked...I am more cooked than an overcooked rotisserie chicken. Sure, i did some sound...but like...

## Soooond

So the current scope includes an outdoor environment with a timeless european aesthetic, so I out of nowhere began sketching the soundscape of the game in anticipation for the true sound design portion. The sfx list may be as follows:

- Trees
- Walking
- Wind
- Street
- Chatter
- Bicycles
- Fountain...if we have one

and maybe a few more, so I was like ok so I have this stupid idea and igt isn't really related to the game but it serves as a good sketch for the sound. so I recorded the atmosphere outside on a zoom H6 and got to work. The sketch is simply the soundscape and the lead is bad MIDI for now. I think it does respect the mood of the game given that we have the progression with multiple levels, but not right now (SEE LINK)

For the ending scene, which we may include, I created a synth patch that captures the notion of being overwhelmed and captures the tension and melancholy of the scene. 

That said, I now have two approaches and I think I prefer the more organic approach for the final product, but may combine both.

## Hooman

So I also began making the NPC models in blender using a plugin called FaceBuilder, it is proving to be a slow but steady process. 

## and that's all my lazy bum accomplished this week

# Final week - Putting it together

This week we actually began shoving things into unity but well i shall keep this short what I did...

- Environment blocking
- Sound finishing
- Fmod?
- Basic interaction system

I essentially gave up on most things since well...we're so behid so we'll likely present this thing without textures and stuff, just basic mechanics.
I opened up the Unity, Alex had done a basic movement system so the first thing I did was implement a head bobbing texture. So that the character feels an up and down motion as they move, it also multiplies with sprinting. 

I then started scattering trees and grass inside the Unity and getting familiar with the landscaping tools, it was some kind of asset package to get the scattering stuff. I had a bit of trouble with the grass and my model wouldn't appear, I still haven't figured it out so I will at some point next week. This is kind of what it looks like at this point and whatever is outside it will become streets.

As mentionned I started importing a few of my own models into the scene and making them interactable, I started on the interaction portion but I gotta wait for Nat to do some UI so I can move on.


My zoom recorder is employed again, some new walking, plants and stuff to be implemented. I watched some tutrials for Fmod but I think it might be out of our scope for the demo so we'll see what we can do, I might just put a few audio listeners. 

# Week...something, more putting it together

So this week we did a lot of very random things...finding out that the showcase isn't the final proved to be very detrimental to us....yeaaaaaah

I did a little bit of texturing as we decided we will not have time to do more.

<img src="https://github.com/Nadia-Abdul-Aziz/CART315/blob/main/Process/Media/Screenshot_2026-03-02_6.36.57_PM.png">

Then I spent a lot of time reworking the narrative structure into something presentable within 5 minutes as our game is much smaller. To illustrate:

__________

(Overhearing)

    PAUL
Back in the day, people just dealt with things you know.
   ELIJAH
Yeaaaah, now everything is all waitlists and forms and everyone’s got some kind of sob story.
    MALCOM
Everyone wants to fucking feel special these days.
   ELIJAH
Mhm, some more than others
    ALL
*Look at MC and Laugh*

___________

(Interact)

   ELIJAH
Hey! Look who’s here!
   MALCOM
Oh wow. We really thought being out and about would not really be your vibe anymore.
    JORDAN
Well…Marissa said you guys were around, so I wasn't expecting you to be so surprised.
   MALCOM
Of course! Relax, don’t make it weird.
    ELIJAH
Drinks are on their way. If that's still your thing.
    JORDAN
Yeah. Thanks.
   PAUL
Marissa's around somewhere.
    JORDAN
I saw her, I think.
   PAUL
Good, you should go see her (smth to signify they’re trying to get rid of him)

___________

(Overhearing)

   PAUL
He used to be easier to talk to.
   MALCOM
Sometimes it's like he wants to be alone.
    ELIJAH
Yeah, you can't really help someone who doesn't want to be helped.
    MALCOM
Or maybe he likes people wondering.
    PAUL
That's harsh.
   ELIJAH
Is it though?

____________

I left myself to do a soundtrack, I might have overdone it and given a full 5 minutes of composition but alas, the more the merrier. It's smashing keys hoping to be jazz.

(Link to sound)

I started working on the animation graphs and modifying animations from mixamo as needed. WE HAVE A WORKING CHARACTER!!!

He is kind of ugly but it doesn't really matter to be honest, it works, we'll see if we are able to texture him in time. Our first npc interaction is functional but the architecture is very crude and Alex will be reworking the code structure.



The actual demo yielded very little feedback since we had very little prepared, it is difficult to reflect on something that barely happened, we essentially treated it as a work period, which is well...not good.
What we did learn is that we have an insane amount of lag when played in editor, we did not realize this beforehand as we were mostly building without running. That is likely something to fix on my part in Blender due to the polycount. 

# Final Reflection

I am unsure what my teammates have submitted, though in the end we did not succeed at creating a playable game. 

## The failure
Firstly I want to reflect upon the idea that these things happen, projects fall through, as this was a prototyping class focused on the reflective elements, we lacked the motivation to finish the actual game. We talked to each other in the last few weeks and ultimately decided that given all our mental health statuses, what we had done was sufficient time spent, and we can complete it over the summer. Past the submission of this journal, we told each other that we would work on it for our own portfolios, but knowing us, we cannot be sure. If we have a github link posted by the time you see this, you are very welcomed to use it!

The prototype we initially outlined was...not much of a prototype and more so a full game. An easy one to implement mechanically, but a huge undertaking nonetheless. Both myself and other teammates are accustomed to the "crunch" or "Game Jam" mindset, and continued to favor that workflow, thus putting a lot of things off and saying "we'll crank it out". We learned that being passionate about the idea, can still mean we can bite off more than we can chew. Seeing team motivation as well as your own decline is truly a killer as the semester goes on. I have had journals where I journaled about doing nothing while my teammates scrambled one singular thing last minute. I feel that I failed the fail-proof, but it happens and is a learning experience to not repeat in the development process of future games.

## What worked & What did not work

When we started, we constantly bounced ideas off each other and were extremely motivated. We quickly learned that given our very adhd patterns, what worked best for us was beign together in the same room and working or talking. We also learned that as we get busier, we will tell each other we will do that...then never actually do it. When we did, we made incredible progress, narratively especially. 

I will speak on behalf of myself first, and my main successes were in 3D and Audio. I had never worked in Unity 3D, and got around the interface quickly given my experience with Blender and UE 3D
My 3D modeling proved to be very productive, I ended up making the following:

- The dog
- A statue
- Coloring and animating 3 NPCs
- 2 Trees
- 2 Clumps of grass
- Bench
- Podium
- Bicycle
- 2 Bike racks
- 2 Building variants

Towards the beginning, when Alex was anticipated to texture them, I learned a lot about UV unwrapping, sure it was a struggle, but it was extremely valuable. Using Mixamo and combining animations within Untiy using the graph was also a tough cookie to crack, but hey I did it, now I know how to do it.

In Audio my feats were the following:

- a FULL 5 minute jazz composition
- Sound effects for all UI elements

Sure, being Jazz was an attempt, but i spent a lot of time learning how to adequately match the mood of the vision we had, which is valuable. The sound effects were very polished, which I am proud of. I began the implementation within a sound manager which is different from my previous workflows of attaching audio to objects. This is a more consolidated way to organize my sounds and will be useful in the sound design of future games. 

# Day 1 (Monday) - Ideation & References

## The Idea

For a while I had a bit of a fixation in that I always wanted to make a metro game, like, a game that took place in a metro car. Nothing too complicated, I honestly wanted to 3D model the thing more than make a game, I always envisioned it as a walkable UE environment. So, right now i’m faced with the task of making something, anything, and reflecting on it, so I guess i’ll try my hand at it. I make something, I make something, I don’t, I don’t. I won't be fixated on finishing it either since I have three other classes to work on this week, however far I get. 

## Refining

My first priority was modeling, so I went down the 2am rabbit hole of looking up all of Montreal’s subway cars…and…maybe got distracted and watched a few documentaries. I looked at the metro photos and like, I’ve taken this thing a thousand times, but if eventually down the line, past this project, I wanted to be accurate, it’s a lot of work, and HARD work. It’s a lot of small details that my skills don’t measure up to yet. So I chose the easier option…the REM. 

Yes yes, not every montrealer has taken the REM but it’s iconic enough to still work. I kinda thought to myself this morning “damn this boi EMPTY” when I took it downtown because it’s simpler, cleaner and just…symmetrical. 

So then I came to play area scoping, how big of an environment. One car, that’s it. My initial vision of course was for there to be dynamic lighting, moving outside, physics, but no. I am making one singular car, and the doors do not open, and I am making outside an HDR. No, I am not arguing with myself, that’s it, this is the effort and time I have.

## Game idea?

Okay so walkable UE environment? Sure, but that requires me to do the nitty gritty modeling…naaaaaaah not on a schedule. Let’s do a medium fidelity model with a slightly more traditional game in Unity for simplicity’s sake. If I end up not being even close to finishing the modeling I can perhaps make the UE after all this. 

A narrative or puzzle game made the most sense, but I cannot model so many objects and make animations and such in this time period. No dialogue, no text, no extra objects, this is hard. Puzzle games often introduce new elements over time and that is a no can do. That said, from those limitations, rather than creating puzzles with new objects, I guess I could create puzzles from the environment already present. Seats, poles, route maps, doors, lights, and announcements could become gameplay elements similar to an Exit 8 type of game with anomalies. 

Exit 8 works for my purposes in that it proves that a small environment can do the job, it contains the following: 

- Repeated space
  
- Observation-based gameplay
  
- Environmental storytelling
  
- Very few mechanics
  
- Atmosphere doing most of the work to be honest

I think using the REM is also a strong choice because it's already slightly liminal with how the colors and elements are arranged, you know, automated announcements, bright clean interiors, repetitive stations and long stretches of quiet travel

## Taking references

I took pictures of a lot of things I thought I would forget, because photos are plenty on the internet. I needed to know exactly how many holders were above the chairs, not how stuff was arranged. I wasn’t really caring about quality, I just wanted to take brain references, not modeling ones. The photos are not pretty or even that functional, they are simply for references. These details are easy to overlook while riding the train, yet they contribute significantly to recreating a believable environment. This process made me realize that reference gathering is not always about accuracy in representation, sometimes it is about capturing the small observations that my monkey brain will discard. The photographs function less as images and more as memory aids that I would toss soon enough. 

# Day 2 (Tuesday) - Modeling & Game Design

## Modeling 

I immediately jumped on modeling because I knew it would be time consuming even if I went fast

I began by modeling the handles, this was fun. My polygon count was absolutely disgusting and I used the decimate modifiers to bring it down. This entire project is a lesson in accepting bad topology for the sake of polycount, it’s brutal. This is a bit of a new workflow since I am going so fast, i have never been this fast. I’ve been modifying the shapes to what I need in geometry, but then most of the time I needed to join pieces together, so I’d have to remesh it, which changes the object’s shape, then smoothing out and fine detailing in sculpting to improve it. This is new, and Anna would probably hate me, but it’s quick and dirty 

Time Spent: 2 Hours
Rigged: Spline
Materials: BSDF and procedural
Tools: Vertex editing, sculpting & remeshing

The seats were significantly faster, it's literally just a flattened cube extruded on X then sculpted, but at some point I just went you know what i'm not going to care about the accuracy of the dent and just make it look believable, so yeah "god forbid" if the dent pattern isn't the same as the original lol

Time Spent: 1 hour
Rigged: No
Materials: BSDF
Tools: Vertex editing, sculpting

I made the vent, which literaly took me 5 minutes, the bigger time waster was figuring out the proportions for the variant (Theres like one vent that sticks out more)

Time Spent: 10 minutes
Rigged: No
Materials: Procedural 
Tools: Vertex editing

All models are prepared and ready for export into Unity. All materials are baked to their respective UV maps 

## Game Design

Thinking more closely about what exactly I wanted to build I eventually settled on a few things.

Genre: Psychological observation puzzle game

The core loop of the game takes place in that singular train car in the following manner: 

- Train arrives at a station (Signaled through sound design)
  
- The intercom announces an instruction and/or environmental cues
  
- Player observes the environment
  
- Player solves a simple environmental puzzle
  
- Train departs (Likely a fade to black with a trajectory visual with sound design)

The game is built around following instructions that don't quite make sense. No combat. No inventory. No dialogue trees. No nothing.

### Puzzle 1: Fallen Pole

Goal: Teach the player that announcements contain puzzle solutions or hints

"Attention passengers. Due to maintenance concerns, please remain seated approximately one meter from the debris."

In this level a pole has fallen from the ground yet everything else apears normal. 

The intended solution involves the player noticing the pole roughly in the middle of the car, and while several seats are nearby in the standard seating arrangement, only one seat is approximately one meter away.

The player must:

- Identify the correct seat
  
- Interact with the seat/sit on it

Only then will the closing door chime trigger and the train departs.

If the player interacts with the wrong seats, nothing happens, perhaps light flickering or something subtle, if the player does not figure out a puzzle after a set amount of time, the announcement repeats. 

Every puzzle should:

- Be solvable through observation
  
- Require simple interact actions
  
- Take under one minute
  
- Use existing train assets

This outline provides me with a clear initial goal for a vertical slice prototype.

# Day 3 (Thursday) - Modeling & Sound design

## Modeling

I spent most of the day on voice chat with classmates doing random stuff, making this door, it was slower than it should have been because I was half paying attention. All in all creating the door's shape was relatively smooth, the challenge was making it sustainable in the case that I wanted it to open at some point, so the sides and main doors could not be attached. 

Time Spent: 3 Hours
Rigged: Yes
Materials: BSDF and procedural
Tools: Vertex editing & remeshing

I did the middle pole, and it took a while to figure out how to join the pieces seamlessly without impacting the geometry so much and distorting the shape, this was not entirely successful since the topology is disgusting, but Unity doesn't care. 

Time Spent: 1 hour
Rigged: No
Materials: BSDF and Procedural
Tools: Vertex editing, remeshing, and sculpting for smoothing

The ceiling poles were made quickly, but they will probably need to be re-proportionned. This has two variants

Time Spent: 5 minutes
Rigged: No
Materials: None yet
Tools: Vertex editing

The session was very usual, nothing that interesting to reflect on per se, I simply wish I wouldn't get caught up in the small details that slow me down. 

## Sound 

The sounds of the REM are private property of the establishment, therefore I have no rights to use this for any public or publishing purposes, but I want the game's audio to be composed from recordings and extracted sounds of the trajectory, that I will eventuall record myself. For now, I have found clean sounds of the REM, including the announcements and chimes, once again, they are not copyright free. I believe that using the diegetic sound of the environment will create an immersive experience, though is a slippery slope. 

I downloaded the chimes and sounds heard in the train, and made a short composition. It can be used as a menu sound, I think. It was pretty fast to make, but designing the synth to be close enough to the original sound was tricky, and definitely doesn't blend yet. 

Again, all this taught me that yes it's good to use diegetic sound, but be mindful when i get to implementation. Using my own recorded versions will certainly be better. 

# Day 4 (Friday) - Unity & Modeling

## Modeling 
The modeling itself wasn't very notable, just pipes, what was is the arranement of the elements. I began laying things out proportionally, or as proportional as I could. 

Time Spent: 1 hour
Rigged:
Materials:
Tools: 

Time Spent: 5 minutes
Rigged:
Materials:
Tools:
## Unity

So I am cursed with controllers. The reason I say this is because I have a tendency to do them...then stop...AAAAAAAAAAAAAAAAH

I made the first person controller based on this tutorial: 

It is very standard, the only thing it would need is bobbing, which I can just steal from the group project at this point. Lesson to keep code to reuse. That said, it was also a very straightforward processs, I've also done it a gajillion times. It sucks that Unity comes with one, but I still have not figured out how to use it, so I make the input system itself and all too. I tried using the controller inputs it comes with, but the data was not being recieved. 

```javascrip
I made a tunnel...yay.

I'll probably do the interactor next. 

Day 5 - Final Reflection

















