using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Scene Data", menuName = "Scriptable Object/Scene Data", order = int.MaxValue)]
public class SceneData : ScriptableObject
{
    [SerializeField]
    private string CallInScene;
    public string SceneName {get { return CallInScene; } }

    [SerializeField]
    private string CallInXCoordinates;
    public string  XCoordinates { get { return CallInXCoordinates; } }

    [SerializeField]
    private string CallInYCoordinates;
    public string YCoordinates { get { return CallInYCoordinates; } }
    
    [SerializeField]
        private string CallInZCoordinates;
    public string ZCoordinates { get { return CallInZCoordinates; } }
}
