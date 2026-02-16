using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public UiManager uiManager;
    SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.FindWithTag("SoundManager").GetComponent<SoundManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            soundManager.PlaySfx_Coin();
            uiManager.AddScore();
        }
    }

}
