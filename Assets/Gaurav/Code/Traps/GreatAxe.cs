using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatAxe : MonoBehaviour
{

    [Header("References")]
    public Transform Ring;
    public Transform Axe;

    [Header("Booleans")]
    public bool Move;

    [Header("Parameters")]
    public float Size;
    public float MaxAngle;
    public float Factor;

    private int direction = 1;
    float acc = 1f;
    private float targetRot;

    private void Start()
    {
        Ring.localScale = Vector3.one * Size;
        Axe.localScale = Vector3.one * Size;
        targetRot = MaxAngle * direction;
    }

    void Update()
    {
        if (Move)
        {
            float z = Axe.localEulerAngles.z;
            Axe.localEulerAngles = Vector3.Lerp(Axe.localEulerAngles, Vector3.forward * MaxAngle * direction, Factor);

            if (direction == 1)
            {
                if (z > MaxAngle -1f && z < 180f)
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
}
