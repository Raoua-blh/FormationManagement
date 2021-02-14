using System;
using System.Collections.Generic;
using System.Text;
using ClubManagement.Entities;

namespace ClubManagement.Services
{
    public interface IFormationServices
    {
      Formation AddFormation(Formation formation);
        List<Formation> GetListFormations();
    }
}
