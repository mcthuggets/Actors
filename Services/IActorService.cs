using Actors.Model;
using Actors.Repository;

namespace Actors.Services
{
    public interface IActorService
    {
        
        public void addActor(IActor actor);
        public void removeActor(IActor actor);
        public void updateActor(IActor actor);

        public IEnumerable<IActor> getAll();

        public IActor findActor(IActor actor);
    }
}
