# Theia Wayfinding
<p align="center">
<img src="https://user-images.githubusercontent.com/42556403/198001193-7eb10565-8192-442f-a152-1c9d4a768247.png" alt="icon" width="200"/>
</p>

## Overview
Android/iOS application that utilizes Microsoft Azure Spatial Anchors (ASA) to enable wayfinding in specific environments. Spatial anchors stored in an Azure Resource Group and session sharing enabled with an Azure App Service. 

## Demo/Walkthrough

https://github.com/jonytipton/Theia-Wayfinding/assets/42556403/0761904c-11dc-4d5f-8fc2-22cb17519659

<p align="center"> 
    <a href="https://www.youtube.com/watch?v=RbjGKzxAFFQ">
    <img src="https://user-images.githubusercontent.com/42556403/198002807-c412aeeb-5c9d-4e7c-b4b4-038022945123.png" alt="icon"/>
</p>

## Prerequisites
### Android
- TBD

### iOS
- a macOS machine with the latest version of [Xcode](https://geo.itunes.apple.com/us/app/xcode/id497799835?mt=12) and [Unity (LTS)](https://unity3d.com/get-unity/download) installed. Use **Unity 2020.3.17 LTS** with ASA SDK version 2.10.2 or later (which uses the [Unity XR Plug-In Framework](https://docs.unity3d.com/Manual/XRPluginArchitecture.html)).
- Git installed via [HomeBrew](https://brew.sh). Enter the following command into a single line of the Terminal: <br />
```/usr/bin/ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)"``` <br />
Then, run ```brew install git``` and ```brew install git-lfs```
- A developer enabled [ARKit compatible](https://developer.apple.com/documentation/arkit/verifying_device_support_and_user_permission) iOS device


## Installation
- Clone TheiaWayfinding repository into a new directory
- [Download the ASA packages](https://docs.microsoft.com/en-us/azure/spatial-anchors/how-tos/setup-unity-project?tabs=unity-package-web-ui#download-asa-packages) for import into Unity. Or **use the commands below at root of directory:**
    - Core
      - ```npm pack com.microsoft.azure.spatial-anchors-sdk.core@2.12.0 --registry https://pkgs.dev.azure.com/aipmr/MixedReality-Unity-Packages/_packaging/Unity-packages/npm/registry/```
    - Android (required for Android build)
      - ```npm pack com.microsoft.azure.spatial-anchors-sdk.android@2.12.0 --registry https://pkgs.dev.azure.com/aipmr/MixedReality-Unity-Packages/_packaging/Unity-packages/npm/registry/```
    - iOS (required for iOS build)
      - ```npm pack com.microsoft.azure.spatial-anchors-sdk.ios@2.12.0 --registry https://pkgs.dev.azure.com/aipmr/MixedReality-Unity-Packages/_packaging/Unity-packages/npm/registry/```

## Build/Run
### Setup Unity Project
- **Add TheiaWayfinding folder to Unity Hub and open project.** Unity might prompt you about a difference between the version in the project and the version that's installed on your machine. This warning is okay, as long as your version of Unity Editor is newer than the one that the project was created with. If your version is newer, select Continue. If your version is older than the one the project needs, select Quit, and upgrade your Unity Editor. 
- [Import all downloaded ASA packages into Unity](https://docs.unity3d.com/Manual/upm-ui-tarball.html) 
- Open **Build Settings** by selection **File > Build Settings**
- In the **Platform** selection, select desired target platform (Android or iOS)
- Drag all scenes from the Unity **Project** pane into the **Scenes In Build** section of **Build Settings**
    - **HINT**: type "t: Scene" into search bar of **Project** pane to show all scenes in project 

### Configure Azure Account Information
- In the **Project** pane, go to ```Assets/AzureSpatialAnchors.SDK/Resrouces```
- Select **SpatialAnchorConfig**. In the **Inspector** pane, enter the ```Account ID``` as the value for **Spatial Anchors Account Id**, ```Account Key``` as the value for **Spatial Anchors Account Key**, and the ```Account Domain``` as the value for **Spatial Anchors Account Domain**
- In the **Project** pane, go to ```Assets/AzureSpatialAnchors.Examples/Resources```
- Select **SpatialAnchorSamplesConfig**. In the **Inspector** pane, enter the ```App URL``` as the value for **Base Sharing URL**
    - **HINT**: See TheiaWayfinding [shared drive](TODO) for ```Account ID```, ```Account Key```, ```Account Domain```, and ```App URL``` values

### Android Deployment
- TBD

### iOS Deployment
- Open **Build Settings** by selecting **File** > **Build Settings**.
- Under Scenes In Build, ensure that each scene has a check mark next to it.
- Select Build. On the pane that opens, select a folder to export the Xcode project to.
- When the export is complete, a folder that contains the exported Xcode project appears.
#### Open the Xcode project
- Now you can open your ```Unity-iPhone.xcodeproj``` project in Xcode.
- You can either launch Xcode and open the exported Unity-iPhone.xcodeproj project or launch the project in Xcode by running the following command from the location where you exported the project: ```open ./Unity-iPhone.xcodeproj```
- Select the root Unity-iPhone node to view the project settings, and then select the General tab.
- Under **Deployment Info**, make sure that the deployment target is set to iOS 11.0 or newer.
- Select the Signing & Capabilities tab and make sure that Automatically manage signing is enabled. If it's not, enable it, and then reset the build settings by selecting Enable Automatic on the pane that appears.
- Select the Team drop-down and either select a current account or add a new one using an Apple ID
- Set Bundle Identifier to be "com.FirstnameLastname" (i.e. com.JonSmith)
- Remove the in-app purchase add-on at bottom of page
### Deply the app to your iOS device
- Connect the iOS device to the Mac, and set the active scheme to your iOS device.
![Image of Xcode menu bar](https://docs.microsoft.com/en-us/azure/includes/media/spatial-anchors-unity/select-device.png)
- Select **Build** and then run the current scheme.<br/> 
![Image of Play icon in Xcode menu bar](https://docs.microsoft.com/en-us/azure/includes/media/spatial-anchors-unity/deploy-run.png)
<br/>
- Once the app is installed on your iOS device, enable developer mode by opening Settings -> General -> VPN & Device Management -> Select the Not Trusted Developer App -> Tap Trust
- Relaunch app from Xcode, future applications will now install and run with developer access

- With Create & Share Anchor, you can create an anchor and save it to your sharing service. In return, you will get back an identifier for it that you can use to retrieve it from the sharing service. You can then run the second scenario, Locate Shared Anchor, from either your device or a different one.
- With Locate Shared Anchor, you can locate previously shared anchors by entering the identifier mentioned earlier. After you pick your scenario, the app will guide you with further instructions. For example, you'll be asked to move your device around to collect environment information. Later on, you'll place an anchor in the world, wait for it to save, start a new session, and then locate it.

## References
- Microsft ASA [quickstart guide](https://docs.microsoft.com/en-us/azure/spatial-anchors/unity-overview) for sample instructions.
- Micrsoft ASA [Tutorial: Shared spatial anchors across sessions and devices](https://docs.microsoft.com/en-us/azure/spatial-anchors/tutorials/tutorial-share-anchors-across-devices?tabs=azure-portal%2CVS%2CAndroid)
