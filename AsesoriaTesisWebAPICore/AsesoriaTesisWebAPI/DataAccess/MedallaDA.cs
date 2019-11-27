using AsesoriaTesisWebAPI.CustomModels;
using AsesoriaTesisWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DataAccess
{
    public class MedallaDA
    {
        private readonly TutoriaContext dbContext;

        public MedallaDA()
        {
            dbContext = new TutoriaContext();
        }

        
    }
}
