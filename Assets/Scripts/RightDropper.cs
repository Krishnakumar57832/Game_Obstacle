using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightDropper : MonoBehaviour
{
    MeshRenderer _renderer;
    Rigidbody _rb;
    [SerializeField] float timetowait = 5f;



    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
        _rb = GetComponent<Rigidbody>();

        waitdropper();
    }
    void Update()
    {

        if (Time.time >= timetowait)
        {
            dropper();
        }


    }
    void dropper()
    {
        _renderer.enabled = true;
        _rb.useGravity = true;
        if (Time.time >= 2f)
        {
            _rb.GetComponent<Rigidbody>().AddForce(transform.right, ForceMode.Force);
        }

    }
    void waitdropper()
    {
        _renderer.enabled = false;
        _rb.useGravity = false;
    }

}
