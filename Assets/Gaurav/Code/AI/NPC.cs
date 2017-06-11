using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    AIPath path;
    Seeker seeker;

    private void Start()
    {
        path = GetComponent<AIPath>();
        seeker = GetComponent<Seeker>();

        path.target = null;

    }

    public void SetTarget(Transform target)
    {
        path.target = target;
    }

}

