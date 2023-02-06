using UnityEngine;

public interface IMovementable<T>
{
   public void Move(T sensivity,T speed);
}
