using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Questions1 : MonoBehaviour {

    public GameObject QuestionUI;
    public string[,] qString = new string[15,2];
    public static int qNum;
    public Text QuestionText;
	// Use this for initialization
	void Start () {
        qString[0, 0] = "White-box testing is a method of testing software that tests _______ structures of an application \n A.internal\nB. Inner\nC.External\nD.Outer";
        qString[0, 1] = "A";
        qString[1, 0] = "Black-box testing is a method of testing software that examines the _______ of the application \n A.Practicality\nB. Functionality\nC.Efficiency\nD.Popularity";
        qString[1, 1] = "B";
        qString[2, 0] = "True or False?Black-box testing is done by testers.\nA.True\nB.False\nC. ----\nD. ----";
        qString[2, 1] = "A";
        qString[3, 0] = "Fill in the blank. _______-box testing is a method of testing the application at the level of the source code.\nA.White\nB.Black\nC.Grey\nD. Lazy";
        qString[3, 1] = "A";
        qString[4, 0] = "True or False? White-box testing is mostly done by developers.\nA.True\nB.False\nC. ----\nD. ----";
        qString[4, 1] = "A";
        qString[5, 0] = "True or False? In White-box testing knowledge of implementation is not required.\nA.True\nB.False\nC. ----\nD. ----";
        qString[5, 1] = "B";
        qString[6, 0] = "True or False? In Black-box testing knowledge of implementation is required.\nA.True\nB.False\nC. ----\nD. ----";
        qString[6, 1] = "A";
        qString[7, 0] = "What is an advantage of Black box testing? Choose one.\nA. Separation between user’s and developer’s perspectives. B. Limited coverage since only a fraction of test scenarios is performed. \nC. Blind coverage since tester has limited knowledge about the application.\nD. ----";
        qString[7, 1] = "A";
        qString[8, 0] = "What is a disadvantage of Black box testing? Choose one.\nA. Code access is not required\nB. Separation between user’s and developer’s perspectives.\nC. Inefficient testing due to tester’s lack of knowledge about software internals.";
        qString[8, 1] = "A";
        qString[9, 0] = "What is an advantage of white-box testing?\nA. It helps optimize the code\nB. It is inexpensive\nC. It is not time - consuming\nD. ----";
        qString[9, 1] = "A";
        qString[10, 0] = "What is disadvantage of white-box testing? Choose one.\nA. Covers all possible paths of a code thereby, empowering a software engineering team to conduct thorough application testing\nB. Requires code access\nC. Without clear and concise specifications, test cases are hard to design\nD. ----";
        qString[10, 1] = "A";
        qString[11, 0] = "Fill in the blank. _______- box testing may leave many program paths untested.\nA.White\nB.Black\nC.Grey\nD. Lazy";
        qString[11, 1] = "A";
        qString[12, 0] = "Fill in the blank. ________-box testing forces the developer to take a closer look at implementation.\nA.White\nB.Black\nC.Grey\nD. Lazy";
        qString[12, 1] = "A";
        qString[13, 0] = "Fill in the blank. _______-box testing is used for verifying input methods and outputs of the systems.\nA.White\nB.Black\nC.Grey\nD. Lazy";
        qString[13, 1] = "A";
        qString[14, 0] = "Fill in the blank. _______-box testing can be applied at the unit, integration and system levels of the software testing process.\nA.White\nB.Black\nC.Grey\nD. Lazy";
        qString[14, 1] = "A";
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Space))
        {
            ToggleThis();
        }
    }
     void ToggleThis()
    {

        if (!QuestionUI.activeInHierarchy)
        {
            Debug.Log("SETTING ACTIVE");
            QuestionUI.SetActive(true);
            setQuestion();
        }
        else
        {
            Debug.Log("SETTING DEACTIVE");
            QuestionUI.SetActive(false);

        }
       
        
        
    }

    int generateQuestion()
    {
        qNum = Random.Range(0,15);

        return qNum;
    }

    
    void setQuestion()
    {
        int qNum = generateQuestion();
        QuestionText.text = qString[qNum, 0]; 
    }
    
    public void checkA()
    {
        if (qString[qNum, 1] == "A")
        {
            //set bg to green, "Correct!", timer, close window, destroy wb monster, add money
            QuestionText.text = "Correct!";
            //    YieldInstruction WaitForSeconds(1);
            ToggleThis();

            GameObject WhiteEnemy = GameObject.FindGameObjectWithTag("Enemy2");
            Enemy targetWhiteEnemy = WhiteEnemy.GetComponent<Enemy>();
            targetWhiteEnemy.TakeDamage(99999);

        }
        else
        {
            //set bg to red, "Wrong!", timer, close window,
            QuestionText.text = "Wrong!";
            ToggleThis();
        }

    }
    public void checkB()
    {
        if (qString[qNum, 1] == "B")
        {
            //set bg to green, "Correct!", timer, close window, destroy wb monster, add money
            QuestionText.text = "Correct!";
            //    YieldInstruction WaitForSeconds(1);
            ToggleThis();

            GameObject WhiteEnemy = GameObject.FindGameObjectWithTag("Enemy2");
            Enemy targetWhiteEnemy = WhiteEnemy.GetComponent<Enemy>();
            targetWhiteEnemy.TakeDamage(99999);

        }
        else
        {
            //set bg to red, "Wrong!", timer, close window,
            QuestionText.text = "Wrong!";
            ToggleThis();
        }

    }
   public void checkC()
    {
        if (qString[qNum, 1] == "C")
        {
            //set bg to green, "Correct!", timer, close window, destroy wb monster, add money
            QuestionText.text = "Correct!";
            //    YieldInstruction WaitForSeconds(1);
            ToggleThis();

            GameObject WhiteEnemy = GameObject.FindGameObjectWithTag("Enemy2");
            Enemy targetWhiteEnemy = WhiteEnemy.GetComponent<Enemy>();
            targetWhiteEnemy.TakeDamage(99999);

        }
        else
        {
            //set bg to red, "Wrong!", timer, close window,
            QuestionText.text = "Wrong!";
            ToggleThis();
        }
    }
   public void checkD()
    {
        if (qString[qNum, 1] == "D")
        {
            //set bg to green, "Correct!", timer, close window, destroy wb monster, add money
            QuestionText.text = "Correct!";
            //    YieldInstruction WaitForSeconds(1);
            ToggleThis();

            GameObject WhiteEnemy = GameObject.FindGameObjectWithTag("Enemy2");
            Enemy targetWhiteEnemy = WhiteEnemy.GetComponent<Enemy>();
            targetWhiteEnemy.TakeDamage(99999);

        }
        else
        {
            //set bg to red, "Wrong!", timer, close window,
            QuestionText.text = "Wrong!";
            ToggleThis();
        }

    }
}
