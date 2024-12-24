using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOManager : Singleton<SOManager>
{
    [SerializeField] QuestionListData m_QuestionListData;
    public QuestionListData questionListData => m_QuestionListData;
}
