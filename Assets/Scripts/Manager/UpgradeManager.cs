using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
 
public class UpgradeManager : MonoBehaviour 
 {
     [XmlAttribute("name")]
     public float test;
   
}
[XmlRoot("UpgradeSaves")]
 class SaveMananger
 {
     [XmlArray("Upgrades"), XmlArrayItem("Upgrade")]
     public UpgradeManager[] Upgrades; //change that to class with 

     public void Save(string path)
     {
         var serializer = new XmlSerializer(typeof(UpgradeManager));
         using (var stream = new FileStream(path, FileMode.Create))
         {
             serializer.Serialize(stream, this);
         }
     }

     public static UpgradeManager Load(string path)
     {
         var serializer = new XmlSerializer(typeof(UpgradeManager));
         using (var stream = new FileStream(path, FileMode.Open))
         {
             return serializer.Deserialize(stream) as UpgradeManager;
         }
     }
 }