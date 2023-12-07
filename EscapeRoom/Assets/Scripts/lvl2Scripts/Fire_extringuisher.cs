using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_extringuisher : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject inv1, inv2, inv3, fire_ex, atom_slots, a1, a2, a3; 
    
    void OnMouseDown()
    {
        if(a1.GetComponent<BoxCollider>()==null && a2.GetComponent<BoxCollider>()==null 
        && a3.GetComponent<BoxCollider>()==null)
        {
            Destroy(a1);
            Destroy(a2);
            Destroy(a3);
            Destroy(atom_slots);
            fire_ex.SetActive(true);
        }
    }
}
