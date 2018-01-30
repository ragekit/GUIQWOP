30/01/2018
------

I made roxanne play the prototype today which helped me detect some bottlenecks. The water module is still too complicated to use but rather than balance it too soon, I wanted to add all the UI widget needed to have a feature complete prototype. Everything is in but noew, but non functional yet. Next step, make everything functional and resume testing and balancing.

I also changed the temperature node, which was too complicated to use. Sometimes it could be impossible to set the correct temperature which would be unfair instead of unusable. Now the temperature is selected by clicked 8 buttons that represents the 8 bits of the temperature, with max at 100.


TODO week 2
-----

- [X] new temperature node
- clean water node
- select tea node
- brew time node
- super user nodes
- balance modules (heavy testing).
- improve the instructions/feedback system



Test notes
------
- [X] The "feedback" gauges looks too much like input, correct that (with colors maybe). 
- The add water module is still a bit too hard to use. Maybe add just a litle bit of feedback.
- input/output sidget like the slowly decreasing power bar should show more that they can still be usable.


27/01/2018
-------

Today I finished working on the temperature module and worked toward the 1st week testable prototype.

I made the temperature module not mandatory to figure out to finish. This mean that all input in this module is accepted and won't make the ui fail and enter the reset mode.

I think having only the first module failable is interesting, but having other modules further that fail might be too frustrating if all the time you need to come back to the start. Maybe there should be "checkpoints" that you come back to if you fail, so you don't have to start all over again, and the game is divided into multiple stages.

I also implemented an instruction and feedback system (that only works for the temperature module for now). You are asked to brew a specific type of tea and you get feedback from the person who ordered it. This is a less frustrating failure, that can also be humorous ("what, this tea is cold ?! And it's not even tea it's woodchips !"), and might push players to play with the UI to figure out what they did wrong, and understand what module does what through the feedbacks.

Maybe instead of being sequentials, module should interact between each other. Like, the temperature module could make the add water module change a bit. Or a random module that does not set some data, but change it on several module at once, just to confuse the player. (that could be seen as a metaphor for "Super users" functions that set multiple things at once but confuse the novice, kind of like a Vim shortcut for a teapot).

Also exploring how to make the different stages of the prototype playable so commits, but also prototype could be quotable by THE METHOD.

Right now I'm tagging certain commit with build."nameofthebuild" , so for instance, build.week1 for this week. I upload them in a secondary repo called GUIQWOP-build for now, to not add too much unecessary heavy files to the main repo. Maybe this could be standardised further if this is usefull.

So : the first week prototype is available here https://ragekit.github.io/GUIQWOP-builds/Week1/

26/01/2018
-------

I tested today with Pippin and he did not go past the first add water module. It is interesting to note that changing its difficulty dramatically was just a matter of changing a boolean operator in the code. 

I think this is a proof that there is a "design by doing" that is often overlooked by more standard academic practices. 

Maybe I'm the one at fault here, but I often try to overdesign, and intelectualize how a design will behave. And once it is locked in my head, then I implement it. 

Of course this fails because I can not anticipate, however hard I try, what will happen when someone play my games. Evenmore, why would I design it if answers were known beforehand ? And usually, I lack the time to do proper playtest and my game get frozen in that state, that has potential, but poor realizations.

But once you've got a prototype going, it is easy to change a couple variable there and there, and this can drastically change the experience of your game. I'm slowly learning that going for a fast bad but playable version, even if your concept is still blurry in your head, and then working from there, is the best way to do research creation.

In term of process, for The Method, I'm wondering if it would not be better to use the built in github-pages. It uses markdown, so it would be the same workflow, but in a more " user friendly " readable way.

Also It might be interesting to tag certain commit, when a playable version is done, so they can be fetched easily and a collection of "progression prototypes" can be played. Maybe as part of the github-pages website ?

25/01/2018
---------

Oh no I forgot to write a process diary for the first day of work. So now it is time to catch up.

This first 10h week is focused around fast prototype of a "GUI QWOP" so an interface that is unintuitive and hard to use.

The main idea is to use the same concept as QWOP and divide a simple action : make tea, into sub actions and design a difficult to use GUI widget for all of them.

I first started to make a very quick list of all the atomic widgets I could use (pressed button, circular slider, linear slider and the like), and made a mockup of all the actions needed to brew the tea, with some ideas on how to make a widget for each.

I started prototyping them and after 5h I have a first idea "mis en scene" and I had it tested by Enric. It works pretty well but I think it is still too easy. Though I think complications will be added once several new widgets are introduced. 

I allready changed slighly one module to make it slighly more complicated and it seems to be more interesting.

Enric suggested that I could add feedback or things to use simultaneously that are NOT nearby each others. I will test that next.

Onwards !
