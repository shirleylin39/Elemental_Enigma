using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_extringuisher : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject inv1, inv2, inv3, inv4, inv5, turkey, atom_slots, a1, a2, a3, a4, a5; 
    
    void OnMouseDown()
    {
        if(inv1 == null && inv2 == null && inv3 == null && inv4 == null && inv5 == null)
        {
            Destroy(a1);
            Destroy(a2);
            Destroy(a3);
            Destroy(a4);
            Destroy(a5);
            Destroy(atom_slots);
            turkey.SetActive(true);
        }
    }
}
