using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CheckPlayerInput : MonoBehaviour
{
    bool testBool = false;
    [SerializeField]private Dialogue _dialogue;
    private void Awake()
    {
        _dialogue = GetComponent<Dialogue>();
    }
    

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            testBool = true;

        }
    }

    private void Update()
    {
        if (testBool == true)
        {
            if (Keyboard.current.eKey.isPressed == true)
            {
                testBool = true;
                _dialogue.NextDialogue();
            }

        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        testBool = false;
    }
}
