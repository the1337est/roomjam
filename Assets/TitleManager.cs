using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TitleManager : MonoBehaviour
{

    public Text Title;
    public Text Subtitle;

	// Use this for initialization
	void Start ()
    {

        Title.color = new Color(1, 1, 1, 0);
        Subtitle.color = new Color(1, 1, 1, 0);
        Title.DOColor(new Color(1, 1, 1, 0.7f), 3f).OnComplete(() =>
        {
            Subtitle.DOColor(new Color(1, 1, 1, 0.7f), 2f).OnComplete(() =>
            {
                TitleShakeRandom();
                SubtitleFadeRandom();
            });
        });

	}

    public void SubtitleFadeRandom()
    {
        float alpha = Random.Range(0.1f, 0.5f);
        float time = Random.Range(0f, 0.2f);
        float delay = Random.Range(0f, 0.05f);
        Subtitle.DOColor(new Color(1, 1, 1, alpha), time).OnComplete(() => 
        {
            SubtitleFadeRandom();

        }).SetDelay(delay);

    }

    public void TitleShakeRandom()
    {
        float lenth = Random.Range(-1f, 1f);
        float time = Random.Range(0f, 0.1f);
        float delay = Random.Range(0f, 0.3f);
        Title.rectTransform.DOAnchorPosX(lenth, time).OnComplete(() =>
        {
            TitleShakeRandom();

        }).SetDelay(delay);

    }


}
