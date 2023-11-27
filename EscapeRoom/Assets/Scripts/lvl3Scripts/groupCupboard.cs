using UnityEngine;

public class GroupObjects : MonoBehaviour
{
    public GameObject[] objectsToGroup;

    void Start()
    {
        // Create an empty GameObject as a parent
        GameObject group = new GameObject("GroupedObjects");

        // Loop through objects and set them as children of the parent
        foreach (GameObject obj in objectsToGroup)
        {
            obj.transform.parent = group.transform;
        }
    }
}