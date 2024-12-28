using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Data/AccountListData")]

public class AccountListData : ScriptableObject
{

}

[Serializable]
public class AccountData
{
    public string account;
    public string password;
}
