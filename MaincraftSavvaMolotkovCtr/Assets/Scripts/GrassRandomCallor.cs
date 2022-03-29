using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassRandomCallor : MonoBehaviour
{
    [SerializeField] private Color green0;
    [SerializeField] private Color green1;


    Color[] colors = new Color[2];



    private Renderer _matereal;




    private void Awake()
    {
        colors[0] = green0;
        colors[1] = green1;
       
      
    }
    private void Start()
    {
        _matereal = GetComponent<Renderer>();
        _matereal.material.SetColor("_Color", colors[Random.Range(0,2)]);
    }

}
