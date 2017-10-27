using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;
using UnityEngine;

public class ParseXML : MonoBehaviour {

    // Use this for initialization
    void Start () {
        List<Dictionary<int, object>> allTextDic = parseFile();
        Dictionary<int, object> dic = allTextDic[0];
        Debug.Log(dic[0]);
    }
	
    public List<Dictionary<int, object>> parseFile()
    {
        TextAsset txtXmlAsset = Resources.Load<TextAsset>("animometer");
        var doc = XDocument.Parse(txtXmlAsset.text);
        int node = 0;

        var allDict = doc.Element("animometer").Elements("tick");

        List<Dictionary<int, object>> allTextDic = new List<Dictionary<int, object>>();

        foreach (var oneDict in allDict)
        {
            XElement direction = oneDict.Element("direction");
            string dir = direction.ToString().Replace("<direction>", "").Replace("</direction>", "");
            XElement speed = oneDict.Element("speed");
            string sp = speed.ToString().Replace("<speed>", "").Replace("</speed>", "");
            XElement duration = oneDict.Element("duration");
            string dur = duration.ToString().Replace("<duration>", "").Replace("</duration>", "");

            Dictionary<int, object> dictionary = new Dictionary<int, object>();
            dictionary.Add(node++, new { direction = dir, speed = sp, duration = dur });
            allTextDic.Add(dictionary);
        }

        return allTextDic;
    }
    

    // Update is called once per frame
    void Update () {
		
	}
}
