# Face-Cap-OSC-Receiver-Example
for kenzyakato's VRchat avatar face tracking
## What you need to prepare 
[iFacialMocap](https://www.ifacialmocap.com/download/)  
[Unity 2019.4.31f1](https://unity3d.com/get-unity/download/archive)  
An avatar ready for　PerfectSync. If you don't have one, I recommend using the tool below to make one.  
[HANA_APP](https://booth.pm/ja/items/2917742)  
## This is a Unity project used to implement VRchat face tracking.  
The animator and animation files used for Avatar, as well as the parameters and menus used by Avatar 3.0, are in the **Asset/AvatarSetUp/** folder.  
Replace the **Base** and **FX** of avatar's **Playable Layers**, **Menu** and **Paramaeters** of **Expressions** with the corresponding files in **AvatarSetUp**.  
Then all you have to do is open the scene "**workSecen**" and start **iFacialMocap**, run the secen.  
### Tips  
If you don't have a PerfectSync avatar, you can also modify the corresponding animation in **/Asset/AvatarSetUp/Animation/** to the BlendShape your avatar has.
