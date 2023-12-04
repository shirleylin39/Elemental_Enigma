using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class dragToFurnace : MonoBehaviour
{
    private bool dragging, placed1, smokeOn;
    private Vector2 offset, inventoryPos;
    public GameObject item;
    public GameObject key;
    public GameObject smoke;
    [SerializeField] GameObject _slot1, inventory_slot;


    void Start(){
        smoke.SetActive(false);
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
        if(smokeOn){
            StartCoroutine(RemoveAfterSeconds(3));
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
            smokeOn=true;
        }
        else
        {
            dragging = false;
            transform.position = inventory_slot.transform.position;
        }
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    IEnumerator RemoveAfterSeconds (int seconds){
        yield return new WaitForSeconds(seconds);
        smoke.SetActive(false);
        key.SetActive(true);
    }
}