using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public UiManager uiManager;
    public GameObject player;
    public GameObject groundPrefab;

    //public void CreateNewGround(Vector3 pos)
    //{
    //    Debug.Log("CreateNewGround");
    //    Instantiate(groundPrefab, pos + new Vector3(0,0,7), Quaternion.identity);
    //}

    public void OnBTN_StartGame()
    {
        player.SetActive(true);
        uiManager.StartGame();
    }

    public void EndGame()
    {
        player.SetActive(false);
        uiManager.GameEnd();
    }
}
