using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
public class DialogueSystem : MonoBehaviour
{
    public Transform ContentWindow;
    public int num = 0;
    public int numCount = 0;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        LinkList<string> dialogue = new LinkList<string>();

        string readFromFilePath = Application.streamingAssetsPath + "/Recall_Chat/" + "Chat" + ".txt";
        List<string> fileLines = File.ReadAllLines(readFromFilePath).ToList();

        foreach (string line in fileLines)
        {
            num++;
            Instantiate(ContentWindow);

            if (num == 1)
            {
                dialogue.AddHeadNode(line);
            }
            else
            {
                dialogue.AddTailNode(line);
            }

        }

        numCount = 1;
        text.text = dialogue.;

    }

    public void NextDialogueLine()
    {

    }
}
