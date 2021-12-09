using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class ReadTowerOrzaXml : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ReadXml();
    }

    // Update is called once per frame
    void ReadXml()
    {
        TextAsset textAsset = (TextAsset)Resources.Load("TowerOrzaXml");
        Debug.Log(textAsset);
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(textAsset.text);

        XmlNodeList nodes = xmlDoc.SelectNodes("rows/row");

        foreach (XmlNode node in nodes)
        {
            Debug.Log("SceneType:: " + node.SelectSingleNode("Load").InnerText);
            Debug.Log("floor:: " + node.SelectSingleNode("0").InnerText);
            Debug.Log("SceneName:: " + node.SelectSingleNode("LoadS").InnerText);
            Debug.Log("SceneCode:: " + node.SelectSingleNode("0").InnerText);
        }
    }
}
