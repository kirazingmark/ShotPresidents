using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System.Xml.Serialization; // Might not be using this in the end.
using System.IO;
using System;
using System.Xml;
// using UnityEngine.UI; // This is for testing purposes, final version won't need it.

public class LoadXMLFile : MonoBehaviour {

    public TextAsset xmlRawFile;
    // public Text uiText;
    public double convertedData;

    // Use this for initialization
    void Start()
    {
        string data = xmlRawFile.text;
        parseXmlFile(data);
    }

    void parseXmlFile(string xmlData)
    {
        string beatTimes = "";
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(new StringReader(xmlData));

        string xmlPathPattern = "//SongData/BeatTimes";
        XmlNodeList myNodeList = xmlDoc.SelectNodes(xmlPathPattern);

            foreach (XmlNode node in myNodeList)
        {
            XmlNode double_val = node.FirstChild;
            beatTimes = double_val.InnerXml;
            convertedData = Convert.ToDouble(beatTimes);
            //print(beatTimes);
            //Console.WriteLine(convertedData);
            int index = 0;
            while (index < 782)
            {
                XmlNode nextNode = double_val.NextSibling;
                beatTimes = nextNode.InnerXml;
                convertedData = Convert.ToDouble(beatTimes);
                //print(beatTimes);
                index++;
            }
        }
    }
}
