using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurveyController : MonoBehaviour
{
    [SerializeField] Transform m_ContentTransform;
    [SerializeField] Question m_QuestionPrefab;
    private List<Question> m_QuestionList = new List<Question>();
    private bool m_Submitable;

    private void Init()
    {
        var questionListData = SOManager.instance.questionListData;
        for (int i = 0; i < questionListData.questionListData.Count; i++)
        {
            var question = Instantiate(m_QuestionPrefab, m_ContentTransform);
            m_QuestionList.Add(question);
        }
    }

    public void OnSubmitButtonTap()
    {

    }
}
