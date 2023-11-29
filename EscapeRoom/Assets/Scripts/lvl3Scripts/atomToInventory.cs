using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atomToInventory : MonoBehaviour
{

    public GameObject feAtomizer;
    public GameObject feInventory;
    // Start is called before the first frame update
    void Start()
    {
        feAtomizer.SetActive(true);
        feInventory.SetActive(false);
    }

   
    void OnMouseDown()
    {
        if(feAtomizer != null)
        {
            feInventory.SetActive(true);
            feAtomizer.SetActive(false);
        }
    }
}
