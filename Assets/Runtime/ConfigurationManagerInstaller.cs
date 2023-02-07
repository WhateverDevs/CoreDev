using UnityEngine;
using WhateverDevs.Core.Runtime.Configuration;
using WhateverDevs.Core.Runtime.Persistence;
using WhateverDevs.Localization.Runtime;

/// <summary>
/// Extenject installer for the Configuration Manager.
/// We inject different persisters depending on if we want the user to have a local persistent copy of the config.
/// </summary>
[CreateAssetMenu(menuName = "Test/DI/ConfigurationManagerInstaller",
                 fileName = "ConfigurationManagerInstaller")]
public class ConfigurationManagerInstaller : WhateverDevs.Core.Runtime.Configuration.ConfigurationManagerInstaller
{
    /// <summary>
    /// Set the persisters for each of the configs, then call the base injection.
    /// </summary>
    public override void InstallBindings()
    {
        // Add the persister to persistent data first to the configurations we want so
        // they will first try to load the persistent data path copy and then the local copy.
        Container.Bind<IPersister>()
                 .To<ConfigurationJsonFilePersisterOnPersistentDataPath>()
                 .AsCached()
                 .WhenInjectedInto<LocalizerConfiguration>()
                 .Lazy();

        // All configurations should use the local folder as it is our way to distribute configs.
        Container.Bind<IPersister>()
                 .To<ConfigurationJsonFilePersisterOnLocalFolder>()
                 .AsCached()
                 .WhenInjectedInto<IConfiguration>()
                 .Lazy();

        base.InstallBindings();
    }
}