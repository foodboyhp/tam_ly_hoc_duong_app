using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum QuestionState
{
    IsAnswered,
    NotAnswered
}
public class Question : MonoBehaviour
{
    [SerializeField] TMP_Text m_QuestionText;
    [SerializeField] Transform m_ContentTransform;
    [SerializeField] GameObject m_ShieldObject;
    [SerializeField] Answer m_AnswerPrefab;
    private List<Answer> m_AnswerList = new List<Answer>();
    private QuestionData m_QuestionData;
    private QuestionState m_QuestionState;
    public QuestionState questionState => m_QuestionState;
    public AnswerData currentAnswer = new AnswerData();

    public void Init(QuestionData questionData)
    {
        m_QuestionData = questionData;
        m_QuestionText.text = questionData.question;
        for (int i = 0; i < questionData.answerList.Count; i++)
        {
            var answer = Instantiate(m_AnswerPrefab, m_ContentTransform);
            answer.Setup(questionData.answerList[i], this);
            answer.SetupState(AnswerState.Clickable);
            m_AnswerList.Add(answer);
        }
    }

    public void SetupState(QuestionState state)
    {
        m_QuestionState = state;
        switch (m_QuestionState)
        {
            case QuestionState.IsAnswered:
                break;
            case QuestionState.NotAnswered:
                break;
            default:
                break;
        }
        m_ShieldObject.SetActive(m_QuestionState.Equals(QuestionState.IsAnswered));
    }

    public void OnEditButtonTap()
    {
        currentAnswer = new AnswerData();
        for (int i = 0; i < m_AnswerList.Count; i++)
        {
            m_AnswerList[i].SetupState(AnswerState.Clickable);
        }
        SetupState(QuestionState.NotAnswered);
    }

    public void ChooseAnswer(Answer answer)
    {
        currentAnswer = answer.AnswerData;
        for (int i = 0; i < m_AnswerList.Count; i++)
        {
            if (m_AnswerList[i] != answer)
            {
                m_AnswerList[i].SetupState(AnswerState.NotClickable);
            }
        }
        SetupState(QuestionState.IsAnswered);
    }
}
