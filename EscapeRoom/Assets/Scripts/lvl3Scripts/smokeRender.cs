using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeRender : MonoBehaviour
{
    [SerializeField] Vector2 movespeed;
    Vector2 offset;
    Material material;
    void Start(){
        
    }
    void Awake(){
        material=GetComponent<SpriteRenderer>().material;
    }

    void Update(){
        offset =movespeed*Time.deltaTime;
        material.mainTextureOffset+=offset;
    }
}
