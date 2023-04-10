using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int hits = 3;
    public TMP_Text HitCount;

    private void Update()
    {
        HitCount.text = hits.ToString();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Hit")
        {
            hits--;
            
            
            //Debug.Log("you've bumped into a thing this many times: " + hits);
            if (hits <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

    }
  
}

     
