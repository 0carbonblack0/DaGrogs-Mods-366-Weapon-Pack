using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Eft.Common.Tables;
using SPTarkov.Server.Core.Models.Spt.Mod;
using SPTarkov.Server.Core.Models.Utils;
using SPTarkov.Server.Core.Services;
using SPTarkov.Server.Core.Services.Mod;

namespace _366TKMContentPack;

public record ModMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.sp-tarkov.examples.366TKMContentPack";
    public override string Name { get; init; } = "366TKMContentPack";
    public override string Author { get; init; } = "CarbonBased";
    public override List<string>? Contributors { get; init; }
    public override SemanticVersioning.Version Version { get; init; } = new("1.0.0");
    public override SemanticVersioning.Range SptVersion { get; init; } = new("~4.0.0");
    
    
    public override List<string>? Incompatibilities { get; init; }
    public override Dictionary<string, SemanticVersioning.Range>? ModDependencies { get; init; }
    public override string? Url { get; init; }
    public override bool? IsBundleMod { get; init; }
    public override string? License { get; init; } = "MIT";
}

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class CustomItemService366SKS(
    ISptLogger<CustomItemService366SKS> logger,
    CustomItemService customItemService) : IOnLoad
{

    public Task OnLoad()
    {
        //Example of adding new item by cloning an existing item using `createCloneDetails`
        var exampleCloneItem = new NewItemFromCloneDetails
        {
            ItemTplToClone = ItemTpl.ASSAULTCARBINE_TOZ_SIMONOV_SKS_762X39_CARBINE,
            // ParentId refers to the Node item the gun will be under, you can check it in https://db.sp-tarkov.com/search
            ParentId = "5447b5fc4bdc2d87278b4567",
            // The new id of our cloned item - MUST be a valid mongo id, search online for mongo id generators
            NewId = "6921ebb1ab12a7cadfbd3b42",
            // Flea price of item
            FleaPriceRoubles = 20000,
            // Price of item in handbook
            HandbookPriceRoubles = 20000,
            // Handbook Parent Id refers to the category the gun will be under
            HandbookParentId = "5b5f78e986f77447ed5636b1",
            //you see those side box tab thing that only select gun under specific icon? Handbook parent can be found in Spt_Data\Server\database\templates.
            Locales = new Dictionary<string, LocaleDetails>
            {
                {
                    "en", new LocaleDetails
                    {
                        Name = "Molot VPO-208 .366TKM Firearm",
                        ShortName = "VPO208",
                        Description = "A Molot VPO-208 .366 TKM semi-automatic firearm created to provide a civilian option similar to a traditional Toz Simonov SKS."
                    }
                }
            },
            OverrideProperties = new TemplateItemProperties
            {
                AmmoCaliber = "Caliber366TKM",
                Chambers =
                [
                    new Slot
                    {
                        Name = "patron_in_weapon",
                        Id = "574d982f24597745a21eb3e5",
                        Parent = "VPO208",
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "59e655cb86f77411dc52a77b",
                                        "59e6542b86f77411dc52a77a",
                                        "59e6658b86f77411d949b250",
                                        "5f0596629e22f464da6bbdd9"
                                    ]
                                }
                            ]
                        },
                        Required = false,
                        MergeSlotWithChildren = false,
                        Prototype = "55d4af244bdc2d962f8b4571"
                    }
                ]
            },
        };

        customItemService.CreateItemFromClone(exampleCloneItem); // Send our data to the function that creates our item
        
        return Task.CompletedTask;
    }
}

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class CustomItemService366OPSKS(
    ISptLogger<CustomItemService366OPSKS> logger,
    CustomItemService customItemService) : IOnLoad
{

    public Task OnLoad()
    {
        //Example of adding new item by cloning an existing item using `createCloneDetails`
        var exampleCloneItem = new NewItemFromCloneDetails
        {
            ItemTplToClone = ItemTpl.ASSAULTCARBINE_MOLOT_ARMS_SIMONOV_OPSKS_762X39_CARBINE,
            // ParentId refers to the Node item the gun will be under, you can check it in https://db.sp-tarkov.com/search
            ParentId = "5447b5fc4bdc2d87278b4567",
            // The new id of our cloned item - MUST be a valid mongo id, search online for mongo id generators
            NewId = "6921ed86ab12a7cadfbd3b44",
            // Flea price of item
            FleaPriceRoubles = 23000,
            // Price of item in handbook
            HandbookPriceRoubles = 23000,
            // Handbook Parent Id refers to the category the gun will be under
            HandbookParentId = "5b5f78e986f77447ed5636b1",
            //you see those side box tab thing that only select gun under specific icon? Handbook parent can be found in Spt_Data\Server\database\templates.
            Locales = new Dictionary<string, LocaleDetails>
            {
                {
                    "en", new LocaleDetails
                    {
                        Name = "Molot VPO-208M .366TKM Firearm",
                        ShortName = "VPO208M",
                        Description = "A Molot VPO-208M .366 TKM semi-automatic firearm created to provide a civilian option similar to a modernized Molot OP-SKS."
                    }
                }
            },
            OverrideProperties = new TemplateItemProperties
            {
                AmmoCaliber = "Caliber366TKM",
                Chambers =
                [
                    new Slot
                    {
                        Name = "patron_in_weapon",
                        Id = "574d982f24597745a21eb3e5",
                        Parent = "VPO208M",
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "59e655cb86f77411dc52a77b",
                                        "59e6542b86f77411dc52a77a",
                                        "59e6658b86f77411d949b250",
                                        "5f0596629e22f464da6bbdd9"
                                    ]
                                }
                            ]
                        },
                        Required = false,
                        MergeSlotWithChildren = false,
                        Prototype = "55d4af244bdc2d962f8b4571"
                    }
                ]
            },
        };

        customItemService.CreateItemFromClone(exampleCloneItem); // Send our data to the function that creates our item
        
        return Task.CompletedTask;
    }
}

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class CustomItemService366OPSKSA(
    ISptLogger<CustomItemService366OPSKSA> logger,
    CustomItemService customItemService) : IOnLoad
{

    public Task OnLoad()
    {
        //Example of adding new item by cloning an existing item using `createCloneDetails`
        var exampleCloneItem = new NewItemFromCloneDetails
        {
            ItemTplToClone = ItemTpl.ASSAULTCARBINE_MOLOT_ARMS_SIMONOV_OPSKS_762X39_CARBINE,
            // ParentId refers to the Node item the gun will be under, you can check it in https://db.sp-tarkov.com/search
            ParentId = "5447b5fc4bdc2d87278b4567",
            // The new id of our cloned item - MUST be a valid mongo id, search online for mongo id generators
            NewId = "6921eed3ab12a7cadfbd3b45",
            // Flea price of item
            FleaPriceRoubles = 33000,
            // Price of item in handbook
            HandbookPriceRoubles = 33000,
            // Handbook Parent Id refers to the category the gun will be under
            HandbookParentId = "5b5f78e986f77447ed5636b1",
            //you see those side box tab thing that only select gun under specific icon? Handbook parent can be found in Spt_Data\Server\database\templates.
            Locales = new Dictionary<string, LocaleDetails>
            {
                {
                    "en", new LocaleDetails
                    {
                        Name = "(Modified) Molot VPO-208M .366TKM Automatic Firearm",
                        ShortName = "Auto208M",
                        Description = "A Molot VPO-208M .366 TKM firearm modified to be fully automatic."
                    }
                }
            },
            OverrideProperties = new TemplateItemProperties
            {
                AmmoCaliber = "Caliber366TKM",
                WeapFireType = [ 
                "single",
                "fullauto"],
                BFirerate = 575,
                Chambers =
                [
                    new Slot
                    {
                        Name = "patron_in_weapon",
                        Id = "574d982f24597745a21eb3e5",
                        Parent = "Auto208M",
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "59e655cb86f77411dc52a77b",
                                        "59e6542b86f77411dc52a77a",
                                        "59e6658b86f77411d949b250",
                                        "5f0596629e22f464da6bbdd9"
                                    ]
                                }
                            ]
                        },
                        Required = false,
                        MergeSlotWithChildren = false,
                        Prototype = "55d4af244bdc2d962f8b4571"
                    }
                ]
            },
        };

        customItemService.CreateItemFromClone(exampleCloneItem); // Send our data to the function that creates our item
        
        return Task.CompletedTask;
    }
}

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class CustomItemServiceVPO209A(
    ISptLogger<CustomItemServiceVPO209A> logger,
    CustomItemService customItemService) : IOnLoad
{

    public Task OnLoad()
    {
        //Example of adding new item by cloning an existing item using `createCloneDetails`
        var exampleCloneItem = new NewItemFromCloneDetails
        {
            ItemTplToClone = ItemTpl.ASSAULTRIFLE_KALASHNIKOV_AKMN_762X39_ASSAULT_RIFLE,
            // ParentId refers to the Node item the gun will be under, you can check it in https://db.sp-tarkov.com/search
            ParentId = "5447b5f14bdc2d61278b4567",
            // The new id of our cloned item - MUST be a valid mongo id, search online for mongo id generators
            NewId = "6921f05aab12a7cadfbd3b46",
            // Flea price of item
            FleaPriceRoubles = 25000,
            // Price of item in handbook
            HandbookPriceRoubles = 25000,
            // Handbook Parent Id refers to the category the gun will be under
            HandbookParentId = "5b5f78fc86f77409407a7f90",
            //you see those side box tab thing that only select gun under specific icon? Handbook parent can be found in Spt_Data\Server\database\templates.
            Locales = new Dictionary<string, LocaleDetails>
            {
                {
                    "en", new LocaleDetails
                    {
                        Name = "(Modified) Molot VPO-209MN .366TKM Automatic Firearm",
                        ShortName = "Auto209",
                        Description = "A Molot VPO-209MN .366 TKM Firearm modified to be fully automatic. Equipped with a dovetail mounting plate."
                    }
                }
            },
            OverrideProperties = new TemplateItemProperties
            {
                AmmoCaliber = "Caliber366TKM",
                WeapFireType = [
                "single",
                "fullauto"],
                BFirerate = 600,
                RecoilForceBack = 386,
                RecoilForceUp = 154,
                Chambers =
                [
                    new Slot
                    {
                        Name = "patron_in_weapon",
                        Id = "574d982f24597745a21eb3e5",
                        Parent = "Auto209",
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "59e655cb86f77411dc52a77b",
                                        "59e6542b86f77411dc52a77a",
                                        "59e6658b86f77411d949b250",
                                        "5f0596629e22f464da6bbdd9"
                                    ]
                                }
                            ]
                        },
                        Required = false,
                        MergeSlotWithChildren = false,
                        Prototype = "55d4af244bdc2d962f8b4571"
                    }
                ]
            },
        };

        customItemService.CreateItemFromClone(exampleCloneItem); // Send our data to the function that creates our item
        
        return Task.CompletedTask;
    }
}

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class CustomItemService366RPDN(
    ISptLogger<CustomItemService366RPDN> logger,
    CustomItemService customItemService) : IOnLoad
{

    public Task OnLoad()
    {
        //Example of adding new item by cloning an existing item using `createCloneDetails`
        var exampleCloneItem = new NewItemFromCloneDetails
        {
            ItemTplToClone = ItemTpl.MACHINEGUN_DEGTYAREV_RPDN_762X39_MACHINE_GUN,
            // ParentId refers to the Node item the gun will be under, you can check it in https://db.sp-tarkov.com/search
            ParentId = "5447bed64bdc2d97278b4568",
            // The new id of our cloned item - MUST be a valid mongo id, search online for mongo id generators
            NewId = "6921f23bab12a7cadfbd3b47",
            // Flea price of item
            FleaPriceRoubles = 37000,
            // Price of item in handbook
            HandbookPriceRoubles = 37000,
            // Handbook Parent Id refers to the category the gun will be under
            HandbookParentId = "5b5f79a486f77409407a7f94",
            //you see those side box tab thing that only select gun under specific icon? Handbook parent can be found in Spt_Data\Server\database\templates.
            Locales = new Dictionary<string, LocaleDetails>
            {
                {
                    "en", new LocaleDetails
                    {
                        Name = "Degtyarev RPDN .366TKM Machine Gun",
                        ShortName = "366RPDN",
                        Description = "A RPDN Machine Gun rechambered in .366TKM and converted to single fire for the civilian market before being reverted to fire automatically once more."
                    }
                }
            },
            OverrideProperties = new TemplateItemProperties
            {
                AmmoCaliber = "Caliber366TKM",
                WeapFireType = [
                    "fullauto"
                ],
                BFirerate = 700,
                RecoilForceBack = 502,
                RecoilForceUp = 157,
            },
        };

        customItemService.CreateItemFromClone(exampleCloneItem); // Send our data to the function that creates our item
        
        return Task.CompletedTask;
    }
}

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class CustomItemService366AKS(
    ISptLogger<CustomItemService366AKS> logger,
    CustomItemService customItemService) : IOnLoad
{

    public Task OnLoad()
    {
        //Example of adding new item by cloning an existing item using `createCloneDetails`
        var exampleCloneItem = new NewItemFromCloneDetails
        {
            ItemTplToClone = ItemTpl.ASSAULTRIFLE_KALASHNIKOV_AKS74UN_545X39_ASSAULT_RIFLE,
            // ParentId refers to the Node item the gun will be under, you can check it in https://db.sp-tarkov.com/search
            ParentId = "5447b5f14bdc2d61278b4567",
            // The new id of our cloned item - MUST be a valid mongo id, search online for mongo id generators
            NewId = "6921fd6eab12a7cadfbd3b48",
            // Flea price of item
            FleaPriceRoubles = 24000,
            // Price of item in handbook
            HandbookPriceRoubles = 24000,
            // Handbook Parent Id refers to the category the gun will be under
            HandbookParentId = "5b5f78fc86f77409407a7f90",
            //you see those side box tab thing that only select gun under specific icon? Handbook parent can be found in Spt_Data\Server\database\templates.
            Locales = new Dictionary<string, LocaleDetails>
            {
                {
                    "en", new LocaleDetails
                    {
                        Name = "(Modified) Molot Arms VPO-209UN .366 Automatic Firearm",
                        ShortName = "Auto209UN",
                        Description =
                            "A Molot Arms VPO-209UN .366 TKM civilian semi-automatic firearm converted to fire automatically. Equipped with a dovetail mounting plate."
                    }
                }
            },
            OverrideProperties = new TemplateItemProperties
            {
                AmmoCaliber = "Caliber366TKM",
                WeapFireType =
                [
                    "single",
                    "fullauto"
                ],
                BFirerate = 635,
                RecoilForceBack = 413,
                RecoilForceUp = 175,
                Chambers = 
                [
                    new Slot
                    {
                        Name = "patron_in_weapon",
                        Id = "574d982f24597745a21eb3e5",
                        Parent = "Auto209UN",
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "59e655cb86f77411dc52a77b",
                                        "59e6542b86f77411dc52a77a",
                                        "59e6658b86f77411d949b250",
                                        "5f0596629e22f464da6bbdd9"
                                    ]
                                }
                            ]
                        },
                        Required = false,
                        MergeSlotWithChildren = false,
                        Prototype = "55d4af244bdc2d962f8b4571"
                    }
                ]
            },
        };

        customItemService.CreateItemFromClone(exampleCloneItem); // Send our data to the function that creates our item

        return Task.CompletedTask;
    }
}

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class CustomItemService366Mutant(
    ISptLogger<CustomItemService366Mutant> logger,
    CustomItemService customItemService) : IOnLoad
{

    public Task OnLoad()
    {
        //Example of adding new item by cloning an existing item using `createCloneDetails`
        var exampleCloneItem = new NewItemFromCloneDetails
        {
            ItemTplToClone = ItemTpl.ASSAULTRIFLE_CMMG_MK47_MUTANT_762X39_ASSAULT_RIFLE,
            // ParentId refers to the Node item the gun will be under, you can check it in https://db.sp-tarkov.com/search
            ParentId = "5447b5f14bdc2d61278b4567",
            // The new id of our cloned item - MUST be a valid mongo id, search online for mongo id generators
            NewId = "6922252aab12a7cadfbd3b49",
            // Flea price of item
            FleaPriceRoubles = 37000,
            // Price of item in handbook
            HandbookPriceRoubles = 37000,
            // Handbook Parent Id refers to the category the gun will be under
            HandbookParentId = "5b5f78fc86f77409407a7f90",
            //you see those side box tab thing that only select gun under specific icon? Handbook parent can be found in Spt_Data\Server\database\templates.
            Locales = new Dictionary<string, LocaleDetails>
            {
                {
                    "en", new LocaleDetails
                    {
                        Name = "CMMG Mk47 Mutant .366TKM Assault Firearm",
                        ShortName = "366Mutant",
                        Description =
                            "A CMMG Mk47 Mutant converted to fire .366TKM cartridges."
                    }
                }
            },
            OverrideProperties = new TemplateItemProperties
            {
                AmmoCaliber = "Caliber366TKM",
                WeapFireType =
                [
                    "single",
                    "fullauto"
                ],
                BFirerate = 700,
                RecoilForceBack = 377,
                RecoilForceUp = 152,
                Chambers = 
                [
                    new Slot
                    {
                        Name = "patron_in_weapon",
                        Id = "574d982f24597745a21eb3e5",
                        Parent = "AutoUN",
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "59e655cb86f77411dc52a77b",
                                        "59e6542b86f77411dc52a77a",
                                        "59e6658b86f77411d949b250",
                                        "5f0596629e22f464da6bbdd9"
                                    ]
                                }
                            ]
                        },
                        Required = false,
                        MergeSlotWithChildren = false,
                        Prototype = "55d4af244bdc2d962f8b4571"
                    }
                ]
            },
        };

        customItemService.CreateItemFromClone(exampleCloneItem); // Send our data to the function that creates our item

        return Task.CompletedTask;
    }
}

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class CustomItemService366Buben(
    ISptLogger<CustomItemService366Buben> logger,
    CustomItemService customItemService) : IOnLoad
{

    public Task OnLoad()
    {
        //Example of adding new item by cloning an existing item using `createCloneDetails`
        var exampleCloneItem = new NewItemFromCloneDetails
        {
            ItemTplToClone = ItemTpl.MAGAZINE_762X39_BUBEN_100RND,
            // ParentId refers to the Node item the gun will be under, you can check it in https://db.sp-tarkov.com/search
            ParentId = "5448bc234bdc2d3c308b4569",
            // The new id of our cloned item - MUST be a valid mongo id, search online for mongo id generators
            NewId = "69222bb4ab12a7cadfbd3b4a",
            // Flea price of item
            FleaPriceRoubles = 15000,
            // Price of item in handbook
            HandbookPriceRoubles = 15000,
            // Handbook Parent Id refers to the category the gun will be under
            HandbookParentId = "5b5f754a86f774094242f19b",
            //you see those side box tab thing that only select gun under specific icon? Handbook parent can be found in Spt_Data\Server\database\templates.
            Locales = new Dictionary<string, LocaleDetails>
            {
                {
                    "en", new LocaleDetails
                    {
                        Name = "100-Round RPD Platform Belt Box",
                        ShortName = "366Buben",
                        Description =
                            "A 100-Round RPD Platform belt box converted to house a belt holding 100 cartridges of 366TKM to be used in RPD platform weapons."
                    }
                }
            },
            OverrideProperties = new TemplateItemProperties
            {
                Cartridges = 
                [
                    new Slot
                    {
                        Name = "cartridges",
                        Id = "574d982f24597745a21eb3e5",
                        Parent = "366RPDN",
                        MaxCount = 100,
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "59e655cb86f77411dc52a77b",
                                        "59e6542b86f77411dc52a77a",
                                        "59e6658b86f77411d949b250",
                                        "5f0596629e22f464da6bbdd9"
                                    ]
                                }
                            ]
                        },
                        Required = false,
                        MergeSlotWithChildren = false,
                        Prototype = "5748538b2459770af276a261"
                    }
                ]
            },
        };

        customItemService.CreateItemFromClone(exampleCloneItem); // Send our data to the function that creates our item

        return Task.CompletedTask;
    }
}

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class CustomItemService366RPD520(
    ISptLogger<CustomItemService366RPD520> logger,
    CustomItemService customItemService) : IOnLoad
{

    public Task OnLoad()
    {
        //Example of adding new item by cloning an existing item using `createCloneDetails`
        var exampleCloneItem = new NewItemFromCloneDetails
        {
            ItemTplToClone = ItemTpl.BARREL_RPD_762X39_520MM,
            // ParentId refers to the Node item the gun will be under, you can check it in https://db.sp-tarkov.com/search
            ParentId = "555ef6e44bdc2de9068b457e",
            // The new id of our cloned item - MUST be a valid mongo id, search online for mongo id generators
            NewId = "69223ce7ab12a7cadfbd3b4b",
            // Flea price of item
            FleaPriceRoubles = 3000,
            // Price of item in handbook
            HandbookPriceRoubles = 3000,
            // Handbook Parent Id refers to the category the gun will be under
            HandbookParentId = "5b5f75c686f774094242f19f",
            //you see those side box tab thing that only select gun under specific icon? Handbook parent can be found in Spt_Data\Server\database\templates.
            Locales = new Dictionary<string, LocaleDetails>
            {
                {
                    "en", new LocaleDetails
                    {
                        Name = "520MM .366 TKM RPD Barrel",
                        ShortName = "520mm",
                        Description =
                            "A bored out 520mm RPD Barrel for .366 Caliber Projectiles."
                    }
                }
            },
            OverrideProperties = new TemplateItemProperties
            {
                Slots = [
                    new Slot
                    {
                        Name = "mod_muzzle",
                        Id = "65141868e718582c0c0a0c86",
                        Parent = "366RPDN",
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "6513f0f5e63f29908d0ffab8",
                                        "5a7ad0c451dfba0013379712",
                                        "5a7037338dc32e000d46d257",
                                        "5a70366c8dc32e001207fb06",
                                        "5a705e128dc32e000d46d258",
                                        "5a7ad1fb51dfba0013379715",
                                        "5a6b585a8dc32e5a9c28b4f1",
                                        "5a6b592c8dc32e00094b97bf",
                                        "5a6b59a08dc32e000b452fb7",
                                        "5c7e8fab2e22165df16b889b",
                                        "5a33a8ebc4a282000c5a950d",
                                        "5c6165902e22160010261b28",
                                        "5a32a064c4a28200741e22de",
                                        "5998597786f77414ea6da093",
                                        "5998598e86f7740b3f498a86",
                                        "59bffc1f86f77435b128b872",
                                        "5a9fb739a2750c003215717f",
                                        "59bfc5c886f7743bf6794e62",
                                        "60337f5dce399e10262255d1",
                                        "5fbbc3324e8a554c40648348",
                                        "5c7954d52e221600106f4cc7",
                                        "62e2a7138e1ac9380579c122",
                                        "62e2a754b6c0ee2f230cee0f",
                                        "5a27b6bec4a282000e496f78",
                                        "5cadc390ae921500126a77f1",
                                        "57f3c7e024597738ea4ba286",
                                        "5de8f237bbaf010b10528a70",
                                        "602a97060ddce744014caf6f",
                                        "5c07c5ed0db834001b73571c",
                                        "615d8df08004cc50514c3236",
                                        "57f3c8cc2459773ec4480328"
                                    ]
                                }
                            ]
                        },
                        Required = false,
                        MergeSlotWithChildren = false,
                        Prototype = "55d30c4c4bdc2db4468b457e"
                    },
                    new Slot
                    {
                        Name = "mod_bipod",
                        Id = "6513f021e63f29908d0ffab7",
                        Parent = "366RPDN",
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "6513f037e06849f06c0957d7",
                                        "55d48ebc4bdc2d8c2f8b456c",
                                        "5a789261c5856700186c65d3"
                                        
                                    ],
                                    Shift = 0
                                }
                                ]
                                },
                                Required = false,
                                MergeSlotWithChildren = false,
                                Prototype = "55d30c4c4bdc2db4468b457e"
                                }
                ]

            },
        };

        customItemService.CreateItemFromClone(exampleCloneItem); // Send our data to the function that creates our item

        return Task.CompletedTask;
    }
}

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class CustomItemService366RPD350(
    ISptLogger<CustomItemService366RPD350> logger,
    CustomItemService customItemService) : IOnLoad
{

    public Task OnLoad()
    {
        //Example of adding new item by cloning an existing item using `createCloneDetails`
        var exampleCloneItem = new NewItemFromCloneDetails
        {
            ItemTplToClone = ItemTpl.BARREL_RPD_762X39_SAWEDOFF_350MM,
            // ParentId refers to the Node item the gun will be under, you can check it in https://db.sp-tarkov.com/search
            ParentId = "555ef6e44bdc2de9068b457e",
            // The new id of our cloned item - MUST be a valid mongo id, search online for mongo id generators
            NewId = "69224243ab12a7cadfbd3b4d",
            // Flea price of item
            FleaPriceRoubles = 3000,
            // Price of item in handbook
            HandbookPriceRoubles = 3000,
            // Handbook Parent Id refers to the category the gun will be under
            HandbookParentId = "5b5f75c686f774094242f19f",
            //you see those side box tab thing that only select gun under specific icon? Handbook parent can be found in Spt_Data\Server\database\templates.
            Locales = new Dictionary<string, LocaleDetails>
            {
                {
                    "en", new LocaleDetails
                    {
                        Name = "350MM .366 TKM RPD Barrel",
                        ShortName = "350mm",
                        Description =
                            "A bored out 350mm RPD Barrel for .366 Caliber Projectiles."
                    }
                }
            },
            OverrideProperties = new TemplateItemProperties
            {
                Slots = [
                    new Slot
                    {
                        Name = "mod_muzzle",
                        Id = "65266fd43341ed9aa903dd58",
                        Parent = "366RPDN",
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "6513eff1e06849f06c0957d4",
                                        "5a7ad0c451dfba0013379712",
                                        "5a7037338dc32e000d46d257",
                                        "5a70366c8dc32e001207fb06",
                                        "5a705e128dc32e000d46d258",
                                        "5a7ad1fb51dfba0013379715",
                                        "5a6b585a8dc32e5a9c28b4f1",
                                        "5a6b592c8dc32e00094b97bf",
                                        "5a6b59a08dc32e000b452fb7",
                                        "5c7e8fab2e22165df16b889b",
                                        "5a33a8ebc4a282000c5a950d",
                                        "5c6165902e22160010261b28",
                                        "5a32a064c4a28200741e22de",
                                        "5998597786f77414ea6da093",
                                        "5998598e86f7740b3f498a86",
                                        "59bffc1f86f77435b128b872",
                                        "5a9fb739a2750c003215717f",
                                        "59bfc5c886f7743bf6794e62",
                                        "60337f5dce399e10262255d1",
                                        "5fbbc3324e8a554c40648348",
                                        "5c7954d52e221600106f4cc7",
                                        "62e2a7138e1ac9380579c122",
                                        "62e2a754b6c0ee2f230cee0f",
                                        "5a27b6bec4a282000e496f78",
                                        "5cadc390ae921500126a77f1",
                                        "57f3c7e024597738ea4ba286",
                                        "5de8f237bbaf010b10528a70",
                                        "602a97060ddce744014caf6f",
                                        "5c07c5ed0db834001b73571c",
                                        "615d8df08004cc50514c3236",
                                        "57f3c8cc2459773ec4480328"
                                    ]
                                }
                            ]
                        },
                        Required = false,
                        MergeSlotWithChildren = false,
                        Prototype = "55d30c4c4bdc2db4468b457e"
                    }
                ]

            },
        };

        customItemService.CreateItemFromClone(exampleCloneItem); // Send our data to the function that creates our item

        return Task.CompletedTask;
    }
}

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]
public class CustomItemService366Sksbarrel(
    ISptLogger<CustomItemService366Sksbarrel> logger,
    CustomItemService customItemService) : IOnLoad
{

    public Task OnLoad()
    {
        //Example of adding new item by cloning an existing item using `createCloneDetails`
        var exampleCloneItem = new NewItemFromCloneDetails
        {
            ItemTplToClone = ItemTpl.BARREL_OPSKS_762X39_520MM,
            // ParentId refers to the Node item the gun will be under, you can check it in https://db.sp-tarkov.com/search
            ParentId = "555ef6e44bdc2de9068b457e",
            // The new id of our cloned item - MUST be a valid mongo id, search online for mongo id generators
            NewId = "6928a8aa308ae83e0a8f91be",
            // Flea price of item
            FleaPriceRoubles = 1000,
            // Price of item in handbook
            HandbookPriceRoubles = 1000,
            // Handbook Parent Id refers to the category the gun will be under
            HandbookParentId = "5b5f75c686f774094242f19f",
            //you see those side box tab thing that only select gun under specific icon? Handbook parent can be found in Spt_Data\Server\database\templates.
            Locales = new Dictionary<string, LocaleDetails>
            {
                {
                    "en", new LocaleDetails
                    {
                        Name = "Molot VPO-208 .366TKM Barrel",
                        ShortName = "208 Barrel",
                        Description =
                            "A .366 caliber barrel for the Molot VPO-208 Platform firearms."
                    }
                }
            },
            OverrideProperties = new TemplateItemProperties
            {
              Slots = [
                    new Slot
                    {
                        Name = "mod_muzzle",
                        Id = "65266fd43341ed9aa903dd58",
                        Parent = "VPO208",
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "6513eff1e06849f06c0957d4",
                                        "5a7ad0c451dfba0013379712",
                                        "5a7037338dc32e000d46d257",
                                        "5a70366c8dc32e001207fb06",
                                        "5a705e128dc32e000d46d258",
                                        "5a7ad1fb51dfba0013379715",
                                        "5a6b585a8dc32e5a9c28b4f1",
                                        "5a6b592c8dc32e00094b97bf",
                                        "5a6b59a08dc32e000b452fb7",
                                        "5c7e8fab2e22165df16b889b",
                                        "5a33a8ebc4a282000c5a950d",
                                        "5c6165902e22160010261b28",
                                        "5a32a064c4a28200741e22de",
                                        "5998597786f77414ea6da093",
                                        "5998598e86f7740b3f498a86",
                                        "59bffc1f86f77435b128b872",
                                        "5a9fb739a2750c003215717f",
                                        "59bfc5c886f7743bf6794e62",
                                        "60337f5dce399e10262255d1",
                                        "5fbbc3324e8a554c40648348",
                                        "5c7954d52e221600106f4cc7",
                                        "62e2a7138e1ac9380579c122",
                                        "62e2a754b6c0ee2f230cee0f",
                                        "5a27b6bec4a282000e496f78",
                                        "5cadc390ae921500126a77f1",
                                        "57f3c7e024597738ea4ba286",
                                        "5de8f237bbaf010b10528a70",
                                        "602a97060ddce744014caf6f",
                                        "5c07c5ed0db834001b73571c",
                                        "615d8df08004cc50514c3236",
                                        "57f3c8cc2459773ec4480328"
                                    ]
                                }
                            ]
                        },
                        Required = false,
                        MergeSlotWithChildren = false,
                        Prototype = "55d30c4c4bdc2db4468b457e"
                    },
                    new Slot
                    {
                        Name = "mod_mount_001",
                        Id = "65266fd43341ed9aa903dd58",
                        Parent = "VPO208",
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "593d1fa786f7746da62d61ac",
                                        "55d48ebc4bdc2d8c2f8b456c",
                                        "5a789261c5856700186c65d3"
                                    ]
                                }
                            ]
                        },
                        Required = false,
                        MergeSlotWithChildren = false,
                        Prototype = "55d30c4c4bdc2db4468b457e"
                    },
                    new Slot
                    {
                        Name = "mod_mount_000",
                        Id = "65266fd43341ed9aa903dd58",
                        Parent = "VPO208",
                        Properties = new SlotProperties
                        {
                            Filters =
                            [
                                new SlotFilter
                                {
                                    Filter =
                                    [
                                        "634f05a21f9f536910079b56",
                                        "634f04d82e5def262d0b30c6"
                                    ]
                                }
                            ]
                        },
                        Required = false,
                        MergeSlotWithChildren = false,
                        Prototype = "55d30c4c4bdc2db4468b457e"
                    }
                ]  
            },
        };

        customItemService.CreateItemFromClone(exampleCloneItem); // Send our data to the function that creates our item

        return Task.CompletedTask;
    }
}

