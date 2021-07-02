using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using imgRenkoPlugins.InspectorEditorCustomer.Tools;
namespace imgRenkoPlugins.InspectorEditorCustomer.Drawer
{
    public class imgRenkoInspectorDrawer : PropertyDrawer
    {
        protected EditorLayoutSizeCalculator layoutEditor;

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            layoutEditor.ReadUIElement();
            return base.CreatePropertyGUI(property);
        }
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            OnUIElementLayoutGUI(position, property, label);
        }
        public virtual void OnUIElementLayoutGUI(Rect position, SerializedProperty property, GUIContent label) { 
        
        }
    }
}