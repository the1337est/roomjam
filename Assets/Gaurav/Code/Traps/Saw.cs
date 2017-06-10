using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saw : MonoBehaviour
{
    [Header("References")]
    public Transform Frame;
    public Transform Blade;

    [Header("Booleans")]
    public bool Rotate;
    public bool Move;

    [Header("Parameters")]
    public float Length;
    public float RotateSpeed;
    public float MoveSpeed;

    private int direction = 1;

	// Use this for initialization
	void Start ()
    {
        Frame.localScale = new Vector3(0.2f, 0.2f, Length);
        Blade.localPosition = Vector3.zero;
	}

    private void Update()
    {
        if (Rotate)
        {
            Blade.Rotate(Vector3.right * Time.deltaTime * RotateSpeed * direction);
        }
        if (Move)
        {
            Blade.localPosition += Vector3.forward * direction * Time.deltaTime * MoveSpeed;
            if (direction == 1)
            {
                if (Blade.localPosition.z >= Length * 1.2f)
                {
                    direction = -1;
                }
            }
            else
            {
                if (Blade.localPosition.z <= Length * -1.2f)
                {
                    direction = 1;
                }
            }
        }

    }

}