[Injectable(TypePriority = OnLoadOrder.PostDBModLoader + 1)]

public class EditDatabaseValues(
    ISptLogger<EditDatabaseValues>
        logger, // We are injecting a logger similar to example 1, but notice the class inside <> is different
    DatabaseService databaseService)
    : IOnLoad // Implement the `IOnLoad` interface so that this mod can do something
{
    // Our constructor

    /// <summary>
    /// This is called when this class is loaded, the order in which its loaded is set according to the type priority
    /// on the [Injectable] attribute on this class. Each class can then be used as an entry point to do
    /// things at varying times according to type priority
    /// </summary>
    public Task OnLoad()
    {
        Muzzleparts();

        RPD366parts();

        VPO209UNMagazineparts();

        Add366TKMContenttoPmc();

        TKMSKSParts();

        logger.Success("Finished Editing Database! 366TKMContentPack Added!");

        return Task.CompletedTask;

    }

    private void Muzzleparts()
    {
        var items = databaseService.GetItems();

        foreach (var (id, item) in items)
        {
            if (id != "6921f05aab12a7cadfbd3b46" && id != "6921fd6eab12a7cadfbd3b48")
            {
                continue;
            }

            foreach (var slot in item.Properties?.Slots ?? [])
            {
                if (slot.Name != "mod_muzzle")
                {
                    continue;
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5ac72e945acfc43f3b691116");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5ac7655e5acfc40016339a19");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5649aa744bdc2ded0b8b457e");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5f633f791b231926f2329f13");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5943eeeb86f77412d6384f6b");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5cc9a96cd7f00c011c04e04a");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("615d8f5dd92c473c770212ef");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5649ab884bdc2ded0b8b457f");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("57dc324a24597759501edc20");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("593d493f86f7745e6b2ceb22");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("564caa3d4bdc2d17108b458e");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("57ffb0e42459777d047111c5");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5e21ca18e4d47f0da15e77dd");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5a9fbacda2750c00141e080f");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5a0d63621526d8dba31fe3bf");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("593d489686f7745c6255d58a");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5a0abb6e1526d8000a025282");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("615d8e9867085e45ef1409c6");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5cc9ad73d7f00c000e2579d4");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("60337f5dce399e10262255d1");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5998598e86f7740b3f498a86");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5de8f2d5b74cd90030650c72");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5fbbc3324e8a554c40648348");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {

                    filter.Filter!.Add("5c7954d52e221600106f4cc7");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a9fb739a2750c003215717f");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5c6165902e22160010261b28");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a32a064c4a28200741e22de");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5cf6935bd7f00c06585fb791");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5fbbc34106bde7524f03cbe9");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5c7e8fab2e22165df16b889b");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5b3a16655acfc40016387a2a");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("58949dea86f77409483e16a8");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("59bffc1f86f77435b128b872");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5998597786f77414ea6da093");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("59bfc5c886f7743bf6794e62");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("615d8df08004cc50514c3236");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5c07c5ed0db834001b73571c");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5926d33d86f77410de68ebc0");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a7ad0c451dfba0013379712");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a7037338dc32e000d46d257");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a70366c8dc32e001207fb06");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a705e128dc32e000d46d258");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a7ad1fb51dfba0013379715");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a6b585a8dc32e5a9c28b4f1");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a6b592c8dc32e00094b97bf");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a6b59a08dc32e000b452fb7");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("602a97060ddce744014caf6f");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5cadc390ae921500126a77f1");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a33a8ebc4a282000c5a950d");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("56e05b06d2720bb2668b4586");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5abcc328d8ce8700194394f3");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("57f3c7e024597738ea4ba286");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("57f3c8cc2459773ec4480328");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("62e2a7138e1ac9380579c122");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("62e2a754b6c0ee2f230cee0f");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a27b6bec4a282000e496f78");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("64527a3a7da7133e5a09ca99");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5de8f237bbaf010b10528a70");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("59e8a00d86f7742ad93b569c");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5de6556a205ddc616a6bc4f7");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6698c9c636ba38d291017711");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("668670f52a2296a8d909963c");
                }
            }
        }

    }

    private void RPD366parts()
    {
        var items = databaseService.GetItems();

        foreach (var (id, item) in items)
        {
            if (id != "6921f23bab12a7cadfbd3b47")
            {
                continue;
            }

            foreach (var slot in item.Properties?.Slots ?? [])
            {
                if (slot.Name != "mod_magazine")
                {
                    continue;
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("6513f0a194c72326990a3868");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("69222bb4ab12a7cadfbd3b4a");
                }
            }

            foreach (var slot in item.Properties?.Slots ?? [])
            {
                if (slot.Name != "mod_barrel")
                {
                    continue;
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("6513eff1e06849f06c0957d4");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("65266fd43341ed9aa903dd56");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("69224243ab12a7cadfbd3b4d");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("69223ce7ab12a7cadfbd3b4b");
                }
            }
            
            foreach (var slot in item.Properties?.Slots ?? [])
            {
                if (slot.Name != "mod_sight_rear")
                {
                    continue;
                }
                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5649d9a14bdc2d79388b4580");
                }
                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("649ec2cec93611967b03495e");
                }
                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("57ffb0062459777a045af529");
                }
                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5bfebc530db834001d23eb65");
                }
            }
        }
    }

    private void VPO209UNMagazineparts()
    {
        var items = databaseService.GetItems();

        foreach (var (id, item) in items)
        {
            if (id != "6921fd6eab12a7cadfbd3b48")
            {
                continue;
            }

            foreach (var slot in item.Properties?.Slots ?? [])
            {
                if (slot.Name != "mod_magazine")
                {
                    continue;
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("564ca9df4bdc2d35148b4569");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("564ca99c4bdc2d16268b4589");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("55d480c04bdc2d1d4e8b456a");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5cbdaf89ae9215000e5b9c94");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("55d481904bdc2d8c2f8b456a");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("55d482194bdc2d1d4e8b456b");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("55d4837c4bdc2d1d4e8b456c");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5aaa4194e5b5b055d06310a5");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5bed61680db834001d2c45ab");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("5bed625c0db834001c062946");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("649ec30cb013f04a700e60fb");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("64b9e265c94d0d15c5027e35");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("59e5d83b86f7745aed03d262");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a01c29586f77474660c694c");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5ac66bea5acfc43b321d4aec");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("59d625f086f774661516605d");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5b1fd4e35acfc40018633c39");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5a0060fc86f7745793204432");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("59e5f5a486f7746c530b3ce2");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5b1fb3e15acfc4001637f068");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("59d6272486f77466146386ff");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5e21a3c67e40bd02257a008a");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5cbdc23eae9215001136a407");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5c6175362e221600133e3b94");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("59fafc5086f7740dbe19f6c3");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("59fafc9386f774067d462453");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("5cfe8010d7ad1a59283b14c6");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6272874a6c47bd74f92e2087");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("64b9cf0ac12b9c38db26923a");
                }
            }
        }
    }

    private void Add366TKMContenttoPmc()
    {
        var items = databaseService.GetItems();

        foreach (var (id, item) in items)
        {
            if (id != "55d7217a4bdc2d86028b456d")
            {
                continue;
            }

            foreach (var slot in item.Properties?.Slots ?? [])
            {
                if (slot.Name != "FirstPrimaryWeapon")
                {
                    continue;
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6921ebb1ab12a7cadfbd3b42");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6921ed86ab12a7cadfbd3b44");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6921eed3ab12a7cadfbd3b45");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6921f05aab12a7cadfbd3b46");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6921f23bab12a7cadfbd3b47");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6921fd6eab12a7cadfbd3b48");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6922252aab12a7cadfbd3b49");
                }
            }

            foreach (var slot in item.Properties?.Slots ?? [])
            {
                if (slot.Name != "SecondPrimaryWeapon")
                {
                    continue;
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6921ebb1ab12a7cadfbd3b42");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6921ed86ab12a7cadfbd3b44");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6921eed3ab12a7cadfbd3b45");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6921f05aab12a7cadfbd3b46");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6921f23bab12a7cadfbd3b47");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6921fd6eab12a7cadfbd3b48");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6922252aab12a7cadfbd3b49");
                }
            }
        }
    }

    private void TKMSKSParts()
    {
        var items = databaseService.GetItems();

        foreach (var (id, item) in items)
        {
            if (id != "6921ebb1ab12a7cadfbd3b42" && id != "6921ed86ab12a7cadfbd3b44" && id != "6921eed3ab12a7cadfbd3b45")
            {
                continue;
            }

            foreach (var slot in item.Properties?.Slots ?? [])
            {
                if (slot.Name != "mod_barrel")
                {
                    continue;
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("634eff66517ccc8a960fc735");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Remove("634f02331f9f536910079b51");
                }

                foreach (var filter in slot.Properties?.Filters ?? [])
                {
                    filter.Filter!.Add("6928a8aa308ae83e0a8f91be");
                }
            }
        }
    }
}