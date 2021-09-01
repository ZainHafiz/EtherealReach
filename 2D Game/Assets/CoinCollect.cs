using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public Animator animator;
    public int coinValue = 1;


    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collected");
            ScoreManager.Instance.ChangeScore(coinValue);
            GetComponent<CircleCollider2D>().enabled = false;
            animator.SetBool("IsCollected", true);
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }

}
