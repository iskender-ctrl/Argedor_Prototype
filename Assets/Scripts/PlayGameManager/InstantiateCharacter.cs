using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCharacter : MonoBehaviour
{
    public List<GameObject> charactersList = ChooseCharacterManager.instance.Characters;
    int index = ChooseCharacterManager.instance.index;
    void Start()
    {
        Instantiate(charactersList[index], Vector3.zero, charactersList[index].transform.rotation);
    }
}
