# Mapster - AutoMapper

## Introduction
This is an analysis of the use of the two most famous mapping tools: [Automapper](#https://github.com/AutoMapper/AutoMapper) and [Mapster](#https://github.com/MapsterMapper/Mapster). Then we will show some benchmarks.

Two types of Benchmark are provided:

- base code tested by using [BenchmarkDotNet](#https://github.com/dotnet/BenchmarkDotNet).

- a real use case with a WebApi endpoint by using [Benchmark Rest](#https://github.com/skepee-PROTOTYPE/Benchmark-Rest-Api). 


## Mapping scenarios to test
The benchmarks will consider two cases:

- a <em>simple case</em> for a one-to-one mapping fields with a small and a great number of fields as subcases. We should also consider cases: 
    - <em>with adapter</em>: the mapping rule maps the field with a different name. A custom adapter rule should be provided to indicate which field should be mapped to.
        ```
        int a         =>        int x
        string b      =>        string y
        date c        =>        date z
        ```
    - <em>without adapter</em>: the mapping rule maps the field with the same name. The mapping tool does it for you out of the box. No extra code is required.
        ```
        int a         =>        int a
        string b      =>        string b
        date c        =>        date c
        ```

- The <em>complex case</em> will consider a more mapping where some elaborations are provided. For example:
    ```
    int a         =>        int x
    string b                
    string c      =>        string  y = b + c + d
    string d              
    date e        =>        date z
    ```


Here a summary of different cases:

<table>
<tr>
    <th colspan=5 style="alignment:middle">BenchMarkDotNet (Basecode)</th>
</tr>
<tr>
    <th>Type</th>
    <th>Description</th>
    <th>Automapper</th>
    <th>Mapster</th>
    <th>MapsterCodeGen</th>
</tr>
<tr>
    <td><em>Simple</em></td>
    <td>few fields, with Adapter</td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
</tr>
<tr>
    <td><em>Simple</em></td>
    <td>few fields, No Adapter</td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
</tr>
<tr>
    <td><em>Simple</em></td>
    <td>many fields, with Adapter</td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
</tr>
<tr>
    <td><em>Simple</em></td>
    <td>many fields, No Adapter</td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
</tr>
<tr>
    <td><em>Complex</em></td>
    <td>operations</td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
</tr>
</table>


<table>
<tr>
    <th colspan=5 style="alignment:middle">BenchMark Rest (WebApi)</th>
</tr>
<tr>
    <th>Type</th>
    <th>Description</th>
    <th>Automapper</th>
    <th>Mapster</th>
    <th>MapsterCodeGen</th>
</tr>
<tr>
    <td><em>Complex</em></td>
    <td>operations</td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
</tr>
</table>

# Test cases
Because there are different cases and combinations, by showing all these results in one shot is not helpful, so we will show results step by step, by comparing from the simplest to the most complex.
## First simple case
The first simple case regards the one-to-one mapping with a Dto with just five fields:

```cs
    public class DtoPortfolio
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
    }
```

## Second simple case
The second simple case regards the one-to-one mapping with a Dto with 200 fields added to the previous one (50 ```string``` props, 50 ```int``` props, 20 ```decimal``` props and 50 ```datetime``` props), 205 in total:

```cs
    public class DtoPortfolio
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
        public string Prop1 { get; set; }
        public string Prop2 { get; set; }
        public string Prop3 { get; set; }
        public string Prop4 { get; set; }
        public string Prop5 { get; set; }
        public string Prop6 { get; set; }
        public string Prop7 { get; set; }
        public string Prop8 { get; set; }
        public string Prop9 { get; set; }
        public string Prop10 { get; set; }
        public string Prop11 { get; set; }
        public string Prop12 { get; set; }
        public string Prop13 { get; set; }
        public string Prop14 { get; set; }
        public string Prop15 { get; set; }
        public string Prop16 { get; set; }
        public string Prop17 { get; set; }
        public string Prop18 { get; set; }
        public string Prop19 { get; set; }
        public string Prop20 { get; set; }
        public string Prop21 { get; set; }
        public string Prop22 { get; set; }
        public string Prop23 { get; set; }
        public string Prop24 { get; set; }
        public string Prop25 { get; set; }
        public string Prop26 { get; set; }
        public string Prop27 { get; set; }
        public string Prop28 { get; set; }
        public string Prop29 { get; set; }
        public string Prop30 { get; set; }
        public string Prop31 { get; set; }
        public string Prop32 { get; set; }
        public string Prop33 { get; set; }
        public string Prop34 { get; set; }
        public string Prop35 { get; set; }
        public string Prop36 { get; set; }
        public string Prop37 { get; set; }
        public string Prop38 { get; set; }
        public string Prop39 { get; set; }
        public string Prop40 { get; set; }
        public string Prop41 { get; set; }
        public string Prop42 { get; set; }
        public string Prop43 { get; set; }
        public string Prop44 { get; set; }
        public string Prop45 { get; set; }
        public string Prop46 { get; set; }
        public string Prop47 { get; set; }
        public string Prop48 { get; set; }
        public string Prop49 { get; set; }
        public string Prop50 { get; set; }
        public int Prop51 { get; set; }
        public int Prop52 { get; set; }
        public int Prop53 { get; set; }
        public int Prop54 { get; set; }
        public int Prop55 { get; set; }
        public int Prop56 { get; set; }
        public int Prop57 { get; set; }
        public int Prop58 { get; set; }
        public int Prop59 { get; set; }
        public int Prop60 { get; set; }
        public int Prop61 { get; set; }
        public int Prop62 { get; set; }
        public int Prop63 { get; set; }
        public int Prop64 { get; set; }
        public int Prop65 { get; set; }
        public int Prop66 { get; set; }
        public int Prop67 { get; set; }
        public int Prop68 { get; set; }
        public int Prop69 { get; set; }
        public int Prop70 { get; set; }
        public int Prop71 { get; set; }
        public int Prop72 { get; set; }
        public int Prop73 { get; set; }
        public int Prop74 { get; set; }
        public int Prop75 { get; set; }
        public int Prop76 { get; set; }
        public int Prop77 { get; set; }
        public int Prop78 { get; set; }
        public int Prop79 { get; set; }
        public int Prop80 { get; set; }
        public int Prop81 { get; set; }
        public int Prop82 { get; set; }
        public int Prop83 { get; set; }
        public int Prop84 { get; set; }
        public int Prop85 { get; set; }
        public int Prop86 { get; set; }
        public int Prop87 { get; set; }
        public int Prop88 { get; set; }
        public int Prop89 { get; set; }
        public int Prop90 { get; set; }
        public int Prop91 { get; set; }
        public int Prop92 { get; set; }
        public int Prop93 { get; set; }
        public int Prop94 { get; set; }
        public int Prop95 { get; set; }
        public int Prop96 { get; set; }
        public int Prop97 { get; set; }
        public int Prop98 { get; set; }
        public int Prop99 { get; set; }
        public int Prop100 { get; set; }
        public decimal Prop101 { get; set; }
        public decimal Prop102 { get; set; }
        public decimal Prop103 { get; set; }
        public decimal Prop104 { get; set; }
        public decimal Prop105 { get; set; }
        public decimal Prop106 { get; set; }
        public decimal Prop107 { get; set; }
        public decimal Prop108 { get; set; }
        public decimal Prop109 { get; set; }
        public decimal Prop110 { get; set; }
        public decimal Prop111 { get; set; }
        public decimal Prop112 { get; set; }
        public decimal Prop113 { get; set; }
        public decimal Prop114 { get; set; }
        public decimal Prop115 { get; set; }
        public decimal Prop116 { get; set; }
        public decimal Prop117 { get; set; }
        public decimal Prop118 { get; set; }
        public decimal Prop119 { get; set; }
        public decimal Prop120 { get; set; }
        public decimal Prop121 { get; set; }
        public decimal Prop122 { get; set; }
        public decimal Prop123 { get; set; }
        public decimal Prop124 { get; set; }
        public decimal Prop125 { get; set; }
        public decimal Prop126 { get; set; }
        public decimal Prop127 { get; set; }
        public decimal Prop128 { get; set; }
        public decimal Prop129 { get; set; }
        public decimal Prop130 { get; set; }
        public decimal Prop131 { get; set; }
        public decimal Prop132 { get; set; }
        public decimal Prop133 { get; set; }
        public decimal Prop134 { get; set; }
        public decimal Prop135 { get; set; }
        public decimal Prop136 { get; set; }
        public decimal Prop137 { get; set; }
        public decimal Prop138 { get; set; }
        public decimal Prop139 { get; set; }
        public decimal Prop140 { get; set; }
        public decimal Prop141 { get; set; }
        public decimal Prop142 { get; set; }
        public decimal Prop143 { get; set; }
        public decimal Prop144 { get; set; }
        public decimal Prop145 { get; set; }
        public decimal Prop146 { get; set; }
        public decimal Prop147 { get; set; }
        public decimal Prop148 { get; set; }
        public decimal Prop149 { get; set; }
        public decimal Prop150 { get; set; }
        public DateTime Prop151 { get; set; }
        public DateTime Prop152 { get; set; }
        public DateTime Prop153 { get; set; }
        public DateTime Prop154 { get; set; }
        public DateTime Prop155 { get; set; }
        public DateTime Prop156 { get; set; }
        public DateTime Prop157 { get; set; }
        public DateTime Prop158 { get; set; }
        public DateTime Prop159 { get; set; }
        public DateTime Prop160 { get; set; }
        public DateTime Prop161 { get; set; }
        public DateTime Prop162 { get; set; }
        public DateTime Prop163 { get; set; }
        public DateTime Prop164 { get; set; }
        public DateTime Prop165 { get; set; }
        public DateTime Prop166 { get; set; }
        public DateTime Prop167 { get; set; }
        public DateTime Prop168 { get; set; }
        public DateTime Prop169 { get; set; }
        public DateTime Prop170 { get; set; }
        public DateTime Prop171 { get; set; }
        public DateTime Prop172 { get; set; }
        public DateTime Prop173 { get; set; }
        public DateTime Prop174 { get; set; }
        public DateTime Prop175 { get; set; }
        public DateTime Prop176 { get; set; }
        public DateTime Prop177 { get; set; }
        public DateTime Prop178 { get; set; }
        public DateTime Prop179 { get; set; }
        public DateTime Prop180 { get; set; }
        public DateTime Prop181 { get; set; }
        public DateTime Prop182 { get; set; }
        public DateTime Prop183 { get; set; }
        public DateTime Prop184 { get; set; }
        public DateTime Prop185 { get; set; }
        public DateTime Prop186 { get; set; }
        public DateTime Prop187 { get; set; }
        public DateTime Prop188 { get; set; }
        public DateTime Prop189 { get; set; }
        public DateTime Prop190 { get; set; }
        public DateTime Prop191 { get; set; }
        public DateTime Prop192 { get; set; }
        public DateTime Prop193 { get; set; }
        public DateTime Prop194 { get; set; }
        public DateTime Prop195 { get; set; }
        public DateTime Prop196 { get; set; }
        public DateTime Prop197 { get; set; }
        public DateTime Prop198 { get; set; }
        public DateTime Prop199 { get; set; }
        public DateTime Prop200 { get; set; }

    }
```

## Complex case
The complex case take in consideration some elaborations in the mapping:
- ```StringProperties``` is a concatenation of strings operation
- ```IntProperties```: calculates min(), max() and avg() from a list in integers
- ```DecimalProperties```: calculates min(), max() and avg() from a list in decimals
- ```GroupDateTimeProperties```: calculates min() and max() date from a list of dates


```cs
    public class DtoPortfolio
    {
        public int DtoId { get; set; }
        public string DtoCode { get; set; }
        public string DtoName { get; set; }
        public string DtoType { get; set; }
        public string DtoStatus { get; set; }
        public StringProperties GroupStringProperties { get; set; }
        public IntProperties GroupIntProperties { get; set; }
        public DecimalProperties GroupDecimalProperties { get; set; }
        public DateTimeProperties GroupDateTimeProperties { get; set; }
    }

    public class StringProperties
    {
        public string value { get; set; }
        public int numWords { get; set; }
        public int length { get; set; }   
    }

    public class IntProperties
    { 
        public int minValue { get; set; }
        public int maxValue { get; set; }
        public double avgValue { get; set; }
    }

    public class DecimalProperties
    {
        public decimal minValue { get; set; }
        public decimal maxValue { get; set; }
        public decimal avgValue { get; set; }
    }

    public class DateTimeProperties
    {
        public DateTime minValue { get; set; }
        public DateTime maxValue { get; set; }
    }

```

## Automapper
Once you have added AutoMapper Nuget Package (ATM v12.0.0), instantiate automapper in few steps:

```cs
IMapper automapper = new Mapper(new MapperConfiguration(z => z.AddProfile(new AutomapperProfile())));

class AutomapperProfile : Profile
{
    public AutomapperProfile()
    {
        CreateMap<Portfolio, DtoPortfolio>();
    }
}

var pDto = automapper.Map<DtoPortfolio>(p);

```
This is the simplest case where ```p``` and ```pDTO``` have the same properties.
If ```pDTO``` has a property that we want to map but the name is different from the source (```p```), we need is some way how to indicate this rule.

```cs
    public class PortfolioProfile: Profile
    {
        public PortfolioProfileBig()
        {
            CreateMap<Portfolio, DtoPortfolio>()
                .ForMember(dest => dest.DtoId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DtoCode, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.DtoName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.DtoType, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.DtoStatus, opt => opt.MapFrom(src => src.Status));
        }
    }
```
A custom profile is used to map each prop from the source to destination we want to obtain.
And pass it to the ```MapperConfiguration```:

```cs
IMapper automapper = new Mapper(new MapperConfiguration(z => z.AddProfile(new PortfolioProfile())));
```

When a more complex mapping is needed (because you know, life is not easy sometimes :-)), and we need to do some operations, then Automapper helps on this by using a ```resolver```. A custom resolver is created by implementing ```IValueResolver<in TSource, in TDestination, TDestMember>``` for each operation we need, with:

```
- TSource: type of source
- TDestination: type of destination
- TDestMember: type of destination field
```

```cs

    public class PortfolioResolver : IValueResolver<Portfolio, DtoPortfolio, DecimalProperties>,
                                     IValueResolver<Portfolio, DtoPortfolio, StringProperties>,
                                     IValueResolver<Portfolio, DtoPortfolio, DateTimeProperties>,
                                     IValueResolver<Portfolio, DtoPortfolio, IntProperties>
    {
        public DecimalProperties Resolve(Portfolio source, DtoPortfolio destination, DecimalProperties destMember, ResolutionContext context)
        {
            return new DecimalProperties
            {
                //do your operations
            };
        }

        public StringProperties Resolve(Portfolio source, DtoPortfolio destination, StringProperties destMember, ResolutionContext context)
        {
            return new StringProperties()
            {
                //do your operations            
            };
        }

        public DateTimeProperties Resolve(Portfolio source, DtoPortfolio destination, DateTimeProperties destMember, ResolutionContext context)
        {
            return new DateTimeProperties
            {
                //do your operations     
            };
        }

        public IntProperties Resolve(Portfolio source, DtoPortfolio destination, IntProperties destMember, ResolutionContext context)
        {
              return new IntProperties
              {
                //do your operations                   
              };
        }
    }
```

Adding to the existing profile:

```cs
    public class PortfolioProfile: Profile
    {
        public PortfolioProfileBig()
        {
            CreateMap<Portfolio, DtoPortfolio>()
                .ForMember(dest => dest.DtoId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DtoCode, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.DtoName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.DtoType, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.DtoStatus, opt => opt.MapFrom(src => src.Status));
                .ForMember(dest => dest.GroupDecimalProperties, src => src.MapFrom<PortfolioResolver>())
                .ForMember(dest => dest.GroupStringProperties, src => src.MapFrom<PortfolioResolver>())
                .ForMember(dest => dest.GroupIntProperties, src => src.MapFrom<PortfolioResolver>())
                .ForMember(dest => dest.GroupDateTimeProperties, src => src.MapFrom<PortfolioResolver>());
        }
    }
```

## Mapster
Mapster is relatively new and the github [page](#https://github.com/MapsterMapper/Mapster) shows some benchmarks compared with Automapper.

In order to use Mapster it is enough to use this simple code:

```cs
 var pDto = p.Adapt<Portfolio>();
```

and Mapster will map the Dto automatically. But this is a simple case with one-to-one mapping. For the case with adapter the code remains basically the same but we need to add ```AdaptMember``` as annotation in the props we want to map.

```cs
    public class DtoPortfolio
    {
        [AdaptMember("Id")]
        public int DtoId { get; set; }
        [AdaptMember("Code")]
        public string DtoCode { get; set; }
        [AdaptMember("name")]
        public string DtoName { get; set; }
        [AdaptMember("Type")]
        public string DtoType { get; set; }
        [AdaptMember("Status")]
        public string DtoStatus { get; set; }
    }

```

For the complex case the above Adapt instruction needs a ```TypeAdapterConfig``` parameter in this way:

```cs
    var pDto = p.Adapt<DtoPortfolio>(GetTypeAdapterConfig());
```

where ```GetTypeAdapterConfig()``` define aour custom mapping in similar way has been done for ```PortfolioResolver``` for AutoMapper


```cs
    public static TypeAdapterConfig GetTypeAdapterConfig()
    {
        var config = new TypeAdapterConfig();
        config.NewConfig<Portfolio, DtoPortfolio>()
            .Map(dest => dest.DtoId, src => src.Id)
            .Map(dest => dest.DtoCode, src => src.Code)
            .Map(dest => dest.DtoName, src => src.Name)
            .Map(dest => dest.DtoType, src => src.Type)
            .Map(dest => dest.DtoStatus, src => src.Status)
            .Map(dest => dest.GroupStringProperties, src => CalculateStringOperation(...))
            .Map(dest => dest.GroupIntProperties, src => CalculateIntOperation(...))
            .Map(dest => dest.GroupDecimalProperties, src => CalculateDecimalOperation(...))
            .Map(dest => dest.GroupDateTimeProperties, src => CalculateDateTimeOperation(...));
        return config;
    }
    private static StringProperties CalculateStringOperation(...)
    {
        //do your operations            
    }

    private static DateTimeProperties CalculateDateTimeOperation(...)
    {
        //do your operations            
    }

    private static IntProperties CalculateIntOperation(...)
    {
        //do your operations            
    }

    private static DecimalProperties CalculateDecimalOperation(...)
    {
        //do your operations            
    }
```


## MapsterCodeGen

Mapster offers a chance to generate the Dto dynamically at build time. This we will see later, offers great performances. In order to generate automatically the Dto, it is needed to add these lines to ```csproj``` file:

```cs
  <Target Name="Mapster">
    <Exec WorkingDirectory="$(ProjectDir)" Command="dotnet build" />
    <Exec WorkingDirectory="$(ProjectDir)" Command="dotnet tool restore" />
    <Exec WorkingDirectory="$(ProjectDir)" Command="dotnet mapster model -a &quot;$(TargetDir)$(ProjectName).dll&quot;" />
    <Exec WorkingDirectory="$(ProjectDir)" Command="dotnet mapster extension -a &quot;$(TargetDir)$(ProjectName).dll&quot;" />
    <Exec WorkingDirectory="$(ProjectDir)" Command="dotnet mapster mapper -a &quot;$(TargetDir)$(ProjectName).dll&quot;" />
  </Target>
```
and this for the clean up:

```cs
  <ItemGroup>
    <Generated Include="**\*.g.cs" />
  </ItemGroup>
  <Target Name="CleanGenerated">
    <Delete Files="@(Generated)" />
  </Target>
```

In this way, the generated files will be cleaned by executing the command:

```cs
dotnet msbuild -t:CleanGenerated
```

When we will run the build the Dto  with ```.g.cs``` extension will be generated.

## BenchmarkDotNet results
Now let us go to run the benchmarks for these cases by using ```AutoMapper``` and ```Mapster```.

The benchmark considers a list of portfolios of ````10```, ```100``` and ```1000``` size. How to do that?

By adding an annotation on the size property, we can parameterize the benchmark. So for each type of benchmark we will consider a list portfolios with length ```10```, ```100``` or ```1000```.

```cs
    [Params(10, 100, 1000)]
    public int numElements { get; set; }
```

<strong>Portfolio Small - No Adapter </strong>
|      Method      | numElements |  Mean (μs)  | Error (μs)|  StdDev   | Allocated |
| :---             | ----------- | ----------- | --------- | --------- |---------- |
|   AutoMapper     |       100   | 10.688      | 0.2329    | 0.3486    | 10.98 KB  |
|   Mapster        |       100   | 4.997       | 0.2826    | 0.4142    | 10.98 KB  | 
|   MapsterCodeGen |       100   | <span style="color:yellow"> 4.471</span>    | 1.7929  | 0.0644 |  10.98 KB   |

In the mapping one-to-one for a list of ```100``` portfolios with the same allocation memory <strong>Mapster CodeGen</strong> is more performing.



<strong>Portfolio Small - With Adapter</strong>

|   Method   | numElements |  Mean (μs)| Error (μs)|    StdDev | Allocated |
|----------- |------------ |----------:|----------:|----------:|---------: |
| AutoMapper |         100 |  9.761    | 0.1121    | 0.1677    | 10.98 KB   |
| Mapster    |         100 | 4.622     | 0.0750    | 0.1123    | 10.98 KB |
| MapsterCodeGen |         100 | <span style="color:yellow">4.407</span> | 0.0547 us | 0.0802 | 10.98 KB |

Also in this case in the mapping one-to-one for a list of ```100``` portfolios with the same allocation memory <strong>Mapster CodeGen</strong> is more performing.
Futhermore, as we can see, there is no much difference between ```Adapter``` and ```No Adapter``` scenario.
The use of Adapter then is clearly suggested only for situations where the ```Dto``` is already defined and we cannot create from scratch.


<strong>Portfolio Big - With Adapter</strong>

| Method | numElements |       Mean |    Error |   StdDev | Allocated |
|-------------------- |------------ |-----------:|---------:|--------:|----------:|
| AutoMapper |         100 | 1,265.7 μs | 15.59 μs | 22.85 μs |  362.55 KB |      
| Mapster |         100 |  1,110.3 μs |  10.24 μs |  15.32 μs |  58.5938 |  362.55 KB |e' indicatoevidentemente
| MapsterCodeGen|         100 |  <span style="color:yellow">1,091.7 us</span> | 10.33 us | 15.47 us | 362.55 KB |



<strong>Portfolio Big - No Adapter</strong>

| Method | numElements |       Mean |    Error |   StdDev | Allocated |
|--------|------------ |-----------:|---------:|--------:|----------:|
| AutoMapper |         100 |  1,270.9 μs | 12.09 μs |  17.72 μs |  1,261.1 μs |  58.5938 |  362.55 KB |
| Mapster |         100 |  1,104.4 μs |   8.39 μs |  12.30 μs |  58.5938 |  362.55 KB |
| MapsterCodeGen |         100 |  <span style="color:yellow">1,078.3 μs</span>  |  2.36 μs |  3.07 μs |  58.5938 |  362.55 KB |

Here we are considering a list of ```100``` portfolios where each portfolio contains ```205``` fields.
The results confirm the above considerations.


|    Method      | numElements |     Mean |     Error |    StdDev | Allocated |
|--------------- |------------ |---------:|----------:|----------:|----------:|
| MapsterCodeGen |         100 | 1.114 ms | 0.0078 ms | 0.0112 ms | 371.14 KB |
| Mapster        |         100 | 1.142 s | 0.0099 s | 0.0148 s | 13000.0000 |  79.75 MB |
| AutoMapper     |         100 | 1.077 ms | 0.0115 ms | 0.0171 ms |  189.89 KB |
| MapsterCodeGenAndClass |         100 | 1.468 ms | 0.0279 ms | 0.0400 ms | 156.2500 | 964.89 KB |



# Can we do better?

This is a question that we should ask <ins><strong>always</strong></ins> to ourselves, we cannot never say never...
From C# 9 we can use [record types](#https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/records).


> C# 9 introduces records, a new reference type that you can create instead of classes or structs. C# 10 adds record structs so that you can define records as value types. Records are distinct from classes in that  record types use value-based equality. Two variables of a record type are equal if the record type definitions are identical, and if for every field, the values in both records are equal. Two variables of a class type are equal if the objects referred to are the same class type and the variables refer to the same object. Value-based equality implies other capabilities you'll probably want in record types. The compiler generates many of those members when you declare a record instead of a class. The compiler generates those same methods for record struct types.


and [here](#https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record):


> Beginning with C# 9, you use the record keyword to define a reference type that provides built-in functionality for encapsulating data. C# 10 allows the record class syntax as a synonym to clarify a reference type, and record struct to define a value type with similar functionality. You can create record types with immutable properties by using positional parameters or standard property syntax.


What happen by using a record struct istead of a class?
We are telling to the commpiler to generate value based type instead of reference types.




As we can see we have a better performance and less memory allocation at the same time.


AutoMapper With Adapter - comparing with struct

|                                    Method | numElements |       Mean |     Error |    StdDev | Allocated |
|------------------------------------------ |------------ |-----------:|----------:|----------:|----------:|
| AutoMapper-WithAdapterRecord |        1000 |  <span style="color:yellow">98.373 μs</span> | 0.3810 μs | 0.5341 μs |   56048 B |
|       AutoMapper-WithAdapter |        1000 | 102.138 μs | 1.1354 μs | 1.6642 μs |  112048 B |
|         AutoMapper-NoAdapter |        1000 | 103.403 μs | 1.2254 μs | 1.8341 μs |  112048 B |
|   AutoMapper-NoAdapterRecord |        1000 | 103.480 μs | 1.3662 μs | 2.0025 μs |   56048 B |



## WebApi

## Benchmark WebApi