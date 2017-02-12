﻿using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour
{
    
	void Awake ()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Background Music");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

	}
	
}
