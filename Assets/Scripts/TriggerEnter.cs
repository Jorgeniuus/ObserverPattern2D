using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TriggerEnter : MonoBehaviour
{
    // O Script/objeto que vai dar inicio a ação terá o evento e invocará esse evento
    public static event Action OnOpenDoor;//evento q será inscrito metodo que abre porta
    public static event Action OnCloseDoor;//evento q será inscrito metodo que fecha porta

    private void OnTriggerEnter2D(Collider2D colision)
    {
        GameObject obj = colision.gameObject;

        if(obj.CompareTag("Player"))
        {
             // Tanto o if de TriggerEnter quanto o Invoke do TriggerExit fazem a mesma coisa. Podemos usar um ou outro.
            if(OnOpenDoor != null)
            {
                print("Invocou Action de Open");
                OnOpenDoor(); 
                // aqui quando o player entra no colisor invoca / chama o evento
                // que está nessa classe, que tem os méttodos da classe da porta inscritos nele.
            }
        }  
    }
    private void OnTriggerExit2D(Collider2D colision)
    {
        GameObject obj = colision.gameObject;

        if(obj.CompareTag("Player"))
        {
            print("Invocou Action de Close");

            // Tanto o if de TriggerEnter quanto o Invoke do TriggerExit fazem a mesma coisa. Podemos usar um ou outro.
            OnCloseDoor?.Invoke();
            // aqui quando o player entra no colisor invoca / chama o evento
            // que está nessa classe, que tem os méttodos da classe da porta inscritos nele.
        }
    }
}
