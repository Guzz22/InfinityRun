using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 6f;

    private void Update()
    {
        //adiciona movimento para a esquerda dos obstáculos
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}