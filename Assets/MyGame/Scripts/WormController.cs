using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public KeyCode jumpKey;
    public KeyCode fowardKey;
    public KeyCode backkey;
    public Rigidbody rigid;
    public Vector3 jump;
    public Vector3 forwared;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Debug.Log("Jump taste wurde gedrückt");
            rigid.AddForce(jump);
        }
    
        if (Input.GetKeyDown(fowardKey))
        {
            Debug.Log("Forwärts taste wurde gedrückt");
            rigid.AddForce(forwared);

        }
        if (Input.GetKeyDown(backkey))
        {
            Debug.Log("Rückwertstaste taste wurde gedrückt");
            rigid.AddForce(-forwared);

        }
    }
}