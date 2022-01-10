namespace UserControl.Abstractions
{
    public interface ISelectedObject
    {
        void Set(ISelectable obj);
        ISelectable Get();
    }
}