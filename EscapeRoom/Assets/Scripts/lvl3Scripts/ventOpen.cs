using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventOpen : MonoBehaviour
{
    public GameObject vent;
    public GameObject piece;
    public GameObject atom;

    // Start is called before the first frame update
    void Start()
    {
        vent.SetActive(false);
        piece.SetActive(false);
        atom.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (vent != null)
        {
            vent.SetActive(true);
        }
        if (piece != null)
        {
            piece.SetActive(true);
        }
    }
}
