using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class oracleClick : MonoBehaviour
{
    public GameObject bubble;
    public GameObject hint1;

    private List<GameObject> hints = new List<GameObject>();
    private bool open = true;

    // Start is called before the first frame update
    void Start()
    {
        hints.Add(bubble);
        hints.Add(hint1);

        foreach (GameObject hint in hints)
        {
            hint.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {

        System.Random random = new System.Random();
        int randomIndex = random.Next(0, hints.Count);
        GameObject givenHint = hints[randomIndex];

        foreach (GameObject hint in hints)
        {
            hint.SetActive(false);
        }

        if (givenHint != null && open == true)
        {
            givenHint.SetActive(!givenHint.activeSelf);
        }
        open = !open;
    }
}
