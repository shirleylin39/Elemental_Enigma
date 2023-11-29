using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class furnaceSmoke : MonoBehaviour
{
    public GameObject furnace;
    public GameObject smoke;
    public GameObject key;


    // Start is called before the first frame update
    void Start()
    {
        furnace.SetActive(true);
        smoke.SetActive(false);
        key.SetActive(false);
        Invoke("DisappearanceLogic", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (furnace != null)
        {
            DisappearanceLogic();
        }
    }
    void DisappearanceLogic(){
        if(smoke.activeSelf) 
        {
            smoke.SetActive(false);
            key.SetActive(true);
        }
        else
        {
            smoke.SetActive(true);
        }
    }
}
