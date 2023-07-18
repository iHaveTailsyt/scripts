using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Script/Plot", fileName = "Plot")]
public class Plot : ScriptableObject
{
    public Sprite Thumbnail;
    public List<PlotPart> Script;
}
