namespace Repository.Utility
{
    using DataLayer;
    using DataLayer.Models;
    using RepositoryCore;
    using System;

    public class Repo : IDisposable
    {
        private bool disposed = false;
        private TournamentRepository tournamentRepository;
        private ConfigurationRepository configurationRepository;
        public TeamContext Context { get; } = new TeamContext();

        
        public Repo()
        {
           
        }
        public ITournamentRepository TournamentRepository
        {
            get
            {
                if (this.tournamentRepository == null)
                {
                    this.tournamentRepository = RepositoryInstance<TournamentRepository>.GetInstance();
                    tournamentRepository.Repository = new Repository<Tournment>(Context);
                }
                return tournamentRepository;
            }
        }

        public IConfigurationRepository ConfigurationRepository
        {
            get
            {
                if (this.configurationRepository == null)
                {
                    this.configurationRepository = RepositoryInstance<ConfigurationRepository>.GetInstance();
                    configurationRepository.Repository = new Repository<Configurations>(Context);
                }
                return configurationRepository;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
