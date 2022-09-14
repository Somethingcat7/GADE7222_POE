using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class GetText : MonoBehaviour
{
   public Transform ContentWindow;
   public GameObject recallTextObjects;

   void start()
   {
      string readFromFilePath = Application.streamingAssetsPath + "/Recall_Chat/" + "Chat" + ".txt";
      List<string> fileLines = File.ReadAllLines(readFromFilePath).ToList();

      foreach (string line in fileLines)
      {
         Instantiate(recallTextObjects, ContentWindow);
         recallTextObjects.GetComponent<Text>().text = line;
      }

   }
   
}
