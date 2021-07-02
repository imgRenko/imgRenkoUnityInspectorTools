using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace imgRenkoPlugins.InspectorEditorCustomer.Tools
{
    public class EditorLayoutSizeCalculator
    {
        private UIElementCollection layoutElementsCollection = new UIElementCollection();

        private float layoutHeight = 60.0f;

        public EditorLayoutSizeCalculator(float layoutRectHeight)
        {
            layoutHeight = layoutRectHeight;
        }

        public void ReadUIElement()
        {
            layoutElementsCollection.ClearAllElements();
            
        }
    }

    public class UIElementCollection
    {
        private List<UIElement> layoutElements = new List<UIElement>();


        public void ClearAllElements()
        {
            layoutElements.Clear();
        }

        public UIElement this[string param]
        {
            get
            {
                foreach (var tarElements in layoutElements)
                {
                    if (tarElements.Name.Equals(param))
                        return tarElements;
                }
                //TODO: Add a console system to do this.
                return null;
            }
            set
            {
                int count = 0;
                foreach (var tarElements in layoutElements)
                {
                    if (tarElements.Name.Equals(param))
                    {
                        layoutElements[count] = value;
                    }
                    count++;
                    
                }
            }

        }
        public class UIElement
        {
            public Rect elementRect;
            public string Name = "UIElement";
        }
    }
}