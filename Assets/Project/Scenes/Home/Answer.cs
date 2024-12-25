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
    private AnswerState m_AnswerState;
    public AnswerState answerState => m_AnswerState;

    public void Setup(AnswerData answerData)
    {
        m_AnswerText.text = answerData.answer;
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
    }

    public void OnAnswerButtonTap()
    {
        if (m_AnswerState.Equals(AnswerState.Clickable))
        {
            SetupState(AnswerState.Chosen);
        }
    }
}
