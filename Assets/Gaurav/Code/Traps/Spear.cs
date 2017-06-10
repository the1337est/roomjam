using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{

    public bool Active = false;

    Rigidbody rb;
    Collider col;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
	}

    private void Update()
    {
        if (Active)
        {
            transform.localEulerAngles += Vector3.up * 300f * Time.deltaTime;
        }
    }

    public void Fire(Vector3 direction, float force)
    {
        rb.velocity = direction * force;
        Active = true;
        Invoke("Stop", 1f);
        Invoke("SetCollider", 0.1f);
    }

    public void SetCollider()
    {
        col.isTrigger = false;
    }

    public void Stop()
    {
        Active = false;
        col.isTrigger = true;
        rb.velocity = Vector3.zero;
        transform.localPosition = Vector3.zero;
        transform.localEulerAngles = Vector3.zero;
    }

}
