using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour  
{
    [SerializeField] AudioClip breakSound;

    // cached reference
    Level level;

    private void Start()
    {
        Debug.Log("Start - Block line 14");
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
        Debug.Log("CountbeakableBlocks Block line 17");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
        Debug.Log(collision.gameObject.name);
    }

    private void DestroyBlock()
    {
        Debug.Log("DestroyBlock - Block line28");
        FindObjectOfType<GameStatus>().AddToScore();
        Debug.Log("DestroyBlock - Block line30");
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Debug.Log("DestroyBlock - Block line32");
        Destroy(gameObject);
        Debug.Log("DestroyBlock - Block line34");
        level.BlockDestroyed();
        Debug.Log("DestroyBlock - Block line36");
    }
}
