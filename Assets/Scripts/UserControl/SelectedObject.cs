using UserControl.Abstractions;

namespace UserControl
{
    public class SelectedObject : ISelectedObject
    {
        private ISelectable _currentObject;
        
        public void Set(ISelectable obj)
        {
            if (obj != _currentObject)
            {
                _currentObject?.Unselect();
            }
            
            _currentObject = obj;
            _currentObject.Select();
        }

        public ISelectable Get()
        {
            return _currentObject;
        }
    }
}