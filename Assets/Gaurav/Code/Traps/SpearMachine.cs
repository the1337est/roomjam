using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearMachine : MonoBehaviour
{

    public Transform Launcher;
    public Transform SpearContainer;

    public List<Spear> Spears;

    public GameObject SpearPrefab;

    int index;

    [Header("Booleans")]
    public bool Move;
    public bool Active;

    [Header("Parameters")]
    public int SpearCount;
    public float LauncherSize;
    public float SpearSize;
    public float Speed;
    public float MaxAngle;

    private void Start()
    {
        Launcher.localScale = Vector3.one * LauncherSize;
        Spears.Clear();
        for (int i = 0; i < SpearCount; i++)
        {
            Spear s = Instantiate(SpearPrefab, SpearContainer).GetComponent<Spear>();
            s.transform.localScale = Vector3.one * SpearSize;
            s.Active = false;
            Spears.Add(s);
        }
    }

    private int direction = 1;
    float acc = 1f;
    private float targetRot;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Spear s = GetSpear();
            if(s != null)
            {
                s.Fire(Launcher.up, 30f);
            }
        }

        if (Move)
        {
            float z = Launcher.localEulerAngles.z;
            Launcher.localEulerAngles += Vector3.forward * Speed * Time.deltaTime * direction;

            if (direction == 1)
            {
                if (z > MaxAngle - 1f && z < 180f)
                {
                    direction = -1;
                }
            }
            else
            {
                if (z < 360 - (MaxAngle - 1f) && z > 180f)
                {
                    direction = 1;
                }
            }
        }
    }

    public Spear GetSpear()
    {
        Spear spear = Spears.Find(s => s.Active == false);
        return spear;
    }
}
