using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DCS_Compendium
{
    public class Vehicle
    {
        private string _name;
        private string _type;
        private string _class;
        private string _image;
        private string _weakness;
        private string _description;
        private string _formToOpen;
        private static Vehicle _instance;
        private static List<VehicleDBSetup> _vehicleListInstance;
        private static VehicleDBSetup _vehicleInfoInstance;
        private static VehicleDBSetup _vehicleUpdateInstance;
        private static VehicleDBSetup _vehicleDeleteInstance;


        public string GetName
        {
            get { return _name; }
            set { _name = value; }
        }
        public string GetTheType
        {
            get { return _type; }
            set { _type = value; }
        }
        public string GetClass
        {
            get { return _class; }
            set { _class = value; }
        }
        public string GetImage
        {
            get { return _image; }
            set { _image = value; }
        }
        public string GetWeakness
        {
            get { return _weakness; }
            set { _weakness = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public static Vehicle Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Vehicle();
                return _instance;
            }
        }
        public string FormToOpen { get; set; }

        public static List<VehicleDBSetup> vehicleListInstance
        {
            get
            {
                if (_vehicleListInstance == null)
                    _vehicleListInstance = new List<VehicleDBSetup>();
                return _vehicleListInstance;
            }
        }
        public static VehicleDBSetup vehicleInfoInstance
        {
            get
            {
                if (_vehicleInfoInstance == null)
                    _vehicleInfoInstance = new VehicleDBSetup();
                return _vehicleInfoInstance;
            }
            set
            {
                _vehicleInfoInstance = value;
            }
        }

        public static VehicleDBSetup vehicleUpdateInstance
        {
            get
            {
                if (_vehicleUpdateInstance == null)
                    _vehicleUpdateInstance = new VehicleDBSetup();
                return _vehicleUpdateInstance;
            }
            set
            {
                _vehicleUpdateInstance = value;
            }
        }
        public static VehicleDBSetup vehicleDeleteInstance
        {
            get
            {
                if (_vehicleDeleteInstance == null)
                    _vehicleDeleteInstance = new VehicleDBSetup();
                return _vehicleDeleteInstance;
            }
            set
            {
                _vehicleDeleteInstance = value;
            }
        }

        public Vehicle(string name, string type, string Class, string image, string weakness, string description) // don't need this because VehicleDBSetup handles this stuff, but this is here just in case.
        {
            _name = name;
            _type = type;
            _class = Class;
            _image = image;
            _weakness = weakness;
            _description = description;
        }
        public Vehicle()
        {

        }
    }
}
