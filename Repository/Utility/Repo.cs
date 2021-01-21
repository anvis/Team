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
                    //  watchlistRepository.Context = context;
                }
                return tournamentRepository;
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
