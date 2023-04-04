using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    [SerializeField] float Xvalue = 0f;
    [SerializeField] float Yvalue = 0f;
    [SerializeField] float Zvalue = 0f;
    void Update()
    {
        transform.Rotate(Xvalue, Yvalue, Zvalue);
    }
}
