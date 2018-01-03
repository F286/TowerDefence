# Core Framework

This is the Core Framework that has evolved as I have developed Unity apps. Major features include:

- Trigger Action System
- Folder Structure split based on modules of functionality, to allow scaling to multiple apps.
- Unified input system for menus and game, using Unity's built in EventSystems
- Uses as many of Unity's built in solid features as possible, for example UnityEvents.
- Contains example of an editor script to order sprites in the scene. This approach be powerful. (CORE_SpriteManager)
- Set up to avoid common issues we have run into over the last several years.

## Script naming convention

Prefixes are used to separate code into different areas based on it's use case.
- SCR_ is *content code*. It can be coded relatively quickly and is specific to a game.
- CORE_ is *framework code*. It is shared between projects therefore needs to be more robust and resuable.
- TRIGGER_ is for Triggers. A class that implements from ITrigger.
- ACTION_ is for Actions. A class that implements IAction.

# Development Process

## Overview 

- Important to have a good atmosphere : )

- Important to have an open atmosphere. That is, an atmosphere of open conversation about how
code is structured and ways of accomplishing tasks.

## Prototyping

When developing apps professionally as a general framework we create scenes in three phases. *Prototype, Build, and Polish*.

1. Define the *Target Goals* for a prototype

2. Prototype in Unity, exporting to the iPad. It is important to iterate, and hit all Target Goals *simultaneously*. *Test with kids!*

3. Build the app based on the prototype. *Test with kids!*

4. Polish the app, tweaking the graphics, interactions and minor bugs once we have a releasable app.

## Best Practices

### You can drag a prefab into a scene, and it just works.

Easier to test in Editor, a prefab can be tested by simply
dragging it into the scene.

- Simplifies object creation - GameObject.Instantiate() just works!

- Easier for code to work with *Edit and Continue*, where I can
rapidly iterate by editing code while the Editor is in Play Mode.

### Content can be created and edited in the Unity Editor without code

- Allows Designers to work in the Unity Editor directly

- Allows Designers to be productive with less back and forth with
Programmers

- Easier to scale content creation to a large project

- Most data is stored on prefabs as public fields

- *Example:* An Designer can create a new Block from scratch by
creating a prefab, and create the graphics for it without back
and forth with a programmer

### Leverage Unity, go with the grain

- Public fields in the Unity Inspector should be used to hook up
references between objects. This is easy to inspect and debug.

- All object state should be viewable though the inspector, you
can then click on GameObjects while in Play Mode and debug
and experiment easily. There are tricks such as using
[Serializable] structs which allow for inspectable sub-objects.

- Unity’s built-in functionality is very consistent across platforms,
so it will lead to less bugs when targeting new platforms.

### KISS: Keep it super simple

- Advanced language features such as Reflection have inconsistent
behaviour across platforms, since the code is auto-translated,
which can lead to bugs which occur only on device which are very
painful.

- Plugins are good if not too invasive, or there is a strong need that
is not possible with built-in functionality (Example: DOTween,
Android native functionality)

- Keep number of lines of code as few as possible, as more code
will lead to more bugs and is harder to maintain

- Don’t over structure code. It’s good to keep state as public fields.

### Final Thoughts

- It is important to not get too attached to a specific way of doing things. Always try and investigate new ways of doing things in Unity. Try embracing Unity to start, then feel free to modify from there. Cheers : )
