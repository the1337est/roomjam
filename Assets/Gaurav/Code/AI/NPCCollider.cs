using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCollider : MonoBehaviour
{

    NPC parent;

    private void Start()
    {
        parent = GetComponentInParent<NPC>();
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    parent.OnChildCollisonEnter(collision);
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    parent.OnChildCollisonExit(collision);
    //}

}
