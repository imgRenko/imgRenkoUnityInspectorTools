using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using imgRenkoPlugins.InspectorEditorCustomer.Attribute;
using imgRenkoPlugins.InspectorEditorCustomer.Config;
namespace imgRenkoPlugins.InspectorEditorCustomer.Drawer
{
    [CustomPropertyDrawer(typeof(MessageInfoBoxAttribute))]
    public class MessageInfoBoxDrawer : imgRenkoInspectorDrawer
    {
        float PropertyHeight = 66.0f;
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {

            return PropertyHeight;
        }
        
        public override void OnUIElementLayoutGUI(Rect position, SerializedProperty property, GUIContent label)
        {
          
            
            MessageInfoBoxAttribute baseObj = (MessageInfoBoxAttribute)base.attribute;

            PropertyHeight = baseObj.messageBoxHeight;

            EditorGUI.BeginProperty(position, label, property);

            float defaultPropertyHeight = InspectorEditorConfig.defaultPropertyHeight;
            
            position.height -= defaultPropertyHeight;
            EditorGUI.HelpBox(position,baseObj.tipText, baseObj.boxType);
            position.y += PropertyHeight - defaultPropertyHeight;
            position.height = defaultPropertyHeight;
            EditorGUI.PropertyField(position, property, label);
          //  EditorGUILayout.EndVertical();
            EditorGUI.EndProperty();

       
        }
    }
}