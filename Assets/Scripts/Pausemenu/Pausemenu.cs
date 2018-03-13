﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pausemenu : MonoBehaviour 
{
	public bool paused = false;
	public Canvas pause_menu;
    Deathmenu death_menu; 
	EventSystemScript event_system;

	public void resume()
	{
		set_active(false);
		event_system.clear_selection();
		Time.timeScale = 1;
		paused = false;
	}

	public void pause ()
	{
		set_active(true);
		Time.timeScale = 0;
		paused = true;
	}

	void Start ()
	{
		//cache the death menu and event system
		set_active(false);
        death_menu = GameObject.Find("SceneManager").GetComponent<Deathmenu>();
		event_system = GameObject.Find("SceneManager").GetComponent<EventSystemScript>();
	}

	public void set_active(bool b)
    {
        pause_menu.enabled = b;
    }
		
	void Update () 
	{
		//pause if the escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape) && death_menu.active == false) 
		{
			if(paused)
			{
				resume ();
			}
			else{
				pause();
			}
		}
	}
}