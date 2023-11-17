using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class oracleClick : MonoBehaviour
{
    public GameObject bubble;
    public TextMeshProUGUI text;

    private string hint1 = "hint 1....";
    private string hint2 = "hint 2....";
    private string hint3 = "hint 3....";

    private List<string> hints = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        bubble.SetActive(false);
        //text.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        hints.Add(hint1);
        hints.Add(hint2);
        hints.Add(hint3);

        System.Random random = new System.Random();
        int randomIndex = random.Next(0, hints.Count);
        string givenHint = hints[randomIndex];

        if (bubble != null)
        {
            bubble.SetActive(!bubble.activeSelf);
            text.text = givenHint;
        }
    }
}
