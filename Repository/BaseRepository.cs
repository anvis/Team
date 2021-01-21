using DataLayer;
using Repository.Utility;
using RepositoryCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class BaseRepository<T> where T : class //, IDisposable
    {
        Repo repo = new Repo();
        protected BaseRepository()
        {
        }
        private Repository<T> repository { get; set; }

        public Repository<T> Repository
        {
            get
            {
                return repository;
            }
            set
            {
                repository = value;
            }
        }

        public TeamContext Context
        {
            get
            {
                return repo.Context;
            }
        }
    }


}
