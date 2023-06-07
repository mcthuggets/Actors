using Actors.Model;

namespace Actors.Repository
{
    public interface IActorRepository
    {
        
        public void addActor(IActor actor);
        public void removeActor(IActor actor);
        public void updateActor(IActor actor);

        public IEnumerable<IActor> getAll();

        public IActor findActor(IActor actor);
    }
}
