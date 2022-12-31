using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCharacter : MonoBehaviour
{
    public List<GameObject> charactersList = ChooseCharacterManager.instance.Characters;
    int index = ChooseCharacterManager.instance.index;
    void Start()
    {
        GameObject player = Instantiate(charactersList[index], Vector3.zero, charactersList[index].transform.rotation);
        player.GetComponent<PlayerMovement>().enabled = true;
        player.transform.GetChild(2).gameObject.SetActive(true);
    }
}
