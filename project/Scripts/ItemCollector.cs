using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int coin = 0;

    [SerializeField] private Text CoinText;
    [SerializeField] private AudioSource collectSound;

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.CompareTag("Coin"))
        {
            collectSound.Play();
            Destroy(collision.gameObject);
            coin = coin + 1;
            CoinText.text = " " + coin;
            Debug.Log("altın toplandı");
        }
    }

}
