using System;

namespace RepositoryApp
{
    public class Printer
    {
        private readonly IRepository repository;

        public Printer(IRepository repository)
        {
            this.repository = repository;
        }

        public void PrinOneEntity()
        {
            Console.WriteLine(repository.GetEntity());
        }

        public void PrinAllEntities()
        {
            foreach (var entity in repository.GetEntities())
            {
                Console.WriteLine(entity);
            }
        }
    }
}
