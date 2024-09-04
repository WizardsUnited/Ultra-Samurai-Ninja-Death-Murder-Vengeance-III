using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class disableAnimator : MonoBehaviour
{

    bool destroyPhysicsKatana;


    private Animator roninAnim;
    [SerializeField] GameObject katana;
    [SerializeField] GameObject rightHand;
    public GameObject katanaPhysics;
    private GameObject katanaPhysicsInstance;
    



    // Start is called before the first frame update
    void Start()
    {
       

    }

    private void Awake()
    {
        roninAnim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            roninAnim.enabled = false;
            katana.SetActive(false);
            CreateKatana(rightHand.transform);




        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            roninAnim.enabled = true;
            katana.SetActive(true);
            DestroyPrefab();


            
        }

        


    }

    public void CreateKatana(Transform katanaInstantiateLocation)
    {
          //location for instantation
        katanaPhysicsInstance = Instantiate(katanaPhysics, katanaInstantiateLocation.position, katanaInstantiateLocation.rotation);

    }

    public void DestroyPrefab()
    {
        Destroy(katanaPhysicsInstance);
    }



}



    
