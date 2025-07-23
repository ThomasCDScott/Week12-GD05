using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public GameObject statsCard;
    public TMP_Text npcName, npcCatchprase, npcArmour, npcSpeed, npcFriendly;
    public Image artwork;
  
    public void ShowCharacterCard(NPCInfo stats)
    {
        statsCard.SetActive(true);

        npcName.text = "My name is " + stats.npcName;
        npcCatchprase.text = stats.catchphrase;
        npcArmour.text = "Have an armour level of " + stats.armourLevel;
        npcSpeed.text = "I have a speed of " + stats.npcSpeed;
        artwork.sprite = stats.npcSpirte;

        if(stats.isFriendly)
        {
            npcFriendly.text = "Good Morning";
        }
        else
        {
            npcFriendly.text = "Get out of here!";
        }

    }
}
