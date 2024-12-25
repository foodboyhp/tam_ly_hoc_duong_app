using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginController : MonoBehaviour
{
    public void OnLoginButtonTap()
    {
        SceneManager.LoadScene("Home");
    }


}
