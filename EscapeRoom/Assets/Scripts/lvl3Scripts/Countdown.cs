using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
    float currentTime=0f;
    float startingTime=3f;
    public GameObject atom;
    public GameObject atom2;
    public GameObject atom3;
    public GameObject atom4;
    public GameObject atom5;
    public GameObject atom6;
    public GameObject atom7;
    [SerializeField] TextMeshProUGUI countdown;

    void Start(){
        currentTime=startingTime;
        atom.SetActive(false);
        atom2.SetActive(false);
        atom3.SetActive(false);
        atom4.SetActive(false);
        atom5.SetActive(false);
        atom6.SetActive(false);
        atom7.SetActive(false);
    }

    void Update(){
        if(dragToAtomizer.isCountingDown){
            currentTime -= 1*Time.deltaTime;
            countdown.text= currentTime.ToString("0");
            if(currentTime<0){
                currentTime=0;
                atom.SetActive(true);
                countdown.enabled =false;
            }
        } else if(dragBottleToAtomizer.isCountingDown){
            currentTime -= 1*Time.deltaTime;
            countdown.text= currentTime.ToString("0");
            if(currentTime<0){
                currentTime=0;
                atom2.SetActive(true);
                atom3.SetActive(true);
                atom4.SetActive(true);
                atom5.SetActive(true);
                atom6.SetActive(true);
                atom7.SetActive(true);
                countdown.enabled =false;
            }
        }
    }
}