using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacterManager : MonoBehaviour
{
    public static ChooseCharacterManager instance;
    public List<GameObject> Characters = new List<GameObject>();
    public Vector3 targetPos;
    public Transform parentGameObject;
    public int index;
    private void Start()
    {
        instance = this;
        for (int i = 0; i < Characters.Count; i++)
        {
            GameObject tmp = Instantiate(Characters[i].gameObject, targetPos, Characters[i].gameObject.transform.rotation, parentGameObject);
            tmp.SetActive(false);
        }
    }
}


