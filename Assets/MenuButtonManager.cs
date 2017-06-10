using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonManager : MonoBehaviour
{

    Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}

    public void SetButtonHover(int i)
    {
        Debug.Log("Setting hover" + i);
        anim.SetInteger("Button", i);
    }
	
}
