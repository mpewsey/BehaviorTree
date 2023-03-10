using UnityEditor;
using UnityEngine;

namespace MPewsey.BehaviorTree.Editor
{
    /// <summary>
    /// The behavior tree custom editor.
    /// </summary>
    [CustomEditor(typeof(BehaviorTree))]
    public class BehaviorTreeEditor : UnityEditor.Editor
    {
        /// <summary>
        /// Creates a new behavior tree.
        /// </summary>
        [MenuItem("GameObject/Behavior Tree/Behavior Tree", priority = 20)]
        public static void CreateBehaviorTree()
        {
            var obj = new GameObject("Behavior Tree");
            obj.AddComponent<BehaviorTree>();
            obj.transform.SetParent(Selection.activeTransform);
        }
    }
}