using DatabaseManagers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.DataHolders;
using WarehouseManager.Objects;

namespace WarehouseManager.Managers
{
    public static class GuiSearchManager
    {
        public static List<int> GetButtonsContaining(List<Product> products)
        {                   
            ButtonConnectionHolder.connections = ButtonsClient.GetButtonConnections();
            List<int> unitButtons = GetUnitButtonsContaining(products);
            bool added = true;

            List<int> allButtonsContaining = new List<int>();

            foreach (ButtonConnection connection in ButtonConnectionHolder.connections)
            {
                if (unitButtons.Contains(connection.UnitButtonID))
                {
                    allButtonsContaining.Add(connection.CollectionButtonId);
                }
            }

            while (added)
            {
                foreach (ButtonConnection connection in ButtonConnectionHolder.connections)
                {
                    if (allButtonsContaining.Contains(connection.UnitButtonID))
                    {
                        allButtonsContaining.Add(connection.CollectionButtonId);
                        added = true;
                    }
                }
                added = false;
            }


            allButtonsContaining.AddRange(unitButtons);

            return allButtonsContaining;
        }

        private static List<int> GetUnitButtonsContaining(List<Product> products)
        {            
            UnitProductConnectionHolder.Connections = ButtonsClient.GetUnitPorductConnections();

            List<int> buttonsIDs = new List<int>();

            foreach (UnitProductConnection connection in UnitProductConnectionHolder.Connections)
            {
                if (products.Select(elem => elem.id).Contains(connection.ProductId))
                {
                    buttonsIDs.Add(connection.ButtonId);
                }
            }

            return buttonsIDs;
        }
    }
}
