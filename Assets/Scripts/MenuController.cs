using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup settingsGroup;

    [SerializeField]
    private AudioSource bgmSource;

    [SerializeField]
    private Slider BGMSlider;
    [SerializeField]
    private Slider overallSlider;


    public void ToggleSettings(bool i)
    {
        settingsGroup.alpha = i ? 1f : 0f;
        settingsGroup.interactable = i;
        settingsGroup.blocksRaycasts = i;
    }

    public void AdjustOverallVolume(float value)
    {
        AudioListener.volume = value;
    }

    public void AdjustBGMVolume(float value)
    {
        bgmSource.volume = value;
    }

    public void ToggleBGM(bool i)
    {
        if (i)
        {
            bgmSource.Play();
            bgmSource.volume = BGMSlider.value;
            BGMSlider.interactable = true;
        }
        else
        {
            bgmSource.Pause();
            BGMSlider.interactable = false;
        }
    }

    public void ToggleOverall(bool i)
    {
        if (i)
        {
            AudioListener.volume = overallSlider.value;
            overallSlider.interactable = true;
        }
        else
        {
            AudioListener.volume = 0;
            overallSlider.interactable = false;
        }
    }
}
