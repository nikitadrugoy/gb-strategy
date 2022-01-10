using Core.Abstractions;
using GameLoop.Abstractions;
using UnityEngine;
using UserControl.Abstractions;

namespace UserControl
{
    public class UserInput : IUserInput, IUpdatable
    {
        private readonly Camera _camera;

        private RaycastHit[] _hits = new RaycastHit[5];

        public UserInput(Camera camera)
        {
            _camera = camera;
        }

        public void Update(float deltaTime)
        {
            // TODO move mouse interactions to specific classes
            if (Input.GetMouseButtonUp(0))
            {
                int hitCount = Physics.RaycastNonAlloc(_camera.ScreenPointToRay(Input.mousePosition), _hits);

                if (hitCount > 0)
                {
                    for (var i = 0; i < hitCount; i++)
                    {
                        if (_hits[i].collider.TryGetComponent(out ISelectable selectableObject))
                        {
                            selectableObject.Select();
                            
                            break;
                        }
                    }
                }
            }
        }
    }
}