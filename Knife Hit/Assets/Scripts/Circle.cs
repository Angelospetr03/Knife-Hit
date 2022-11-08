using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
 public   CircleSO circleData;


    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();


        Init();
    }



    void Init()
    {
        spriteRenderer.sprite = circleData.image;
        transform.localScale = new Vector3(circleData.Size, circleData.Size, circleData.Size);
    }
}
