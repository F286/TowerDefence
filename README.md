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
