/*
 * Author:      Dave Manley
 * Date:        01/14/2013
 * Description: Configuration - Library for managing configuration (.cfg) file data
 * Dependencies: ErrorMsg
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace TCPAsync
{
    public static class Configuration
    {
        private static String file = Application.StartupPath + "\\TCPAsync.cfg", errorName = "Configuration File", appName = "TCPAsync";
        public static Dictionary<String, String> Properties;
        public static void init()
        {
            if (!File.Exists(file))
            {
                ErrorMsg.ThrowError("Configuration file not found. Please restore configuration file <" + file + ">", appName + " Configuration File Error", ErrorMsg.MsgLevel.critical, null);
                Application.Exit();
                return;
            }
            Properties = new Dictionary<String, String>();
            Configuration.read();
        }
        private static void clear()
        {
            Properties.Clear();
        }
        public static void read()
        {
            String currentConfiguration = "";
            XmlTextReader xmldoc;
            Stack tree = new Stack();
            String tmp = "";
            Dictionary<String, String> Propertiestmp = new Dictionary<String, String>();
            xmldoc = new XmlTextReader(file);
            try
            {
                while (xmldoc.Read())
                {
                    switch (xmldoc.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            switch (xmldoc.Name.Trim())
                            {
                                case "PROPERTIES":
                                    currentConfiguration = xmldoc.Name.Trim();
                                    tree.Push(xmldoc.Name.Trim());
                                    break;
                                default:
                                    tree.Push(xmldoc.Name.Trim());
                                    break;
                            }
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                            switch (currentConfiguration)
                            {
                                case "PROPERTIES":
                                    if (tree.Peek().ToString() != currentConfiguration)
                                        tmp=xmldoc.Value.Trim();
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case XmlNodeType.EndElement: //Display the end of the element.
                            switch (xmldoc.Name.Trim())
                            {
                                case "PROPERTIES":
                                    break;
                                default:
                                    switch (currentConfiguration)
                                    {
                                        case "PROPERTIES":
                                            Propertiestmp.Add(tree.Peek().ToString(), tmp);
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                            }
                            if (tree.Peek().ToString() == xmldoc.Name.Trim())
                                tree.Pop();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                xmldoc.Close();
                ErrorMsg.ThrowError("There was a problem parsing the configuration file: <" + file + ">.", errorName+" Error", ErrorMsg.MsgLevel.critical, ex);
            }
            xmldoc.Close();
            clear();
            Properties = Propertiestmp;
         }
        public static bool save()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNode xmlnode;
            XmlElement xmlelem;

            //xml declaration and root node
            xmlnode = xmldoc.CreateNode(XmlNodeType.XmlDeclaration, "", "");
            xmldoc.AppendChild(xmlnode);

            //properties XML node compilation
            xmlelem = xmldoc.CreateElement("", "PROPERTIES", "");
            foreach (KeyValuePair<String, String> kvp in Properties)
            {
                XmlElement xmlelem3;
                xmlelem3 = xmldoc.CreateElement("", kvp.Key, "");
                //if (kvp.Value == 0)
                    xmlelem3.AppendChild(xmldoc.CreateTextNode(kvp.Value));
                //if (kvp.Value.Count == 1)
                    //xmlelem3.AppendChild(xmldoc.CreateTextNode((String)kvp.Value[0]));
                /*else
                    for (int i = 0; i < kvp.Value.Count; i++)
                    {
                        XmlElement xmlelem4;
                        xmlelem4 = xmldoc.CreateElement("", "string", "");
                        xmlelem4.AppendChild(xmldoc.CreateTextNode((String)kvp.Value[i]));
                        xmlelem3.AppendChild(xmlelem4);
                    }*/
                xmlelem.AppendChild(xmlelem3);
            }


            //append root XML to document
            xmldoc.AppendChild(xmlelem);
            //write document
            try
            {
                xmldoc.Save(file);
            }
            catch (Exception ex)
            {
                ErrorMsg.ThrowError("Configuration file could not be saved. Make sure it is not read only.", appName + " Configuration File Warning", ErrorMsg.MsgLevel.warning, ex);
            }
            return true;
        }
        public static bool set(String key, String value)
        {

            try
            {
                Properties.Add(key, value);
            }
            catch (ArgumentException)
            {
                Properties[key] = value;
            }
            return true;
        }
        public static String get(String key)
        {
            
            if (!Properties.ContainsKey(key))
            {
                ErrorMsg.ThrowError("Could not find configuration value: <" + key + ">.", appName + " Configuration File Error", ErrorMsg.MsgLevel.critical, new Exception("Dictionary key not found"));
                Application.Exit();
                return null;
            }
            else
                return Properties[key].ToString();
            return null;
        }
        public static Boolean has(String key)
        {
            return Properties.ContainsKey(key);
        }
    }
}