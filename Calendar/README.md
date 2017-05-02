
# AtomCalendar
A Simple Calendar control for your Xamarin.Forms projects.

## Screenshot
![CalendarSelectedDate](Images/Calendar-SelectedDate.png){:height="300px" width="250px"}  
![Calendar-TapCommand-1](Images/Calendar-TapCommand-1.png){:height="300px" width="250px"}  ![Calendar-TapCommand-2](Images/Calendar-TapCommand-2.png){:height="300px" width="250px"}  
![Calendar-ItemTemplate-1](Images/Calendar-ItemTemplate-1.png){:height="300px" width="250px"}  ![Calendar-ItemTemplate-2](Images/Calendar-ItemTemplate-2.png){:height="300px" width="250px"}

## Features
  * Easily bind selected Date to other controls.
  * Display selected Date in the form of alert.
  * Differentiate the current date with other dates(i.e Customizable background color).
  * Calendar with Highlighted Days.

## Usage

### XAML:
First add the xmlns namespace:

 xmlns:ns="clr-namespace:NeuroSpeech.UIAtoms.Controls;assembly=NeuroSpeech.UIAtoms"

Then add the control:

 <ns:AtomCalendar/>

Here is a sample:

  ```
 <ns:AtomCalendar x:Name="theCalendar"/>
 <Label 
      HorizontalOptions="Center"
      VerticalOptions="Center"
      Text="{Binding SelectedDate, Source={x:Reference theCalendar}}"/>
 ```
