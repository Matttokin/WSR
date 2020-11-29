using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WSR.DataBase;
using WSR.DataBase.Models;

namespace WSR.Controllers
{
    public class getTokenController : ApiController
    {
        
        public User Post(string login, string password)
        {
            Context db = new Context();
            //var roleId = db.Roles.FirstOrDefault(x => x.Name == )
            var user = db.Users.FirstOrDefault(x => x.Login == login && x.Password == password && x.Role.Name == "Курьер") ;
            if(user == null)
            {
                return null;
            } else
            {
                return user;
            }
        }
    }
}
