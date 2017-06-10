using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Door : MonoBehaviour
{

    public Transform DoorObject;
    public State State;
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();

        if (State == State.Open)
        {
            DoorObject.DOLocalMove(new Vector3(0f, -0.25f, 0f), 0.2f);
            DoorObject.DOLocalRotate(Vector3.zero, 0.2f);
            //anim.Play("DoorOpen");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleDoor();
        }
    }

    void ToggleDoor()
    {
        if (State == State.Open)
        {
            DoorObject.DOLocalMove(new Vector3(0f, -0.25f, 0f), 0.2f);
            DoorObject.DOLocalRotate(Vector3.zero, 0.2f);
            State = State.Closed;
        }
        else
        {
            DoorObject.DOLocalMove(new Vector3(0.45f, -0.25f, -0.45f), 0.2f);
            DoorObject.DOLocalRotate(new Vector3(0f, -90f, 0f), 0.2f);
            State = State.Open;
        }
    }
}
