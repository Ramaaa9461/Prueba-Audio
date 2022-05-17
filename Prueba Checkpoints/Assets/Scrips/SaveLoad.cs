using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public const string savePos = "SavePoisiton";
    void Update()
    {
    }

    public void savePosition(float positionZ)
    {
        PlayerPrefs.SetFloat(savePos, positionZ);
    }
}
