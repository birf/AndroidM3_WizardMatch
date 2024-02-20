using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WizardMatch;

[CreateAssetMenu(fileName = "MatchEmblem",menuName = "WizardMatch")]


// scriptable object for holding basic data about the swipe icons
public class SwipeScriptable : ScriptableObject
{
    public Sprite icon;
    public SwipeElement swipeElement;
    public short color;
    /*
        0 = red
        1 = green
        2 = blue
        3 = yellow
        4 = purple
    */
}
