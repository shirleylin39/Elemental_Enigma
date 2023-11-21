using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addToInventory : MonoBehaviour
{
    public GameObject atom;
    // Start is called before the first frame update
    void Start()
    {
        atom.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);

        if (atom != null)
        {
            atom.SetActive(true);
        }
    }
}
