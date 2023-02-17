namespace Abstract_classes
{
    internal abstract class Vehicle
    {
        protected float Speed;
        public abstract void Move();
        public float GetCurrentSpeed()
        {
            return Speed;
        }
    }
}
