using UnityEngine;

[CreateAssetMenu(menuName ="NPC information", fileName ="New NPC info")] 
public class NPCInfo : ScriptableObject
{
    public string npcName;
    public string catchphrase;
    public Sprite npcSpirte;

    public int armourLevel;
    public float npcSpeed;

    public bool isFriendly;
}
public class PotionInfo : ScriptableObject
{
    public Color potionColour;
    public string discription;




}
