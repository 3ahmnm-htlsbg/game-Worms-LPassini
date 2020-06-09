using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public KeyCode jumpKey;
    public KeyCode downKey;
    public KeyCode fowardKey;
    public KeyCode backkey;
    public KeyCode shootKey;
    public Rigidbody rigid;
    public Vector3 jump;
    public Vector3 forwared;
    public GameObject projectile;

    public Vector3 position;
    public Quaternion Quat;

    public GameObject ok;
    public Vector3 posok;
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
            Debug.Log("Rückwerts taste wurde gedrückt");
            rigid.AddForce(-forwared);

        }
        if (Input.GetKeyDown(downKey))
        {
            Debug.Log("Hinunter taste wurde gedrückt");
            rigid.AddForce(-jump);

        }
        if (Input.GetKeyDown(shootKey))
        {
            Debug.Log("Pew Pew");
            posok = ok.transform.position;
            GameObject clone;
            clone = Instantiate(projectile,position,Quat);
            Rigidbody rb;
            rb = clone.GetComponent<Rigidbody>();
            rb.AddForce (new Vector3(500,0,0));
            // clone = Rigidbody.GetComponent(clone);
            // rb.AddForce;
            //HingeJoint hinge = gameObject.GetComponent(); 
        }
    }
}