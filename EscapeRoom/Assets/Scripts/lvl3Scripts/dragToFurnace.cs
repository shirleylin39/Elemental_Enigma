using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class dragToFurnace : MonoBehaviour
{
    private bool dragging, placed1, smokeOn;
    private Vector2 offset, inventoryPos;
    public GameObject item;
    public GameObject openFurnace;
    public GameObject key;
    public GameObject smoke;
    [SerializeField] GameObject _slot1, inventory_slot;


    void Start(){
        smoke.SetActive(false);
        openFurnace.SetActive(false);
        key.SetActive(false);
    }

    void Update()
    {
        if(placed1)
        {
            return;
        }
        if (!dragging)
        {
            return;
        }
        var mousePos = GetMousePos();
        transform.position = mousePos - offset;
    }

    void OnMouseDown()
    {
        dragging = true;
        offset = GetMousePos() - (Vector2)transform.position;
    }

    void OnMouseUp()
    {   
         if (_slot1 != null && Vector2.Distance(transform.position, _slot1.transform.position) < 1)
        {
            transform.position = _slot1.transform.position;
            placed1 = true;
            Destroy(item);
            smoke.SetActive(true);
            Invoke("DestroyObject", 0.03f);
            openFurnace.SetActive(true);
            key.SetActive(true);
        }
        else
        {
            dragging = false;
            transform.position = inventory_slot.transform.position;
        }    
    }

    void DestroyObject()
    {
        Destroy(smoke);
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    // private IEnumerator CallFunctions(){
    //     dragSuccess();    
    //     yield return new WaitForSeconds(3f);
    //     smoke.SetActive(false);
    //     openFurnace.SetActive(true);
    //     key.SetActive(true);
    // }

    // private void dragSuccess(){
    //      if (_slot1 != null && Vector2.Distance(transform.position, _slot1.transform.position) < 1)
    //     {
    //         transform.position = _slot1.transform.position;
    //         placed1 = true;
    //         Destroy(item);
    //         smoke.SetActive(true);
    //         Invoke(Destroy(smoke), 3.0f);
    //     }
    //     else
    //     {
    //         dragging = false;
    //         transform.position = inventory_slot.transform.position;
    //     }
    // }
}