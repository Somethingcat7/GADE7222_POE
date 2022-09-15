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
    public Text txtDialogue;

    Queue<string> queue;


    // Start is called before the first frame update
    void Start()
    {
        LinkList<string> dialogue = new LinkList<string>();

        string readFromFilePath = Application.streamingAssetsPath + "/Chat.txt";
        List<string> fileLines = File.ReadAllLines(readFromFilePath).ToList();

        /*var text = Resources.Load("Chat") as TextAsset;*/

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
        queue = new Queue<string>();

        for (int i = 0; i < fileLines.Count; i++)
        {
            queue.AddToQueue(fileLines[i]);
        }

        txtDialogue.text = queue.LookInQueue();

    }

    public void NextDialogueLine()
    {
        queue.Dequeue();
        txtDialogue.text = queue.LookInQueue();
    }
}
