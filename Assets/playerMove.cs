using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    Transform targetDestination;
    

    private void Awake()
    {
        targetDestination = this.gameObject.transform;
    }

    private void Update()
    {
      



        transform.position = targetDestination.position;

        Debug.Log("transform is set to " + targetDestination);

    }



    //made public ref to move
    public Vector3 changePos(Vector3 targetDest)
    {
        targetDest = new Vector3(this.targetDestination.position.x, 0, this.targetDestination.position.y);


        return targetDest;

    } 


 

}
