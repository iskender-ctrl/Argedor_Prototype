using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChooseButtonsManager : MonoBehaviour
{
    public GameObject characters;
    public void ChooseCharacter(int index)
    {
        for (int i = 0; i < characters.transform.childCount; i++)
        {
            characters.transform.GetChild(i).gameObject.SetActive(true);
            ChooseCharacterManager.instance.index = index;
            
            if (i != index)
            {
                characters.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
