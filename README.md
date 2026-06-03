# Mixed Reality Test

A mixed reality application that can be used on Meta Quest devices that tests basic UI functions and a grabbable object. This was created as part of my work placement.

## Features
- Cube that can be grabbed
- UI that includes:
-   Slider with text that updates based on slider position
-   Button
-   Toggle

## Technologies Used
- C#
- OpenXR
- Meta XR Interaction SDK
- Meta XR Core SDK
- Unity 6000.0.76f1

## How to Run

### Requirements
- Unity Hub installed
- Correct Unity version installed (Check `ProjectSettings/ProjectVersion.txt`)
- Meta Quest Headset OR XR Simulator

### Setup Steps
1. Clone the repository
```bash
git clone https://github.com/LuigiJ0eYT/MR-but-on-an-older-version.git
```
2. Open Unity Hub
3. Click "Add Project" and select the cloned folder
4. Open the project in the correct Unity version
5. Ensure the following packages are installed:
- OpenXR Plugin
- XR Interaction Toolkit
- Meta XR Interaction SDK
- Meta XR Core SDK
6. Go to: **Edit -> Project Settings -> XR Plug-in Management** and Enable OpenXR for Android/Meta
7. If using Meta Quest:
- Enable Developer Mode on headset
- Connect via USB or Air Link
- Build & Run from Unity **File -> Build Settings -> Android -> Build and Run**
8. If using XR Simulator:
- Make sure it is enabled in Unity
- Press Play in Unity
- Use WASD to move and RF to fly up and down

## Future Improvements
- Add more interactable objects
- Add physics to interactable objects
- Add more features to UI
  
  
