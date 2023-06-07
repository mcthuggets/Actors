using Actors.Model;

namespace Actors.Repository
{
    public class ActorRepository:IActorRepository
    { 
        public ActorRepository() { }
        
        public void addActor(IActor actor) {
            Console.WriteLine(7);
        }
        public void removeActor(IActor actor) {
            Console.WriteLine(actor.id);
        }
        public void updateActor(IActor actor) {
            Console.WriteLine(actor.surname);
        }
        public IEnumerable<IActor> getAll() { 
         
        return  null;
        }


        public IActor findActor(IActor actor) { return null; }
    }
}
