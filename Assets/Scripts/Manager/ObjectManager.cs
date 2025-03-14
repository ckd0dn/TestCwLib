using CWLib;
using UnityEngine;

public class ObjectManager : BaseObjectManager
{
    public override T Spawn<T>(string key)
    {
        throw new System.NotImplementedException();
    }

    public override void Despawn<T>(T obj)
    {
        throw new System.NotImplementedException();
    }
}
