using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;

   

    void Update()
    {
        moveplayer();
    }
    

    void moveplayer()
    {

        float Xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float Zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(Xvalue, 0, Zvalue);
      
    }
    
}
