using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractive : MonoBehaviour
{
    [SerializeField] private Animator animDoor;
    
    private void Start()
    {
        //aqui no script da porta, o método que vai abrir a porta é inscrito no 
        //evento da classe trigger, acessando a classe trigger e depois o evento que queremos. 
        TriggerEnter.OnOpenDoor += OpenTheDoor;
        TriggerEnter.OnCloseDoor += CloseTheDoor;
    }

    private void OpenTheDoor()
    {
        print("Abrindo Porta");
        animDoor.SetBool("open", true);
    }

    private void CloseTheDoor()
    {
        print("Fechando Porta");
        animDoor.SetBool("open", false);
    }
}
