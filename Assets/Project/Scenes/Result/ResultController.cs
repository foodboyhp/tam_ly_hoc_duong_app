using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ResultController : MonoBehaviour
{

    [SerializeField] TMP_Text m_ResultText;
    [SerializeField] List<TMP_Text> m_DiagnoseTexts = new List<TMP_Text>();
    private void Start()
    {
        int result = PlayerPrefs.GetInt("Latest Survey Result");
        m_ResultText.text = "Ket qua la: " + result;
        DiagnoseResult(result);
    }

    private void DiagnoseResult(int result)
    {
        if (result >= 0 && result <= 13)
        {
            m_DiagnoseTexts[0].text = "Không trầm cảm, tiền stress";
            m_DiagnoseTexts[1].text = "Bạn chưa có dấu hiệu của trầm cảm, nhưng cũng đừng bỏ quên việc chăm sóc sức khỏe tâm lý của mình nha!";
        }
        else if (result >= 14 && result <= 19)
        {
            m_DiagnoseTexts[0].text = "Trầm cảm nhẹ";
            m_DiagnoseTexts[1].text = "Bạn đang có dấu hiệu không tích cực về tâm lý, hãy trao đổi với mọi người xung quanh về tình trạng của mình!";
        }
        else if (result >= 20 && result <= 28)
        {
            m_DiagnoseTexts[0].text = "Trầm cảm";
            m_DiagnoseTexts[1].text = "Bạn đang gặp vấn đề về tâm lý. Hãy thư giãn một chút và trao đổi với mọi người để giúp bản thân mình tìm được giải pháp nhé!";

        }
        else if (result >= 29)
        {
            m_DiagnoseTexts[0].text = "Trầm cảm nặng";
            m_DiagnoseTexts[1].text = "Hãy bày tỏ bản thân của mình, cũng như trao đổi với các chuyên viên tâm lý! Bạn không hề đơn độc trên con đường này đâu nhé!";

        }
    }
    public void OnBackButton()
    {
        SceneManager.LoadScene("Home");
    }
}
