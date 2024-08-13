using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseWorld : MonoBehaviour
{

    private static mouseWorld instace;
    [SerializeField] private LayerMask defaultMask;
    


    private void Awake()
    {
        instace = this;
    }

    
    void Update()
    {


     
            


        




    }

    public static Vector3 getMovePos()  //forgot to add static property  this is what was causing nullref exception, also was referncing an instance which didnt work for some reason
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, instace.defaultMask);
        return hit.point;

        



        

           
    }
}
