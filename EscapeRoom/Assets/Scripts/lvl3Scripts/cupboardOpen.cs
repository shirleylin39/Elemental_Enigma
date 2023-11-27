using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupboardOpen : MonoBehaviour
{
    public GameObject door;
    public GameObject cupboard;


    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
        cupboard.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (door != null)
        {
            cupboard.SetActive(true);
        }
    }
}
