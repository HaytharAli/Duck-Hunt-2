using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCommand : CommandAbstract
{
    public override void Execute()
    {
        crossObj.moveLeft();
    }
}
