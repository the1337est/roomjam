using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Needle : MonoBehaviour
{

    public Transform Frame;
    public Transform Spikes;

    [Header("Booleans")]
    public bool Active;

    [Header("Parameters")]
    public float Size;
    public float NeedleRange;
    public float Speed;

    private void Start()
    {
        Frame.localScale = Vector3.one * Size;
        Spikes.localScale = Vector3.one * Size;
        Spikes.DOLocalMoveY(-0.4f * Size, 0f, true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Fire();
        }
    }

    public void Fire()
    {
        Spikes.DOLocalMoveY(NeedleRange, (1f * Size)/ Speed).OnComplete(() =>
        {
            Back();
        }
        );
    }

    public void Back()
    {
        Spikes.DOLocalMoveY(-0.4f * Size, 1f / Speed).SetDelay(0.2f);
    }

}
