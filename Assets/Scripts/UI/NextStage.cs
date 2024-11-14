using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D c)
    {   
        if (c.gameObject.CompareTag("Player"))
        SceneManager.LoadScene("Level2");
    }
}
