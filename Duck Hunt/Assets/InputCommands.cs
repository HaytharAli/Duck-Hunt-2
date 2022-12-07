using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCommands : MonoBehaviour
{
    CommandAbstract[] commands = new CommandAbstract[4];

    [SerializeField] bool inverted = false;

    [SerializeField] Crosshair crossObj;

    // Start is called before the first frame update
    void Start()
    {
        commands[0] = new UpCommand();
        commands[1] = new DownCommand();
        commands[2] = new LeftCommand();
        commands[3] = new RightCommand();

        commands[0].setCrosshair(crossObj);
        commands[1].setCrosshair(crossObj);
        commands[2].setCrosshair(crossObj);
        commands[3].setCrosshair(crossObj);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            commands[0].Execute();
        }
        if (Input.GetKey(KeyCode.S))
        {
            commands[1].Execute();
        }
        if (Input.GetKey(KeyCode.A))
        {
            commands[2].Execute();
        }
        if (Input.GetKey(KeyCode.D))
        {
            commands[3].Execute();
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            invertAim();
        }
    }

    public void invertAim()
    {
        CommandAbstract tempHolder = commands[0];
        commands[0] = commands[1];
        commands[1] = tempHolder;

        inverted = !inverted;
    }


}
