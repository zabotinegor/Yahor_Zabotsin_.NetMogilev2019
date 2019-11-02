﻿namespace GameComponents
{
    public abstract class FieldObject
    {
        internal (int X, int Y) Coordinates { get; set; }

        protected FieldObject((int x, int y) coordinates)
        {
            Coordinates = coordinates;
        }

        protected abstract void Explode(int damage);
    }
}
