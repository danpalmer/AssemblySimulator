using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Reflection;

namespace Assembly_Simulator
{
    class XMLInstructionParser
    {
        private string pathToXML;

        public XMLInstructionParser(string path)
        {
            pathToXML = path;
        }

        public string[,] GetInstructions()
        {
            int index = 0;

            // This has been changed to use the Instructions.dat file embedded in the application file
            //XmlReader read = XmlReader.Create(pathToXML);
            XmlReader reader = XmlReader.Create(Assembly.GetExecutingAssembly().GetManifestResourceStream("Assembly_Simulator." + pathToXML));

            reader.MoveToContent();

            // Count the number of instruction nodes
            while (reader.ReadToFollowing("instruction"))
            {
                index++;
            }

            reader.Close();
            string[,] instructionArray = new string[index, 5];
            index = 0;
            // This has been changed to use the Instructions.dat file embedded in the application file
            reader = XmlReader.Create(Assembly.GetExecutingAssembly().GetManifestResourceStream("Assembly_Simulator." + pathToXML));
            reader.MoveToContent();

            // Read through and add values to array
            while (reader.ReadToFollowing("instruction"))
            {
                reader.ReadToFollowing("name");
                instructionArray[index, 0] =
                    reader.ReadElementContentAsString("name", reader.NamespaceURI);

                reader.ReadToFollowing("detail");
                instructionArray[index, 1] =
                    reader.ReadElementContentAsString("detail", reader.NamespaceURI);

                reader.ReadToFollowing("OPCODE");
                instructionArray[index, 2] =
                    reader.ReadElementContentAsString("OPCODE", reader.NamespaceURI);

                reader.ReadToFollowing("colour");
                instructionArray[index, 3] =
                    reader.ReadElementContentAsString("colour", reader.NamespaceURI);

				reader.ReadToFollowing("allowlabel");
				instructionArray[index, 4] = 
					reader.ReadElementContentAsString("allowlabel", reader.NamespaceURI);
					
                index++;
            }

            reader.Close();

            return instructionArray;
        }
    }
}
