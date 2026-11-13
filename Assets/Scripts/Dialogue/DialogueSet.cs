using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueSet",
                 menuName = "ChemistryVR/Dialogue Set")]

public class DialogueSet : ScriptableObject
{
    public string customerId;

    public List<DialogueEntry> entries = new List<DialogueEntry>();
}

[Serializable] public class DialogueEntry
{
    public string id;
    
    [TextArea(2, 5)]
    public string text;
}