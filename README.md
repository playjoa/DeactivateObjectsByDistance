# DeactivateObjectsByDistance

### Why use this?
- In some cases you might have big scenes and a lot going on.
- For example having a big level with collectables and power ups.
- Those objects might contain particle effects and some other graphics effects.
- And at a certain distance might not be worth it to keep them rendering and using GPU.
- So just let them be visible at certain distance from the player.
- This is a very easy approach to solve this problem.

### How to use:

- Attach this to an object that has child with graphics and effects!
- The object with this script will be used to reference distance to target (player).
- Reference these objects in <em>objects</em> array.
- Reference the Transform target (Probably your player avatar in scene).
- Choose a distance that you want your objects to deactivate.
- There you go :D

