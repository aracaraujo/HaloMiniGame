using HaloMiniGame.Game.Services;
using HaloMiniGame.Game.Casting;


namespace HaloMiniGame.Game.Scripting
{
   

    public class CollideEnemyAction : Action
    {
        private AudioService audioService;
        private PhysicsService physicsService;
        
        public CollideEnemyAction(PhysicsService physicsService,AudioService audioService)
        {
            this.audioService = audioService;
            this.physicsService = physicsService;
        }

        // public void Execute(Cast cast, Script script, ActionCallback callback)
        // {
        //     MC mC = (MC)cast.GetFirstActor(Constants.MC_GROUP);
        //     Enemy enemy = (Enemy)cast.GetFirstActor(Constants.ENEMY_GROUP);
        //     Body MCBody = mC.GetBody();
        //     Body EnemyBody = enemy.GetBody();
        //     int health = mC.GetHealth();

        //     if (physicsService.HasCollided(MCBody, EnemyBody))
        //     {
        //         health = health -1;
        //         mC.SetHealth(health);
        //         cast.RemoveActor(Constants.ENEMY_GROUP, enemy);
        //         Console.WriteLine(mC.health);
        //     }

        public void Execute(Cast cast, Script script, ActionCallback callback)
        {
            MC mC = (MC)cast.GetFirstActor(Constants.MC_GROUP);
            List<Actor> enemies = cast.GetActors(Constants.ENEMY_GROUP);
            
            foreach (Actor actor in enemies)
            {
                Enemy enemy = (Enemy)actor;
                Body MCBody = mC.GetBody();
                Body EnemyBody = enemy.GetBody();
                int health = mC.GetHealth();
                Stats stats = (Stats)cast.GetFirstActor(Constants.STATS_GROUP);


                if (physicsService.HasCollided(MCBody, EnemyBody))
                {
                    health = health -1;
                    stats.RemoveLife();
                    mC.SetHealth(health);
                    cast.RemoveActor(Constants.ENEMY_GROUP, enemy);
                    Console.WriteLine(mC.health);
                }
            }
            
        }
    }
}