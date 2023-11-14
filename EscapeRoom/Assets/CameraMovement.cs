using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{

    public float moveSpeed = 10f;
    public float moveDistance = 10f;

    public float minX = -20f;
    public float maxX = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move camera left on left arrow click
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveCamera(Vector3.right);
        }

        // Move camera right on right arrow click
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveCamera(Vector3.left);
        }
    }

    void MoveCamera(Vector3 direction)
    {
        Vector3 newPosition = transform.position + direction * moveSpeed * moveDistance * Time.deltaTime;

        // Clamp the new position within the boundaries
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        transform.position = newPosition;
    }
}
