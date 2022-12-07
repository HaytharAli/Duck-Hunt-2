using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CommandAbstract : ScriptableObject
{
    protected Crosshair crossObj;

    virtual public void Execute()
    {

    }

    public void setCrosshair(Crosshair crosshair)
    {
        crossObj = crosshair;
    }
}
