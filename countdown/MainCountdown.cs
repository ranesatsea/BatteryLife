using Godot;
using System;

public class MainCountdown : RichTextLabel
{
   int ms = 0;
int s = 0;
int m = 0;
public void _Process(int detla)
{
 //ShowTimeLabel(32);
if (ms > 9)
{
    s+=1;
    ms = 0;
}
if (s > 59)
{
    m+=1;
    s=0;
}
MainCoutndown.set_text(m);

}
}
