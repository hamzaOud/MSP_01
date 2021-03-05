using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class MySquare : TbsFramework.Cells.Square
{
    public override Vector3 GetCellDimensions()
    {
        //return new Vector3(1f,0.2f,1f);
        return GetComponent<Renderer>().bounds.size;
    }

    public override void MarkAsHighlighted()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public override void MarkAsPath()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }

    public override void MarkAsReachable()
    {
        GetComponent<Renderer>().material.color = Color.cyan;
    }

    public override void UnMark()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
