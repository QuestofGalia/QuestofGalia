using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
    
    public Font font;			//Font used for text
    public float X, Y, Y2, Y3;		//Values for button placement
    public GUIContent startImg, optionsImg, quitImg;
    public GUIStyle startStyle, optionsStyle, quitStyle;

    //Method creates 2 buttons "Start" and "Quit" on the scene 
    void OnGUI()
    {
        GUI.color = Color.yellow;
        GUI.skin.font = font;

        //Y and X -axis values for the buttons
        float Xcord = X * Screen.width;
        float Ycord = Y * Screen.height;
        float Ycord2 = Y2 * Screen.height;
        float Ycord3 = Y3 * Screen.height;

        //Game start button
        if (GUI.Button(new Rect(Xcord, Ycord, 150, 70), startImg, startStyle))
        {
            Application.LoadLevel(1);
        }

        //Options button
        if (GUI.Button(new Rect(Xcord, Ycord2, 150, 70), optionsImg, optionsStyle))
        {
            //Options asetuksia.
        }

        //Quit button
        if (GUI.Button(new Rect(Xcord, Ycord3, 150, 70), quitImg, quitStyle))
        {
            Application.Quit();
        }

    }
}
