using System;
using System.Collections.Generic;
using System.Text;

namespace ClubManagement.Services
{
  public  class DbSetting
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string FormationCollectionName { get; set; }
        public DbSetting() { }
    }
}
