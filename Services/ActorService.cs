using Actors.Model;
using Actors.Repository;

namespace Actors.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _ActorRepository= new ActorRepository();
        public ActorService() { }
        public void addActor(IActor actor) {
        _ActorRepository.addActor(actor);
        }
        public void removeActor(IActor actor) {
        _ActorRepository.removeActor(actor);
        }
        public void updateActor(IActor actor) {
           _ActorRepository.updateActor(actor);
        }

        public IEnumerable<IActor> getAll() {
        return  _ActorRepository.getAll();
        }

        public IActor findActor(IActor actor) { return _ActorRepository.findActor(actor);}
    }
}
