# AtomGridView
AtomGridView is a control that displays items in a two-dimensional grid for Xamarin.Forms projects.

## Screenshot
<img src="Images/GridView.png" width="250" height="425">

## Features
  * Grid view with header support.
  * Easy customizable layout.
    
## Usage

### XAML:
First add the xmlns namespace:

 xmlns:ns="clr-namespace:NeuroSpeech.UIAtoms.Controls;assembly=NeuroSpeech.UIAtoms"

Then add the control.

Here is a sample:
```
  <ns:AtomGridView ItemsSource="{Binding Videos}" Padding="10">
        <ns:AtomGridView.ItemTemplate>
            <DataTemplate>
                    <ns:AtomImage
                            ShowProgress="True"
                            Source="{Binding Thumbnail}"/>
            </DataTemplate>
        </ns:AtomGridView.ItemTemplate>
  </ns:AtomGridView>
```
