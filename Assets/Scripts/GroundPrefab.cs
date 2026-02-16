using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GroundPrefab : MonoBehaviour
{
    GameManager gameManager;
    public Transform blockTransform;
    public Transform coinTransform;

    private void Start()
    {
        gameManager = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();

        int rnd = Random.Range(-1,2);
        float rndZ = Random.Range(-7.9f,0);
        blockTransform.localPosition = new Vector3(rnd * 2, 0, rndZ);

        int rndCoin = Random.Range(-1, 2);
        float rndZCoin = Random.Range(-7.9f, 0);
        coinTransform.localPosition = new Vector3(rndCoin * 2, 0.6f, rndZCoin);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("OnTriggerEnter Player");
            //gameManager.CreateNewGround(transform.position);
            transform.position += new Vector3(0, 0, 39);

            int rnd = Random.Range(-1,2);
            float rndZ = Random.Range(-7.9f, 0);
            blockTransform.localPosition = new Vector3(rnd * 2, 0, rndZ);

            coinTransform.gameObject.SetActive(true);
            int rndCoin = Random.Range(-1, 2);
            float rndZCoin = Random.Range(-7.9f, 0);
            coinTransform.localPosition = new Vector3(rndCoin * 2, 0.6f, rndZCoin);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Destroy(gameObject,1);
    }
}
