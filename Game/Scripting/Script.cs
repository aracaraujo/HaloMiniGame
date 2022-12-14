using HaloMiniGame.Game.Services;
using HaloMiniGame.Game.Casting;
using HaloMiniGame.Game.Directing;


namespace HaloMiniGame.Game.Scripting
{
    /// <summary>
    /// A collection of actions.
    /// </summary>
    public class Script
    {
        private Dictionary<string, List<Action>> actions = new Dictionary<string, List<Action>>();

        /// <summary>
        /// Constructs a new instance of Script.
        /// </summary>
        public Script()
        {
        }

        /// <summary>
        /// Adds the given action to the given group.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <param name="action">The action to add.</param>
        public void AddAction(string group, Action action)
        {
            if (!actions.ContainsKey(group))
            {
                actions[group] = new List<Action>();
            }

            if (!actions[group].Contains(action))
            {
                actions[group].Add(action);
            }
        }

        /// <summary>
        /// Clears the actions in the given group.
        /// </summary>
        /// <param name="group">The given group.</param>
        public void ClearActions(string group)
        {
            if (actions.ContainsKey(group))
            {
                actions[group] = new List<Action>();
            }
        }

        /// <summary>
        /// Clears all the actions in the script.
        /// </summary>
        public void ClearAllActions()
        {
            foreach(string group in actions.Keys)
            {
                actions[group] = new List<Action>();
            }
        }

        /// <summary>
        /// Gets the actions in the given group. Returns an empty list if there aren't any.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <returns>The list of actions.</returns>
        public List<Action> GetActions(string group)
        {
            List<Action> results = new List<Action>();
            if (actions.ContainsKey(group))
            {
                results.AddRange(actions[group]);
            }
            return results;
        }

        /// <summary>
        /// Removes the given action from the given group.
        /// </summary>
        /// <param name="group">The group name.</param>
        /// <param name="action">The action to remove.</param>
        public void RemoveAction(string group, Action action)
        {
            if (actions.ContainsKey(group))
            {
                actions[group].Remove(action);
            }
        }

    }
}