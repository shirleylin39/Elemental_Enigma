using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoodDoor : MonoBehaviour
{
    public GameObject door;
    public GameObject tankO;

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(false);
        tankO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (door != null)
        {
            door.SetActive(true);
        }
        if (tankO != null)
        {
            tankO.SetActive(true);
        }
    }
}
