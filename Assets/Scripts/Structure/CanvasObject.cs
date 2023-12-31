using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ObjectTransform
{
    public Vector3 Position;
    public Vector3 Rotation;
    public Vector3 Scale;
}
[Serializable]
public class CanvasTextMeshProUGUI
{
    public string Text;
    public string FontColor;
    public float FontSize;
}

[Serializable]
public class CanvasObject
{
    public string Name;
    public ObjectTransform Transform;
    public CanvasTextMeshProUGUI TextMeshProUGUI;
    public List<CanvasObject> ChildObjects;
}
