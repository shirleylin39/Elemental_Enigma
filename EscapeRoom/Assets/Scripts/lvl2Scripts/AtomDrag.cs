using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomDrag : MonoBehaviour
{
    private bool dragging, placed;
    private Vector2 offset, inventoryPos;
    [SerializeField] GameObject _slot, inventory_slot;


    void Update()
    {
        if(placed)
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
        if (Vector2.Distance(transform.position, _slot.transform.position) < 1)
        {
            transform.position = _slot.transform.position;
            placed = true;
            Destroy(_slot);
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
}