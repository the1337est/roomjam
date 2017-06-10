using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearMachine : MonoBehaviour {

    public Transform Launcher;
    public Transform[] Spears;

    int index;

    [Header("Booleans")]
    public bool Move;
    public bool Active;

    [Header("Parameters")]
    public float LauncherSize;
    public float SpearSize;
    public float Speed;
    public float MaxAngle;

    private void Start()
    {
        Launcher.localScale = Vector3.one * LauncherSize;
        foreach (Transform t in Spears)
        {
            t.localScale = Vector3.one * SpearSize;
        }
    }

    private int direction = 1;
    float acc = 1f;
    private float targetRot;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            if(Spears[0]
        }

        if (Move)
        {
            float z = Launcher.localEulerAngles.z;
            Launcher.localEulerAngles += Vector3.forward * Speed * Time.deltaTime * direction;

            if (direction == 1)
            {
                if (z > MaxAngle - 1f && z < 180f)
                {
                    Debug.Log("Reached positive max");
                    direction = -1;
                }
            }
            else
            {
                if (z < 360 - (MaxAngle - 1f) && z > 180f)
                {
                    Debug.Log("Reached negative max");
                    direction = 1;
                }
            }
        }
    }

}
