using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class LoginScript : MonoBehaviour {

    public string u = "word";
    public string p = "pass";

   // public enum LoginStates { correct, wrong}
    //public LoginStates currentState;

    public InputField UserField;
    public InputField PassField;
    public Text incorrectText;


    public void onPress () {

        incorrectText.enabled = false;

        string usernameString = UserField.text;
        string passwordString = PassField.text;

        if (usernameString == u && passwordString == p)
        {
            Debug.Log("Welcome");
            incorrectText.enabled = true;
            incorrectText.text = "Welcome!";

        }
        else
        {
            Debug.Log("Wrong password/Username");
            incorrectText.enabled = true;
            incorrectText.text = "Incorrect username or password.";
           
        }
    }
}
