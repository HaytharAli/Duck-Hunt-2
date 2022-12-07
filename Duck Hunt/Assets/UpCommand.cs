using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCommand : CommandAbstract
{
    public override void Execute()
    {
        crossObj.moveUp();
    }
}
