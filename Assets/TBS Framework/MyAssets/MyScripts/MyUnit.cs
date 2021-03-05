using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TbsFramework.Units;

public class MyUnit : Unit
{
    public Color LeadingColor;

    public override void Initialize()
    {
        base.Initialize();
        transform.localPosition -= new Vector3(0, 0, 1);
        GetComponent<Renderer>().material.color = LeadingColor;
    }

    public override void MarkAsAttacking(Unit target)
    {
        throw new System.NotImplementedException();
    }

    public override void MarkAsDefending(Unit aggressor)
    {
        throw new System.NotImplementedException();
    }

    public override void MarkAsDestroyed()
    {
        throw new System.NotImplementedException();
    }

    public override void MarkAsFinished()
    {
        throw new System.NotImplementedException();
    }

    public override void MarkAsFriendly()
    {
        GetComponent<Renderer>().material.color = LeadingColor + new Color(0.8f,1,0.8f);
    }

    public override void MarkAsReachableEnemy()
    {
        GetComponent<Renderer>().material.color = LeadingColor + Color.red;
    }

    public override void MarkAsSelected()
    {
        GetComponent<Renderer>().material.color = LeadingColor + Color.green;
    }

    public override void UnMark()
    {
        GetComponent<Renderer>().material.color = LeadingColor;
    }

}
