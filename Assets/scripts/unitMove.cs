using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitMove : MonoBehaviour
{

    public float speed;
    public float turnSpeed;
    float stopDistance;
    mouseWorld mouseWorldInstance;
    Animator playerAnim;
    public Transform point1;
    public Transform point2;
    Vector3 moveDirection;
    Vector3 patrol;
    Vector3 originalTransformForward;
    Vector3 patrolpoint1;
    Vector3 patrolpoint2;
    Vector3 hitPoint;
    mouseWorld mwInstance;


    void Start()
    {
        stopDistance = .1f;
        moveDirection = transform.position;
        playerAnim = GetComponentInChildren<Animator>();
        //originalTransformForward = transform.forward;
        patrolpoint1 = point1.transform.position;
        patrolpoint2 = point2.transform.position;
        patrol = transform.position;
    }

   
    void Update()
    {
        moveDirection = (patrol - transform.position).normalized;


        bool isMoving;

        if (Input.GetKeyDown(KeyCode.T))
        {
            transform.forward = transform.position;
            patrol = point1.transform.position;
            
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.forward = transform.position;
            patrol = point2.transform.position;
            
        }
        if (Input.GetMouseButtonDown(0))
        {
            transform.forward = transform.position;
            patrol = mouseWorld.getMovePos();
            //Debug.Log(mouseWorld.getMovePos());
        }

        Debug.Log("patrol is" + patrol);

        float singlestep = speed * Time.deltaTime;//for testing vector3.rotatetowards
        
        //rotation lerp fixed - its about resetting the transform.forward, with the tutorial thats probably happening with each key press so it wasnt an issue
        //splitting the lerp into a coroutine probably helped
      


        Quaternion turnDirection = Quaternion.Euler(moveDirection * turnSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, patrol) > stopDistance)
        {

            //transform.Translate(patrol * speed * Time.deltaTime);
            transform.position += moveDirection * speed * Time.deltaTime;
            StartCoroutine(turnChar(moveDirection));
            //transform.LookAt(patrol);
//transform.forward = Vector3.Lerp(transform.forward, moveDirection, turnSpeed * Time.deltaTime);
           //transform.forward = Vector3.RotateTowards(transform.position, patrol, singlestep, 4);
            //transform.Rotate(transform.rotation.x, transform.rotation.y, patrol.z);
            // transform.Rotate(0, moveDirection.y, 0);
            //transform.forward = Vector3.Lerp(transform.forward, rotateDirection, turnSpeed);
            isMoving = true;
        }
        else 
        {
            transform.forward = transform.position;
            StopCoroutine(turnChar(moveDirection));
            isMoving = false;
            patrol = transform.position;

        }

        Debug.Log(patrolpoint2);

        if(isMoving == true)
        {
            playerAnim.SetBool("isMoving", true);
        }
        else
        {
            playerAnim.SetBool("isMoving", false);
        }


    }

    IEnumerator turnChar(Vector3 moveDirection)
    {

        Debug.Log("coroutinestarted");
      
        
       
        transform.forward = Vector3.Lerp(transform.forward, moveDirection, turnSpeed * Time.deltaTime);

        

        yield return null;

    }




}
    
        