using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Cryptography;

public enum AnswerState
{
    Clickable,
    Chosen,
    NotClickable
}
public class Answer : MonoBehaviour
{
    [SerializeField] TMP_Text m_AnswerText;
    [SerializeField] GameObject m_ChosenShield;
    [SerializeField] GameObject m_LockedShield;
    private Question m_BelongedQuestion;
    private AnswerState m_AnswerState;
    private AnswerData m_AnswerData;
    public AnswerState answerState => m_AnswerState;
    public AnswerData AnswerData => m_AnswerData;

    public void Setup(AnswerData answerData, Question question)
    {
        m_AnswerText.text = answerData.answer;
        m_AnswerData = answerData;
        m_BelongedQuestion = question;
    }

    public void SetupState(AnswerState state)
    {
        m_AnswerState = state;
        switch (m_AnswerState)
        {
            case AnswerState.Clickable:
                break;
            case AnswerState.NotClickable:
                break;
            case AnswerState.Chosen:
                break;
            default:
                break;
        }
        m_ChosenShield.SetActive(m_AnswerState.Equals(AnswerState.Chosen));
    }

    public void OnAnswerButtonTap()
    {
        if (m_AnswerState.Equals(AnswerState.Clickable))
        {
            SetupState(AnswerState.Chosen);
            m_BelongedQuestion.ChooseAnswer(this);
            Debug.Log(m_AnswerData.point);
        }
    }
}
