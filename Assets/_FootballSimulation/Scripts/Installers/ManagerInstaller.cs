using Thirtwo.Managers;
using Thirtwo.Serializer.Simulation;
using Zenject;

public class ManagerInstaller : Installer<ManagerInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<SimulationSerializer>().AsSingle();
        Container.BindInterfacesTo<SimulationManager>().AsSingle();
    }
}