using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public void OnChildCollisonEnter(Collision col)
    {
        Debug.Log("Child collided");
    }

    public void OnChildCollisonExit(Collision col)
    {

    }


}

