using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADDFORCE : MonoBehaviour
{

    Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RB.AddForce(Vector3.forward * 100, ForceMode.Impulse);
            RB.AddTorque(new Vector3(3, 3, 3).normalized * 100, ForceMode.Impulse);
        }
    }
}
