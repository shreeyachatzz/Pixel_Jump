using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI strawText;

    [SerializeField] private AudioSource collectSoundEffect;

    private int straw = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Strawberry"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            straw++;
            strawText.text = "Strawberries: " + straw;
        }
    }
}
