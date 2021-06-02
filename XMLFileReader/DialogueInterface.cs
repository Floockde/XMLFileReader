using System.Collections.Generic;
using System.Xml;
using System.Windows.Forms;

namespace XMLFileReader
{
    public sealed class DialogueInterface
    {


        //Initiate Xml reader.
        XmlTextReader reader = null;

        //New SortedList that takes an Int key and a String value.
        SortedList<int, string> dialogueOrder = new SortedList<int, string>();

        private static DialogueInterface instance = null;

        private DialogueInterface()
        {

        }

        //An instance that starts the interface.
        public static DialogueInterface Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DialogueInterface();
                }
                return instance;
            }
        }

        //Xml file preloader.
        public void Preload(string file)
        {
            try
            {
                reader = new XmlTextReader(file);
                reader.WhitespaceHandling = WhitespaceHandling.None;
            }
            catch
            {
                if (reader != null)
                    reader.Close();
            }
        }









        //Getting the dialogues from characters and identifying each node.
        public SortedList<int, string> GetDialogue(string scene)
        {
            //Clearing the loaded file to make space for a new one.
            dialogueOrder.Clear();

            reader.Read(); //Read into each nodes.
            reader.Read();
            if (reader.Name != "story")
            {
                          //An exception that plays when there are no root node 'story' tag.
                throw new NoStoryException("There is no root 'story' tag");
            }
         
            //This While loop keeps playing until the reader finds the node 'scene'.
            while (reader.Read())
            {
                
                if (reader.GetAttribute("scene") == scene)
                {
                    break;
                }
            }

            //In case the while above doesn't find the scene tag, this exception will be thrown.
            if (reader.EOF == true)
            {
                throw new NoSceneException("There is no 'scene' tag or scene not specified with an index.");
            }


            //Going through the name nodes and dialogue nodes.
            while (reader.Read())
            {

                //Loop until it finds the node with 'name' tag.
                if (reader.Name == "name") 
                {
                    reader.Read();
                    //Saving the text on 'name' tag in Value.
                    string v = reader.Value; 
                    reader.Read();
                    reader.Read();

                    //If the loop doesn't find the dialogue tag, it will throw this exception.
                    if (reader.Name != "dialogue")
                    {
                        throw new NoDialogueException("There is no 'dialogue' tag.");
                    }

                    //If it did managed to find the 'dialogue' tag however, its value will be saved and added to the SortedList.------------------         
                    int d = int.Parse(reader.GetAttribute("dialogue"));                                                                         //
                    reader.Read();                                                                                                              //
                    string t = reader.Value;                                                                                                    //
                    dialogueOrder.Add(d,v + System.Environment.NewLine + System.Environment.NewLine + t + System.Environment.NewLine);          //
                    //----------------------------------------------------------------------------------------------------------------------------
                }

                //If the scene node that this If detects, this While loop will exit.--------------------------------------------------------------
                if (reader.Name == "scene")                                                                                                     //
                {                                                                                                                               //
                    if (reader.NodeType == XmlNodeType.EndElement)                                                                              //
                    {                                                                                                                           //
                        break;                                                                                                                  //
                    }                                                                                                                           //
                }                                                                                                                               //
                //--------------------------------------------------------------------------------------------------------------------------------
            }


            //If there are no 'name' tag, this exception is thrown.
            if (dialogueOrder.Count == 0)
            {
                throw new NoNameException("There is no 'name' tag.");
            }

            return dialogueOrder;
        }










        //Exclusive sorter for 'description' tag.
        public string GetDescription(string scene)
        {
            //These readers skip som nodes that should be coming before 'description' tag.
            reader.Read();
            reader.Read();
            
            //Thrown if there are no 'story' root tag.
            if (reader.Name != "story")
            {
                throw new NoStoryException("There is no root 'story' tag");
            }

            //Loop to find the 'scene' tag.
            while (reader.Read())
            {

                if (reader.GetAttribute("scene") == scene)
                {
                    break;
                }
            }

            //If no 'scene' tag, this exception is thrown.
            if (reader.EOF == true)
            {
                throw new NoSceneException("There is no 'scene' tag.");
            }

            string desc = "";

            //Loop to find 'description' tag.
            while (reader.Read())
            {

                if (reader.Name == "description")
                {
                    reader.Read();
                    desc = reader.Value;

                    break;
                }
                //Thrown exception if there are no 'description' tag.
                else 
                {
                    throw new NoDescriptionException("There is no 'description' tag");
                }
            }
            return desc;
        }
    }

}






