using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SurveyController : MonoBehaviour
{
    [SerializeField] Transform m_ContentTransform;
    [SerializeField] Question m_QuestionPrefab;
    private List<Question> m_QuestionList = new List<Question>();
    private bool m_Submitable;

    public int TotalPoint
    {
        get
        {
            int ans = 0;
            for (int i = 0; i < m_QuestionList.Count; i++)
            {
                if (m_QuestionList[i].currentAnswer != null)
                {
                    ans += m_QuestionList[i].currentAnswer.point;
                }
            }
            return ans;
        }
    }

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        var questionListData = SOManager.instance.questionListData;
        for (int i = 0; i < questionListData.questionListData.Count; i++)
        {
            var question = Instantiate(m_QuestionPrefab, m_ContentTransform);
            question.Init(questionListData.questionListData[i]);
            question.SetupState(QuestionState.NotAnswered);
            m_QuestionList.Add(question);
        }
    }

    public void OnSubmitButtonTap()
    {
        if (IsSubmitable())
        {
            int ans = 0;
            for (int i = 0; i < m_QuestionList.Count; i++)
            {
                if (m_QuestionList[i].currentAnswer != null)
                {
                    ans += m_QuestionList[i].currentAnswer.point;
                }
            }
            PlayerPrefs.SetInt("Latest Survey Result", ans);
            Debug.Log(ans);
            SceneManager.LoadScene("Result");

        }
    }

    public bool IsSubmitable()
    {
        for (int i = 0; i < m_QuestionList.Count; i++)
        {
            if (m_QuestionList[i].questionState.Equals(QuestionState.NotAnswered))
            {
                return false;
            }
        }
        return true;
    }
}
