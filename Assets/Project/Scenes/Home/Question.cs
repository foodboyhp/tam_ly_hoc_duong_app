using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum QuestionState
{
    IsAnswered,
    NotAnswered
}
public class Question : MonoBehaviour
{
    [SerializeField] Transform m_ContentTransform;
    [SerializeField] Answer m_AnswerPrefab;
    private List<Answer> m_AnswerList;
    private QuestionState m_QuestionState;
    public QuestionState questionState => m_QuestionState;
    private void Init()
    {
        var questionListData = SOManager.instance.questionListData;
        for (int i = 0; i < questionListData.questionListData.Count; i++)
        {
            var answer = Instantiate(m_AnswerPrefab, m_ContentTransform);
            answer.SetupState(AnswerState.Clickable);
            m_AnswerList.Add(answer);
        }
    }

    public void SetupState(QuestionState state)
    {
        m_QuestionState = state;
    }

    public void OnEditButtonTap()
    {
        for (int i = 0; i < m_AnswerList.Count; i++)
        {
            m_AnswerList[i].SetupState(AnswerState.Clickable);
        }
    }
}
