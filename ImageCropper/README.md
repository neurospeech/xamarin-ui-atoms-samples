# AtomImageCropper
AtomImageCropper is a useful image cropping control for Xamarin.Forms projects.

## Screenshot
![Image-Cropper-1](Images/Image-Cropper-1.png)  ![Image-Cropper-2](Images/Image-Cropper-2.png)

## Features
 * Zoom In and Out feature
 * Adjustable CropAspectRatio.
 * Maintains Image clearity.

 ## Usage

### XAML:
First add the xmlns namespace:

 xmlns:ns="clr-namespace:NeuroSpeech.UIAtoms.Controls;assembly=NeuroSpeech.UIAtoms"

Then add the control:

 <ns:AtomImageCropper Source="..."/>

Here is a sample :

 ```
 <ns:AtomImageCropper
            x:Name="cropper"
            Source="app-res:///AppImages/Milkyway.jpg"
            CropAspectRatio="0.667"/>
 ```