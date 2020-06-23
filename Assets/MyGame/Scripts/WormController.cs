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

    public GameObject panzer;
    public Vector3 af;
   
 //   public Vector3 position;
 //   public Quaternion Quat;

 
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
              GameObject Savepanzer = 
            Instantiate(projectile, panzer.transform.position, panzer.transform.rotation);
            Rigidbody rbp = Savepanzer.GetComponent(typeof(Rigidbody)) as Rigidbody;
            rbp.AddForce(af);
        
        }
    }
}