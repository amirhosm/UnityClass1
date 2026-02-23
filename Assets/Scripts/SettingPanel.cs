using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SettingPanel : MonoBehaviour
{
    public SoundManager soundManager;
    public TextMeshProUGUI musicBtnTxt;
    public TextMeshProUGUI sfxBtnTxt;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Music") == 0)
        {
            soundManager.ToggleMusic(true);
            musicBtnTxt.text = "Music OFF";
        }
        else
        {
            soundManager.ToggleMusic(false);
            musicBtnTxt.text = "Music ON";
        }

        if (PlayerPrefs.GetInt("Sfx") == 0)
        {
            soundManager.ToggleSfx(true);
            sfxBtnTxt.text = "Sfx OFF";
        }
        else
        {
            soundManager.ToggleSfx(false);
            sfxBtnTxt.text = "Sfx ON";
        }
    }

    public void OnBTN_MusicToggle()
    {
        if( PlayerPrefs.GetInt("Music") == 0)
        {
            PlayerPrefs.SetInt("Music", 1);
            soundManager.ToggleMusic(false);
            musicBtnTxt.text = "Music ON";
        }
        else
        {
            PlayerPrefs.SetInt("Music", 0);
            soundManager.ToggleMusic(true);
            musicBtnTxt.text = "Music OFF";
        }

    }

    public void OnBTN_SfxToggle()
    {
        if (PlayerPrefs.GetInt("Sfx") == 0)
        {
            PlayerPrefs.SetInt("Sfx", 1);
            soundManager.ToggleSfx(false);
            sfxBtnTxt.text = "Sfx ON";
        }
        else
        {
            PlayerPrefs.SetInt("Sfx", 0);
            soundManager.ToggleSfx(true);
            sfxBtnTxt.text = "Sfx OFF";
        }
    }


}
