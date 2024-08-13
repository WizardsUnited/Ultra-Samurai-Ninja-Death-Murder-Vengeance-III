using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatScript : MonoBehaviour
{

    private Vector3 startPos;
    private float repeatWidth;
    [SerializeField] float speed;


  

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.z / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > startPos.z + repeatWidth)
        {
            transform.position = startPos;
            Debug.Log("passed threshhold");
        }


        transform.Translate(Vector3.forward * Time.deltaTime * speed);


    }
}
