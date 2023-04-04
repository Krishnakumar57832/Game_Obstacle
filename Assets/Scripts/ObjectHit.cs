using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    bool ishit = true;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && ishit)
        {
            Debug.Log("hit");
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
            ishit = true;
        }
        
    }
}
