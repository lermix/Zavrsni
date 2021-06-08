using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class Enums
    {
        public enum ButtonTypes
        {
            Unit,
            Collection
        }

        public enum DocumentTypes
        {
            receipt,
            intermediateWarehouse,
            writeOff,
            returnToSupplier
        }


    public enum PartnerType
        {
            supplier,
            transporter
        }

        public enum WorkerPosition
        {
            driver,
            warehouseWorker,
            manager
        }

        public enum Searchable
        {
            products,
            routes,
            workers,
            avaliableWorkers,
            locations,
            vehicles,
            avaliableVehicles,
            partner,
            warehouse,
            avaliableDrivers
        }
        public enum SearchOption
        {
            StartsWith,
            EndsWith,
            GreaterThan,
            LessThan
        }

        public enum ReportTypes
        {
            vehicle,
            worker,
            route,
            received,
            intermediateWarehouse,
            returned,
            writeOff
        }

        public enum DistanceUnits
        {
            kilometers,
            meters,
            miles,
            yards,
            feets
        }
        public enum WeightUnits
        {
            kilograms,
            grams,
            pounds
        }
        public enum PropertyName
        {
            distance,
            weight
        }

    }
}
