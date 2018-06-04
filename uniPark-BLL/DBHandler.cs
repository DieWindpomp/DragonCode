﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLib.Models;
using TypeLib.ViewModels;
using TypeLib.Interfaces;
using uniPark_DAL;
using System.Data;


namespace uniPark_BLL
{
    public class DBHandler : IDBHandler
    {
        private IDBAccess db;

        public DBHandler()
        {
            db = new DBAccess();

        }
        public DataTable BLL_GetLevels()
        {
            return db.GetLevels();
        }
        public DataTable BLL_GetTypes()
        {
            return db.GetTypes();
        }

        public bool BLL_AddPersonel(string PersonelID, string PersonelTagNumber, string PersonelPassword, string PersonelSurname, string PersonelName, string PersonelPhoneNumber, string PersonelEmail, int PersonelLevelID, int PersonelTypeID)
        {
            return db.AddPersonel(PersonelID, PersonelTagNumber, PersonelPassword, PersonelSurname, PersonelName, PersonelPhoneNumber, PersonelEmail, PersonelLevelID, PersonelTypeID);
        }

        public DataTable BLL_GetParkingAreas()
        {
          return  db.GetParkingAreas();
        }
        public DataTable BLL_GetParkingSpaces(string parkinngAreaID)
        {
            return db.GetParkingSpaces(parkinngAreaID);
        }
        public DataTable BLL_SearchParkingSpaceDetails(string parkingAreaID, string parkingSpaceID)
        {
            return db.SearchParkingSpaceDetails(parkingAreaID,parkingSpaceID);
        }
       public uspLogin BLL_Login(string userid)
        {
            return db.Login(userid);
        }

}
}
