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