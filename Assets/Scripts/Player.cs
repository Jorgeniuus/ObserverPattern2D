using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        InputMoviment();
    }

    private void InputMoviment()
    {
        float moveX = Input.GetAxis("Horizontal"); 
        float moveY = Input.GetAxis("Vertical"); 

        Vector2 directions = new Vector2(moveX, moveY) * 5f;
        transform.Translate(directions * Time.deltaTime);
    }
}
