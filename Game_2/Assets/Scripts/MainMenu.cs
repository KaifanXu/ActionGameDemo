﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public Texture backgroundTexture;
    public GUIStyle random1;

    public float guiPlacementX1;
    public float guiPlacementX2;
    public float guiPlacementY1;
    public float guiPlacementY2;

    public string Level;

    public bool showGUIOutline = true;

    void OnGUI()
    {

        //显示背景  
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), backgroundTexture);

        //显示按钮  
        if (showGUIOutline)
        {
            if (GUI.Button(new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .5f, Screen.height * .1f), "Start"))
            {
                print("Clicked Play Game");
                Application.LoadLevel(Level);
            }

            if (GUI.Button(new Rect(Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .5f, Screen.height * .1f), "Quit"))
            {
                print("Clicked Quit");
                Application.Quit();
            }
        }
        else
        {
            if (GUI.Button(new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .5f, Screen.height * .1f), "", random1))
            {
                print("Clicked Play Game");
            }

            if (GUI.Button(new Rect(Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .5f, Screen.height * .1f), "", random1))
            {
                print("Clicked Quit");
            }
        }
    }
}
