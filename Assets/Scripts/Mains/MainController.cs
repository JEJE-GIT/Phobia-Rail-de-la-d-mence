using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]

public class MainController : MonoBehaviour
{
    ActionBasedController controller;
    public Main main;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>();
    }

    // Update is called once per frame
    void Update()
    {
        main.SetGrip(controller.selectAction.action.ReadValue<float>());
        main.SetTrigger(controller.activateAction.action.ReadValue<float>());
    }
}
