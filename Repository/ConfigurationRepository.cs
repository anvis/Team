using DataLayer.Models;
using DomainEntity;
using System;
using System.Collections.Generic;


namespace Repository
{
  public  class ConfigurationRepository : BaseRepository<Configurations>, IConfigurationRepository
    {
        public void setConfigurations()
        {
            List<Configurations> configs = new List<Configurations>();
            configs.Add(new Configurations
            {
                ConfigurationsId = 1,
                MaxAllRoundersAllowed = 2,
                MaxBatsmensAllowed = 5,
                MaxBowlersAllowed = 4,
                MaxExtraPlayersAllowed = 3
            });

            configs.Add(new Configurations
            {
                ConfigurationsId = 2,
                MaxAllRoundersAllowed = 2,
                MaxBatsmensAllowed = 5,
                MaxBowlersAllowed = 4,
                MaxExtraPlayersAllowed = 3
            });

            foreach (var item in configs)
            {
                Repository.Insert(item);
            }
            Repository.SaveAllChanges();
        }
    }
}
