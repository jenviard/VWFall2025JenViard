using UnityEngine;
using UnityEngine.InputSystem;

public class Click : MonoBehaviour
{
    [SerializeField] private InputActionProperty inputAction;
    [SerializeField] GameObject menu;

    [SerializeField] bool menuToggle = false;

    void Start()
    {
        menu.SetActive(menuToggle);
    }
    void Update()
    {
        if (inputAction.action.WasPressedThisFrame())
        {
            Debug.Log("Second Button Pressed");
            if (menuToggle == false)
            {
                menuToggle = true;
            }
            else
            {
                menuToggle = false;
            }
            menu.SetActive(menuToggle);
        }
    }
}
