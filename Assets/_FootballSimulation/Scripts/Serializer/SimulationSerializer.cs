using Newtonsoft.Json;
using System.Collections.Generic;
using Thirtwo.Data.Simulation;
using UnityEngine;

namespace Thirtwo.Serializer.Simulation
{
    public sealed class SimulationSerializer : ISerializer
    {
        private List<SimulationData> simulationDatas;
        private readonly TextAsset deserializedAsset;
        public TextAsset DeserializedAsset { get => deserializedAsset; }
        //TO:DO impleemnt DI & Inject from DI depend on time
        public SimulationSerializer(TextAsset deserializedAsset)
        {
            this.deserializedAsset = deserializedAsset;
        }
        public void SerializeData()
        {
            simulationDatas = new List<SimulationData>();
            var lines = deserializedAsset.text.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                var data = JsonConvert.DeserializeObject<SimulationData>(lines[i]);
                if (data != null)
                {
                    simulationDatas.Add(data);
                    //TO:DO add a logger class and control all the logs in advance
                    //Debug.Log(JsonConvert.SerializeObject(simulationDatas[i]));
                }
                else
                {
                    continue;
                }

            }
        }
        public List<SimulationData> GetSimulationDatas()
        {
            return simulationDatas;
        }
    }
}
