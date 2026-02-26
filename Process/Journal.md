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




