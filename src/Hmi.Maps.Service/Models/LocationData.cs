using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks; 
using GoogleApi.Entities.Maps.Geolocation;


namespace Hmi.Maps.Service.Models
    {
        public class LocationData 
        {
            private string name;
        /// <summary>
        /// Gets or sets the name of the location.
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { Name=this.name; }
        }

        private string address;
        /// <summary>
        /// Gets or sets the address of the location.
        /// </summary>
        public string Address
        {
            get { return this.address; }
            set { Address=this.address; }
        }

        private object currentPosition;

        public object CurrentPosition
        {
            get{return this.currentPosition;}
            set{
                currentPosition= GoogleApi.
            }
        }


                

        
        }


    }