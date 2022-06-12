using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class blackHoleNameInput : MonoBehaviour
{

    public TMP_InputField input;

    private void Awake()
    {
        input.onEndEdit.AddListener(value => {
            PlayerPrefs.SetString("name", value);
        });
    }

}
