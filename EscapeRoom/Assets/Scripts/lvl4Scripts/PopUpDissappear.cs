using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpDissappear : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject openCupboard;
    void OnMouseDown()
    {
        openCupboard.SetActive(false);
    }

}
