### Creating a Login Page in WPF

##### Window Properties
```xml
<Window x:Class="WPF_Login.MainWindow"
       
        WindowStyle="None"  WindowStartupLocation="CenterScreen"
        AllowsTransparency="True" Background="Transparent"
        Title="Login Window" Height="500" Width="800">
```

##### Complex Property and Canvas
'''xml
  <Border CornerRadius="30 0 0 30">
            <Border.Background>
                <LinearGradientBrush StartPoint="0 0" EndPoint="1 1">
                    <GradientStop Color="#3aa9ad" Offset="0"/>
                    <GradientStop Color="#3aada1" Offset="1"/>
                </LinearGradientBrush>
            </Border.Background>

            <Grid>
                <Canvas >
                    <Polygon Points="0,20,230,140,0,270" Fill="#4eb1b6"/>
                    <Polygon Points="100,400,200,370,180,470" Fill="#4eb1b6"/>
                    <Ellipse Margin="250 450 0 0" Width="40" Height="40" Fill="#4eb1b6"/>
                    <Ellipse Margin="50 400 0 0" Width="20" Height="20" Fill="#4eb1b6"/>
                </Canvas>

                <StackPanel Orientation="Vertical">
                    <TextBlock Text="Sign Up"/>
                    <TextBlock Text="Enter your personal information to create an account"/>
                    <Button Content="Sign Up"/>
                </StackPanel>

            </Grid>
            
 </Border>

 <Border Grid.Column="1" Background="#ffffff" CornerRadius="0 30 30 0">
            
 </Border>

'''

##### Styles



