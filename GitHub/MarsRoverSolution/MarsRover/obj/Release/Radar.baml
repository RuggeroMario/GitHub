   M S B A M L   `   `   `  ����   	MarsRover    MarsRover.Radar   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Mission to Mars��$	��850��$
��1100�� � WindowStartupLocation$ CenterScreen=� � 	Resources    	MarsColor��%   &	        ��	#FFEEB990��.��]� .+�� -    �Name$ 	radarGrid��$
��Left=� � ShowGridLines . $
��Left=�$	��900��$	��800������  �� Color# �    � ColumnDefinitions �� �� �� �� �� �� �� �� �� ��  � RowDefinitions �� �� �� �� �� �� �� �� �� � $��Right=�$	��190��$��Right=�.+��� -   $��LocateButton��$��Locate Rover Machine��$��Center=�$	��Top=�$	��170��$��50��$��5,50,5,5q�$��0���� -   $��TurnToLeftButton��$��	Turn Left��$	��Top=�$��80��$��50��$��4,150,100,0q�$��1���� -   $��TurnToRightButton��$��
Turn Rigth��$	��Top=�$��80��$��50��$��100,150,4,0q�$��2���� $��Insert path here:��$
��Bold"�$��7,215,10,575q�$��30��$	��0,5q��� -    ��Name$ Track��$
��Left=�$	��200��$��7,250q�	 �� TextWrapping$
	 Wrap=�$	��Top=�$	��175��$��4���� -   
 ��Name$
 SendTrackButton��$��
Send Track��$	��Top=�$��80��$��50��$��7,455,103,0q�$��5���� -   $
 FollowTrackButton��$��Follow Track��$	��Top=�$��80��$��50��$��100,455,7,0q�$��6��