using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFlow : MonoBehaviour
{
    public Text
        TextBox;

    public GameObject textboxGO;

    bool 
        bNarration, 
        bOldMan;

    string
        Narrator    = "Narration : ",
        OldMan      = "Old Man : ";

    string
       line_1   =    "line 1 ",
       line_2   =    "line 2 ",
       line_3   =    "line 3 ",
       line_4   =    "line 4 ",
       line_5   =    " ",
       line_6   =    " ",
       line_7   =    " ",
       line_8   =    " ",
       line_9   =    " ",
       line_10  =    " ";

    string
        currentSentence,
        nextSentence;

    public float
        textTimer = 0,
        fadeTimer = 15,
        changeTimer = 30;

    int lineNumber;

    // Start is called before the first frame update
    void Start()
    {
        textTimer = 20;
        currentSentence = line_1;
    }

    // Update is called once per frame
    void Update()
    {
        textTimer += textTimer * Time.deltaTime * 0.2f;

        if(textTimer > changeTimer)
        {
            textboxGO.SetActive(true);
            TextBox.text = LineChange(WhichLine(lineNumber));
            
        }
        else if(textTimer > fadeTimer)
        {
            textboxGO.SetActive(false);
        }
        else
        {
            TextBox.text = currentSentence;
        }
    }


    /// <summary>
    /// switches the line that will show 
    /// </summary>
    /// <param name="comingUp"> what will be set as the next sentence </param>
    string LineChange(string comingUp)
    {
        if (comingUp != null)
        {
            currentSentence = nextSentence;
            textTimer = 1;
            nextSentence = comingUp;

            textTimer = 0.1f;
        }
        return currentSentence;
    }

    void FadeLine()
    {

    }

    string WhichLine(int lineNo)
    {
        string line = " ";

        if (lineNo == 1)
            line = line_1;
        else if (lineNo == 2)
            line = line_2;
        else if (lineNo == 3)
            line = line_3;
        else if (lineNo == 4)
            line = line_4;
        else if (lineNo == 5)
            line = line_5;
        else if (lineNo == 6)
            line = line_6;
        else if (lineNo == 7)
            line = line_7;
        else if (lineNo == 8)
            line = line_8;
        else if (lineNo == 9)
            line = line_9;
        else
            line = line_10;


        return line;
    }
}
