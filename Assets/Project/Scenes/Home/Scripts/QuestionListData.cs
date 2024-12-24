using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Data/QuestionListData")]
public class QuestionListData : ScriptableObject
{
    public List<QuestionData> questionListData;
}

[Serializable]
public class QuestionData
{
    public string question;
    public List<AnswerData> answer;
}

[Serializable]
public class AnswerData
{
    public string answer;
    public int point;
}
