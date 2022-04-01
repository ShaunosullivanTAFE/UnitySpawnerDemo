using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingScript : MonoBehaviour
{

    public Dropdown dropDown;
    private int _dropDownIndex;
    private Text _selectedText;

    // Start is called before the first frame update
    void Start()
    {
        dropDown.value = PlayerPrefs.GetInt("Difficulty", 0);
    }

    public void SetDifficulty()
    {
        _dropDownIndex = dropDown.value;
        PlayerPrefs.SetInt("Difficulty", _dropDownIndex);
        PlayerPrefs.Save();
        SceneManager.LoadScene("MenuScreen");
    }


}
