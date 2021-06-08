using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //DO NOT CHANGE PROPERTYES NAMES DATABASE IS CONNECTED BY PROPERTY NAME, 
    //IF NAME IS CHANGED NEW PROCEDURES ARE TO BE MADE
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double purchasePrice { get; set; }
        public double sellingPrice { get; set; }
        public Size size { get; set; }
        public string mesuringUnit { get; set; }
        public double weight { get; set; }
        public DateTime dateOfArival { get; set; }
        public DateTime dateOfShipment { get; set; }
        public double numberAvalible { get; set; }
        public string barcode { get; set; }      

        public Product()
        {
            size = new Size();
        }
        public Product(Product product)
        {
            id = product.id;
            name = product.name;
            description = product.description;
            purchasePrice = product.purchasePrice;
            sellingPrice = product.sellingPrice;
            size = product.size;
            mesuringUnit = product.mesuringUnit;
            weight = product.weight;
            dateOfArival = product.dateOfArival;
            dateOfShipment = product.dateOfShipment;
            numberAvalible = product.numberAvalible;
            barcode = product.barcode;

        }
    }
}                 
