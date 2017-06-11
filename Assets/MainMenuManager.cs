using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MainMenuManager : Singleton<TitleManager>
{

    public Animator ButtonAnimator;

    public RectTransform Overlay;
    public RectTransform MenuUI;
    public RectTransform GameUI;

    Image overlay;

	void Start ()
    {
        overlay = Overlay.GetComponent<Image>();
        overlay.gameObject.SetActive(false);
	}

    public void SetButtonHover(int i)
    {
        //Debug.Log("Setting hover" + i);
        if (i > 0)
        {
            AudioManager.Instance.PlayButtonHover();
            ButtonAnimator.Play("Button" + i);
        }
        else
        {
            ButtonAnimator.Play("Idle");
        }
        //ButtonAnimator.SetInteger("Button", i);
    }

    public void StartGame()
    {
        //Debug.Log("Start button pressed");
        AudioManager.Instance.PlayButtonClick();
        GameManager.Instance.State = GameState.Loading;
        overlay.gameObject.SetActive(true);
        overlay.DOColor(new Color(0, 0, 0, 0), 0f);
        overlay.DOColor(Color.black, 2.5f).OnComplete(() =>
        {
            MenuUI.gameObject.SetActive(false);
            GameUI.gameObject.SetActive(true);
            overlay.DOColor(new Color(0,0,0,0), 1.5f).SetDelay(0.5f).OnComplete(()=> 
            {
                GameManager.Instance.State = GameState.Play;
                GameManager.Instance.StartGame();
            });
        });
    }

    public void ShowEditUI()
    {

    }

    public void ShowPlayUI()
    {

    }

    public void ShowLoadingUI()
    {

    }

    public void ShowGameOverUI()
    {

    }

    private void OnEnable()
    {
        GameManager.OnGameStateChange += OnGameStateChange;
    }
    private void OnDisable()
    {
        GameManager.OnGameStateChange -= OnGameStateChange;
    }

    void OnGameStateChange(GameState state)
    {
        switch (state)
        {
            case GameState.Menu:

                break;

            case GameState.Loading:
                ShowLoadingUI();
                break;

            case GameState.Edit:
                ShowEditUI();
                break;

            case GameState.Play:
                ShowPlayUI();
                break;

            case GameState.Over:
                ShowGameOverUI();
                break;
        }
    }

}
