using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ResultController : MonoBehaviour
{

    [SerializeField] TMP_Text m_ResultText;
    [SerializeField] TMP_Text m_DiagnoseText;
    private void Start()
    {
        int result = PlayerPrefs.GetInt("Latest Survey Result");
        m_ResultText.text = "Ket qua la: " + result;
        m_DiagnoseText.text = DiagnoseResult(result);
    }

    private string DiagnoseResult(int result)
    {
        string res = "";
        if (result >= 0 && result <= 13)
        {
            res = "You are not depressed";
        }
        else if (result >= 14 && result <= 19)
        {
            res = "You are slightly depressed";
        }
        else if (result >= 20 && result <= 28)
        {
            res = "You are depressed";
        }
        else if (result >= 29)
        {
            res = "You are severely depressed";
        }
        return res;
    }
    public void OnBackButton()
    {
        SceneManager.LoadScene("Home");
    }
}
