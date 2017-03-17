# VirtualInput

Creates ingame keys that can be modified during runtime for Unity3D. Gives the ability to bind and unbind physical keys to virtual keys.

## How-to-use

First include the namespace VirtualInput.

```cs
using VirtualInput;
```

To create a Virtual Key

```cs
VInput.CreateVKey(new VKey("forward"));
```

To add physical keys to the virtual key

```cs
// Bind
VInput.BindKey(KeyCode.W, "forward");
VInput.BindKey(KeyCode.UpArrow, "forward");

// Unbind
VInput.UnBindKey(KeyCode.UpArrow, "forward");
```

Lasly, to check if a key is being pressed

```cs
// Return true if the key is being held down
VInput.GetKey("forward");

// Return true if the key was just pressed down
VInput.GetKeyDown("forward");

// Return true if the key was just released
VInput.GetKeyUp("forward");
```
