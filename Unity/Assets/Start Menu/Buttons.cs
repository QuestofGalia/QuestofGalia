using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
    
    public Font font;			//Font used for text
    public float X, Y, Y2;		//Values for button placement

    //Method creates 2 buttons "Start" and "Quit" on the scene 
    void OnGUI()
    {
        GUI.color = Color.yellow;
        GUI.skin.font = font;

        //Y and X -axis values for the buttons
        float Xcord = X * Screen.width;
        float Ycord = Y * Screen.height;
        float Ycord2 = Y2 * Screen.height;

        //Game start button
        if (GUI.Button(new Rect(Xcord, Ycord, 150, 60), "Start"))
        {
            Application.LoadLevel(1);
        }

        //Quit button
        if (GUI.Button(new Rect(Xcord, Ycord2, 150, 40), "Quit"))
        {
            Application.Quit();
        }
    }
}
