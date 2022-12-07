using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCommand : CommandAbstract
{
    public override void Execute()
    {
        crossObj.moveDown();
    }
}
