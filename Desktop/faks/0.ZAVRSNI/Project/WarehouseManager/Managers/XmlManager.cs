using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WarehouseManager.Objects;

namespace WarehouseManager.Managers
{
    class XmlManager
    {
       /*public static string DragButtonsXmlLoaction = @"../../Data/DragButtons.xml";
        
        static XDocument DragButtonsXml = XDocument.Load(DragButtonsXmlLoaction);


        public static string addDragButonToXml(DragButton dragButtonToAdd, int GuiId)
        {          
            if (dragButtonToAdd == null) { return "No Button selected"; }            

            var targetGui = DragButtonsXml.Root.Elements().Where(e => e.Attribute("ID").Value == GuiId.ToString()).Single();
            if (targetGui == null)
            {                
                return "No gui with that id";
            }

            Debug.WriteLine("Appending objet to xml.");

            var dragButtonElement = new XElement("DragButton");

            //Atributes to add
            List<XAttribute> dragButtonAtributes = new List<XAttribute>
            {
                new XAttribute("ID", dragButtonToAdd.id),
                new XAttribute("name", dragButtonToAdd.Name),
                new XAttribute("text", dragButtonToAdd.Text),
                new XAttribute("left", dragButtonToAdd.Left),
                new XAttribute("top", dragButtonToAdd.Top),
            };

            //Add atributes
            foreach (XAttribute xAtribut in dragButtonAtributes)
            {
                dragButtonElement.Add(xAtribut);
            }

            //Add element
            targetGui.Add(dragButtonElement);

            //Save
            DragButtonsXml.Save(DragButtonsXmlLoaction);

            return "Succesful add";
            }
        }

        public static Get()
        {
            Console.WriteLine("reading Articles");
            ArticleCollection articles = new ArticleCollection();

            //For it to work each class property needs definition as how will it be stored in xml  
            //Each xElement is presented with a class and its properties with attributes
            XmlSerializer serializer = new XmlSerializer(typeof(ArticleCollection));

            //Reads the document and stores it in reader variable
            using (StreamReader reader = new StreamReader(AllArticlesXmlLoaction))
            {
                articles = (ArticleCollection)serializer.Deserialize(reader);
            }

            Console.WriteLine("reading succesful, count: " + articles.articles.Count);
            return articles;
        }

        public static BillCollection GetBills()
        {
            Console.WriteLine("reading bills");
            BillCollection bills = new BillCollection();

            XmlSerializer serializer = new XmlSerializer(typeof(BillCollection));

            using (StreamReader reader = new StreamReader(AllBillXmlLoaction))
            {
                bills = (BillCollection)serializer.Deserialize(reader);
            }

            Console.WriteLine("reading succesful");
            return bills;
        }

        public static void ReplaceArticle(Article newArticle)
        {
            var target = AllArticlesXml.Root.Elements().Where(e => e.Attribute("ID").Value == newArticle.ID.ToString()).Single();
            target.Attribute("price").Value = newArticle.price.ToString();
            AllArticlesXml.Save(AllArticlesXmlLoaction);
        }

        public static void DeleteArticle(Article articleToDelete)
        {
            var target = AllArticlesXml.Root.Elements().Where(e => e.Attribute("ID").Value == articleToDelete.ID.ToString()).Single();
            target.Remove();
            AllArticlesXml.Save(AllArticlesXmlLoaction);
        }

        //Max 1000 after that it collides with bills
        public static int getNextIDArticle()
        {
            int target = AllArticlesXml.Root.Elements().Max(e => (int)e.Attribute("ID"));
            return target + 1;
        }

        public static void DeleteAllArticles()
        {
            var target = AllArticlesXml.Root.Elements();
            target.Remove();
        }

        public static void DeleteAllBills()
        {
            var target = AllBillsXml.Root.Elements();
            target.Remove();
        }

        public static void AddList(List<Object> listToAdd)
        {
            foreach (Object item in listToAdd)
            {
                addObjectToXml(item);
            }
        }*/
    }
}
