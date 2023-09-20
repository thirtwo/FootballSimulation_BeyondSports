using UnityEngine;

namespace Thirtwo.Serializer
{
    public interface ISerializer
    {
        public TextAsset DeserializedAsset { get;}
        public void SerializeData();
    }
}