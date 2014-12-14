using System;
using System.Collections.Generic;
using System.Text;

#region ---(Using Adicionais)
/// <summary>
/// using
/// </summary>
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.IO;

///
#endregion
 
namespace App_SQL_Conections
///namespace App_SQL_Conections._2Class
{
    class ConnectionSaveFileXML
    {


        #region ---(..........Metodo Contrutor..........)---

        /// <summary>
        /// Metodo Plublico ConnectionSaveFileXML
        /// </summary>
        public ConnectionSaveFileXML()
        {

        }

        #endregion 
        
        #region ---(..........Variaveis..........)---
        private XmlTextWriter xml_text_writer;

        /// <summary>
        /// XML Criador de Textos
        /// </summary>
        public XmlTextWriter XML_text_writer
        {
            get { return xml_text_writer; }
            set { xml_text_writer = value; }
        }


        #endregion






        /// <summary>
        /// Retorna Nome App e Local
        /// </summary>
        /// <returns></returns>
        public Tuple <String, String> FU_GetAppName_AppDir()
        {
            String AppName, AppDir;
            (AppName) = (Path.GetFileNameWithoutExtension(Application.ExecutablePath)); ///item1
            (AppDir) = (Directory.GetCurrentDirectory().ToString());    ///item2
            return Tuple.Create(AppName, AppDir);
        }

        /// <summary>
        /// Editor XML
        /// </summary>
        public void FU1_XML_Editor_CriarSalvar()
        {
            XML_text_writer = new XmlTextWriter(((FU_GetAppName_AppDir().Item1) + ".xml"), System.Text.Encoding.UTF8);
            XML_text_writer.WriteStartDocument(true);
            XML_text_writer.Formatting = Formatting.Indented;
            XML_text_writer.Indentation = 2;
            XML_text_writer.WriteComment(("EditorXML...: ") + (FU_GetAppName_AppDir().Item1) + (".exe ")) ;
            XML_text_writer.WriteStartElement("SQLConnectionDataBase");
            FU2_XML_Editor_Preencher("SQLServerStringBuilder", "192.168.11.200", "master", "true", "sa", "a", "30", XML_text_writer);
            XML_text_writer.WriteEndElement();
            XML_text_writer.WriteEndDocument();
            XML_text_writer.Close();
            MessageBox.Show("Aquivo XML Salvo com Sucesso");
        }

        /// <summary>
        ///  Componentes para Preencher XML
        /// </summary>
        public void FU2_XML_Editor_Preencher(string Type, string DataSource, string InitialCatalog, string IntegratedSecurity, string UserID, string Password, string ConnectTimeout, XmlTextWriter writer)
        {
            writer.WriteStartElement("DBConnection"); ///1 Start

            writer.WriteStartElement("IDType");  ///2
            writer.WriteString(Type);            ///2
            writer.WriteEndElement();            ///2

            writer.WriteStartElement("DataSource"); ///3
            writer.WriteString(DataSource);         ///3
            writer.WriteEndElement();               ///3

            writer.WriteStartElement("InitialCatalog"); ///4
            writer.WriteString(InitialCatalog);         ///4
            writer.WriteEndElement();                   ///4

            writer.WriteStartElement("IntegratedSecurity"); ///5
            writer.WriteString(IntegratedSecurity);         ///5
            writer.WriteEndElement();                       ///5

            writer.WriteStartElement("User"); ///6
            writer.WriteString(UserID);       ///6
            writer.WriteEndElement();         ///6

            writer.WriteStartElement("Password"); ///7
            writer.WriteString(Password);         ///7
            writer.WriteEndElement();             ///7

            writer.WriteStartElement("ConnectTimeout"); ///8
            writer.WriteString(ConnectTimeout);         ///8
            writer.WriteEndElement();                   ///8

            writer.WriteEndElement(); ///1 End
        }
    }
}
