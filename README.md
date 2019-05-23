# 07-Glitch-Garden
In this section we create a lane-based Tower Defense game modelled on the iconic Plants Vs Zombies game. We cover a lot of Unity's animation system, a resource management mechanic, specialised enemy types and more. This repo is part of our Complete Unity C# Developer 2D course (http://gdev.tv/cudgithub). (Ref: GL_CUD)

# Complete Unity Developer 2D - Glitch Garden

This is the [Complete Unity Developer](http://gdev.tv/cudgithub) - one of the most successful e-learning courses on the internet! Completely re-worked from scratch with brand-new projects and our latest teaching techniques. You will benefit from the fact we have already taught nearly half a million students game development, many shipping commercial games as a result.

You're welcome to download, fork or do whatever else legal with all the files! The real value is in our huge, high-quality online tutorials that accompany this repo. You can check out the course here: [Complete Unity Developer](http://gdev.tv/cudgithub)

## In This Section

In this section we create a lane-based Tower Defense game modelled on the iconic Plants Vs Zombies game. We cover a lot of Unity's animation system, a resource management mechanic, specialised enemy types and more. This repo is part of our Complete Unity C# Developer 2D course (http://gdev.tv/cudgithub). (Ref: GL_CUD)

## How To Build / Compile

## Lecture List

Here are the lectures of the course for this section.


### 1 Welcome To Glitch Garden ###

**In this video (objectives)...**

1. Overview of this section.
2. Demo of the game prototype.

**After watching (learning outcomes)...**

Ready and raring to start this section.


### 2 Glitch Garden Game Design ###

**In this video (objectives)...**

1. Discussion of game overview screen and core features.
2. Demo of the game prototype.


**After watching (learning outcomes)...**

Super clear on the game we are making.

### 3 Make A Splash Screen ###

**In this video (objectives)...**

1. Get assets from the Glitch game site.
2. Set up a Splash Screen and Start Screen.
3. Implement a level loader that waits then loads the start screen.


**After watching (learning outcomes)...**

Create a splash screen with delayed level loading.


### 4 Scaling & Aspect Ratios ###

**In this video (objectives)...**

1. Set up our safe zone for a variety of aspect ratios
2. Anchor our text to ensure that no matter what aspect ratio is used, our text is still on screen.


**After watching (learning outcomes)...**

Set up a mobile-friendly game that response gracefully to different shape devices.


### 5 Set Up Background Playspace ###

**In this video (objectives)...**

1. Calculate the size of our safe zone.
2. Create level scene.
3. Calculate size of our grids.


**After watching (learning outcomes)...**

Prep our playspace so we are ready to create background art.


### 6 World Space Canvas Mode ###

**In this video (objectives)...**

1. Change our canvas to world space.
2. Calculate size of canvas and character.
3. Add nicer looking background and tree art and play with order in layer to get depth effect.


**After watching (learning outcomes)...**

Use World space canvas mode to match your UI size with world units.


### 7 Intro To Animation ###

**In this video (objectives)...**

1. Discuss sprite sheet versus bone based animation.
2. Download assets, import sprite sheet and slice up sprite sheet.


**After watching (learning outcomes)...**

Able to slice up sprite sheets to use for animation.


### 8 Animator Controller & Animation ###

**In this video (objectives)...**

1. Create a new Game Object with sprite renderer and Animator Component.
2. Create an animator controller.
3. Create a new walk animation and hook everything up.


**After watching (learning outcomes)...**

Able to render an animation in game using Animator Controller and animations.


### 9 Basic Animation Transition ###

**In this video (objectives)...**

1. Import and slice up a new animation for our character.
2. Use Grid by Cell size to slice up.
3. Add new animation and animation transition and fix any issues we might find.


**After watching (learning outcomes)...**

Transition from one animation state to another once the first animation is finished playing.


### 10 Intro To Keyframe Animation ###

**In this video (objectives)...**

1. Create a new game object with 2 independently moving parts.
2. Use keyframe animation to animation transform, scale, rotation and colour.


**After watching (learning outcomes)...**

Animate an object using Keyframe animation.


### 10b A Note About Animation ###

**In this video (objectives)...**

1. Dont do too much just yet.
2. Always put scripts and animator at parent level.


**After watching (learning outcomes)...**

Making sure that we dont lose too much work when we refactor later on.


### 11 Move Using transform.Translate ###

**In this video (objectives)...**

1. Create attacker.cs script.
2. Use transform.Translate and the concept of "left" to move in the -x direction.


**After watching (learning outcomes)...**

Move Game Objects using transform.Translate.


### 12 Spawn Attackers Using Coroutine ###

**In this video (objectives)...**

1. Instantiate attackers at intervals within a random range.
2. Use a coroutine to continue spawning attackers.
3. Create a spawning bool that allows us to stop the attacker spawning when needed.


**After watching (learning outcomes)...**

Spawn attackers along their lanes using coroutine.


### 13 Adding Animation Events ###

**In this video (objectives)...**

1. Add animation event to our timeline.
2. Create a public method that is called when the timeline reaches that animation event.


**After watching (learning outcomes)...**

Call methods in our code by adding animation events to our animation timeline.


### 14 Set Up A Defender Prefab ###

**In this video (objectives)...**

1. Slice up sprite sheets, create multiple animation, create animator controller.
2. Add an animation event and some visual flare for when we want the character to shoot.


**After watching (learning outcomes)...**

Set up the animation, animator controller and event for a defender.


### 15 Instantiate From Gun Position ###

**In this video (objectives)...**

1. Clarify why we see different function options for animation events.
2. Create a method for instantiating a project.
3. Create a gun child and instantiate from the gun position.


**After watching (learning outcomes)...**

Instantiate a projectile from a child object such as a gun.


### 16 Make Projectile Move ###

**In this video (objectives)...**

1. Compare animating projectile using animator versus code.


**After watching (learning outcomes)...**

Animate projectile using both animator and code.


### 17 Health & Hurting Attackers ###

**In this video (objectives)...**

1. Create a list of requirements for our health / damage system.


**After watching (learning outcomes)...**

Confident in auditing your project to figure out requirements for our health system.


### 18 Implementing Health & Damage ###

**In this video (objectives)...**

1. Create a trigger event with correct collider and rigid bodies.
2. Decrease health by calling a public method of DealDamage() and passing in damage amount.
3. Snuff out the attacker when its health reaches zero.


**After watching (learning outcomes)...**

Implement system where projectiles do damage and kill attackers.


### 19 Tidy Up & Death FX ###

**In this video (objectives)...**

1. Destroy projectiles when they hit targets.
2. Instantiate particle effect when attacker is destroyed. Then destroy the particle effect itself.


**After watching (learning outcomes)...**

Instantiate and then destroy particle effects.


### 20 Click To Spawn Defenders ###

**In this video (objectives)...**

1. Add a core game area with collider and SpawnDefender script.
2. Instantiate a defender when the mouse is clicked.


**After watching (learning outcomes)...**

Instantiate a defender at the (0,0) point when the player clicks the mouse.


### 21 Spawn At Mouse Position ###

**In this video (objectives)...**

1. Use ScreenToWorldPoint to identify where the mouse is clicked in relation to our play space.
2. Investigate the relationship between methods with return types and methods with arguments.


**After watching (learning outcomes)...**

Instantiate a defender where the mouse pointer is currently located.


### 22 Snap Defenders To Grid ###

**In this video (objectives)...**

1. Use RoundToInt() to round our decimal places to whole numbers.
2. Create a SnapToGrid() method which can then be used to return our final position for defenders.


**After watching (learning outcomes)...**

Snap our defenders to the grid using RoundToInt().


### 23 Create Defender Selection UI ###

**In this video (objectives)...**

1. Create background and icons for our buttons.
2. Implement a mouse over event that changes a button from greyed out to white.
3. Use a foreach loop to cycle through all other buttons to make them black.


**After watching (learning outcomes)...**

Implement a button selection UI.


### 24 Set & Place Selected Defender ###

**In this video (objectives)...**

1. Assign a defender prefab to each button click.
2. Pass in the button's defender prefab by using a public method on DefenderSpawner.


**After watching (learning outcomes)...**

Place the appropriate defender prefab in the world when the corresponding button is clicked.


### 25 Start Our Resource System ###

**In this video (objectives)...**

1. Create StarDisplay.cs and create a variable to store current resources.
2. Use ToString() to convert our integer into a string to display in our text field on screen.
3. Create public methods for future use that will allow us to increase and decrease stars.


**After watching (learning outcomes)...**

Create a resource system for adding and spending resources.


### 26 Parent, Child & Animation ###

**In this video (objectives)...**

1. Explore the relationship between parent game objects, their children and how that impacts animation.
2. Set ourselves the challenge to tidy up our animations.


**After watching (learning outcomes)...**

Be clear on how the parent-child relationship impacts animation.


### 27 Completing Animation Challenge ###

**In this video (objectives)...**

1. Set up Lizard and Cactus with proper parent-child relationship.
2. Adding Animator, animation clips, animation events.


**After watching (learning outcomes)...**

Feeling confident with how the animation system works.


### 28 Add Resources As Anim Event ###

**In this video (objectives)...**

1. Add anim event which calls a public method which also calls another public method.
2. Create a nifty animation to visual the resource being added.


**After watching (learning outcomes)...**

Call a public method with our animation event which adds resources.


### 29 Defenders Costing Resources ###

**In this video (objectives)...**

1. Create a method that returns a bool for whether we have enough resources to buy a defender.
2. On mouse click, spawn a defender and also reduce our total resources by the cost of the defender.


**After watching (learning outcomes)...**

Tie everything together so that clicking to place defenders costs resources.


### 30 Searching For Animation Events ###

**In this video (objectives)...**

1. Locate where animation events are calling specific functions using the Find and Replace tool in Visual Studio.


**After watching (learning outcomes)...**

Easily find where functions are being called in animation events.


### 31 Instantiate As Child ###

**In this video (objectives)...**

1. Instatiate our attacker as an Attacker game object.
2. Change the instantiated object's parent to be the object which spawned it.


**After watching (learning outcomes)...**

Change the parent of an instantiated object.


### 32 Attacker In My Lane ###

**In this video (objectives)...**

1. Create an array to store each of the Attacker Spawners.
2. Create a mechanism to shoot or not shoot based upon whether we have an attacker in our lane.


**After watching (learning outcomes)...**

Detect if an attacker is spawned by looking at child count of spawner in our lane.


### 33 Change Animation State ###

**In this video (objectives)...**

1. Set up our animator controller with idle and attack animations.
2. Create an animation parameter that we can use as a transition condition.
3. Change the animation state in our shooter script.


**After watching (learning outcomes)...**

Change a character's animation state in code.


### 34 One Defender Per Square ###

**In this video (objectives)...**

1. Prevent multiple defender placement per square.
2. Create a new projectile - the axe.


**After watching (learning outcomes)...**

Tidy up our project including preventing multiple defenders being placed on one square. And, you know, a few other nifty things.


### 35 Creating Gnome Defender ###

**In this video (objectives)...**

1. Go through the laundry list of steps to create a gnome character so that it animates, shoots, transitions and can be purchased and placed in the game.


**After watching (learning outcomes)...**

Reinforce all the steps in creating a character by creating a new shooting character.


### 36 Creating Gravestone Defender Race ###

**In this video (objectives)...**

1. Create a non-shooting defender that will block attackers.


**After watching (learning outcomes)...**

Enjoy all the thrills of racing Rick to create a new defender type.


### 37 Make Our Attackers Attack ###

**In this video (objectives)...**

1. Create a new attack animation for our Lizard.
2. Create attack method and collision event to change animation state.


**After watching (learning outcomes)...**

Transition our attacker's animation state to attacking when they collide with a defender.


### 38 Attackers Striking Target ###

**In this video (objectives)...**

1. Create StrikeCurrentTarget() method that can be called as animation event.
2. Update animation to continue walking after target is killed.


**After watching (learning outcomes)...**

Make our attackers capable of harming defenders.


### 39 Fantastic Mr Fox ###

**In this video (objectives)...**

1. Add a fox with all its bits and pieces.
2. Create a fox component which will have different behaviour to the Lizard.
3. Create a Gravestone class to give our Gravestone some behaviour.


**After watching (learning outcomes)...**

Create a fox with unique Attacker behaviour.


### 40 Array For Spawning Attackers  ###

**In this video (objectives)...**

1. Create an array for spawning attackers.


**After watching (learning outcomes)...**

Create, you know, an array... for spawning attackers.


### 41 How To Be A Loser  ###

**In this video (objectives)...**

1. Create player lives and a way to decrease those lives when an attack reaches our base.
2. Create a placeholder You Lose screen which we load when lives reaches zero.


**After watching (learning outcomes)...**

Create a system for the player to lose and load a Lose Screen.


### 42 Create A Level Timer  ###

**In this video (objectives)...**

1. Add a slider to represent time left in the level.
2. Animate the handle for the slider
3. Print a statement to console when the slider reaches its destination.


**After watching (learning outcomes)...**

Create an animated level timer.


### 43 Create A Level Controller ###

**In this video (objectives)...**

1. Create a mechanism for monitoring when all attackers are destroyed.
2. Create functionality to take action when there are no attackers and timer has finished.


**After watching (learning outcomes)...**

Create a game controller that coordinates the victory conditions for a level.


### 44 A Nicer Win Experience ###

**In this video (objectives)...**

1. Create Level Complete text which we can toggle on and off.
2. Add SFX and level loading to a coroutine that is triggered when the level is won.


**After watching (learning outcomes)...**

Bring joy and happiness to our player when they complete a level.


### 45 A Nicer Lose Experience ###

**In this video (objectives)...**

1. Add a You Lose popup which gives the player options to restart the level or quit to main menu.
2. Stop the game speed when the popup is on screen and return to normal speed when the game resumes.


**After watching (learning outcomes)...**

Bring joy and happiness to our player when they crash and burn.


### 46 Handling Null Reference Exceptions ###

**In this video (objectives)...**

1. Why is the null reference exception happening.
2. Fixing our current errors by preventing code from executing if null.


**After watching (learning outcomes)...**

Fix our null reference exceptions.


### 47 Start Our Options Screen ###

**In this video (objectives)...**

1. Add the images, sliders and buttons for our Options screen.


**After watching (learning outcomes)...**

Add the images, sliders and buttons for our Options screen.


### 48 PlayerPrefs To Save Settings ###

**In this video (objectives)...**

1. Create a PlayerPrefsController wrapper class to store all of our PlayerPrefs keys.
2. Create a public setter and public getter method to set our master volume.


**After watching (learning outcomes)...**

Create the mechanism for setting and getting volume.


### 49 Set & Save Music Volume ###

**In this video (objectives)...**

1. Use our PlayerPrefs functionality to connect the volume slider level with the saved volume level.
2. Change level on the fly, use defaults button and save on exit for volume levels.


**After watching (learning outcomes)...**

Use PlayerPrefs and UI sliders to alter and save music volume levels.


### 50 Add Difficulty Levels ###

**In this video (objectives)...**

1. Implement our PlayPrefs setting and getting for difficulty.
2. Audit our gameplay and design a place where we can change difficulty.


**After watching (learning outcomes)...**

Use PlayerPrefs and UI sliders to alter the difficulty of gameplay.


### 51 Quick Bug Fix - Win Condition ###

**In this video (objectives)...**

1. Problem - if we have our lives set to greater than 1 we have a bug where if we lose some life and then the timer runs out, the game does not finish.


**After watching (learning outcomes)...**

Go bug hunting and smashing!


### 52 Tidy Hierarchy = Tidy Mind ###

**In this video (objectives)...**

1. Parent our defenders and projectiles to a parent object to keep our hierarchy tidy.
2. Check if game object already exists, if not then create a new one.


**After watching (learning outcomes)...**

Keep our hierarchy tidy by childing game objects when instantiated.


### 53 Tuning Our Core Gameplay ###

**In this video (objectives)...**

1. Create a tuning matrix for our defenders and attackers and implement the values back into our build.


**After watching (learning outcomes)...**

Tune our defenders and attackers.


### 54 Add Star Cost To Button ###

**In this video (objectives)...**

1. Add a canvas to our button game object.
2. Add text, scale it, then use GetComponentInChildren<> to access the text field and update it from the defender prefab.


**After watching (learning outcomes)...**

Implement dynamic UI which shows the player the cost of defenders.


### 55 Creating Level Progression ###

**In this video (objectives)...**

1. Create a blank level template that we can build our levels upon.
2. Discuss game design for making interesting progression.
3. Big challenge - make your game!


**After watching (learning outcomes)...**

Understand how to create level progression for our player.


### 56 Glitch Garden Wrap Up ###

**In this video (objectives)...**

1. Final words for this section.
2. Also, repo has been updated with Rick's 5 levels.


**After watching (learning outcomes)...**

Wrap up and update of repo with Rick's 5 levels.