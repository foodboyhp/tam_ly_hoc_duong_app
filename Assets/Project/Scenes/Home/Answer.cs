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

    public void Setup(AnswerData answerData)
    {
        m_AnswerText.text = answerData.answer;
    }

    public void SetupState(AnswerState state)
    {

    }
}
