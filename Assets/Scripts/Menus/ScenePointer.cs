﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePointer : MonoBehaviour
{
	public string scene;

	public void to_scene()
	{
		SceneManager.LoadScene(scene);
	}
}
