# Mapster - AutoMapper

## Introduction
This is an analysis of the use of the two most famous mapping tools: [Automapper](#https://github.com/AutoMapper/AutoMapper) and [Mapster](#https://github.com/MapsterMapper/Mapster). We will show some benchmarks in two different types:

- base code tested by using [BenchmarkDotNet](#https://github.com/dotnet/BenchmarkDotNet).

- a real use case with a WebApi endpoint by using [Benchmark Rest](#https://github.com/skepee-PROTOTYPE/Benchmark-Rest-Api). 


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
        public PortfolioProfile()
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
A custom profile is used to map each prop from the source to destination we want to obtain and pass it to the ```MapperConfiguration```:

```cs
IMapper automapper = new Mapper(new MapperConfiguration(z => z.AddProfile(new PortfolioProfile())));
```
## Mapster
Mapster is relatively new and the github [page](#https://github.com/MapsterMapper/Mapster) shows some benchmarks compared with Automapper.

In order to use Mapster it is enough to use this simple code:

```cs
 var pDto = p.Adapt<Portfolio>();
```

and Mapster will map the ```Dto``` automatically. But this is a simple case with one-to-one mapping. For the case with adapter the code remains basically the same but we need to add ```AdaptMember``` as annotation in the props we want to map.

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



## MapsterCodeGen

Mapster offers a chance to generate the ```Dto``` dynamically at build time. This we will see later, offers great performances. In order to generate automatically the ```Dto```, it is needed to add these lines to ```csproj``` file:

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

and with this command the files will be generated:
```cs
 dotnet build -t:Mapster
```

When we will run the build the ```Dto```  with ```.g.cs``` extension will be generated.

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
- <em>unflattened</em>: the mapping for nested onjects like this:

        ```
        int x0         =>        int x1
        class a0:      =>        class a1:
        {                       {
            string b0;              string b1;
            date c0;                date c1;
        }                       }
        date y0        =>        date y1;
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
    <td>with Adapter</td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
</tr>
<tr>
    <td><em>Simple</em></td>
    <td>No Adapter</td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
</tr>
<tr>
    <td><em>Unflattened</em></td>
    <td>Nested objects, no Adapter</td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
    <td><span>&#10003;</span></td>
</tr>
</table>


<!-- <table>
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
</table> -->

# Test cases
Because there are different cases and combinations, by showing all these results in one shot is not helpful, so we go step by step.
## Simple case
The simple case regards a one-to-one mapping with a Dto with just five fields:

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

## unflattened case
The unflattened case regards a mapping with nested objects:

```cs
 public class DtoPortfolioUnflattened
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DtoStringPropertiesUnflattened GroupStringProperties { get; set; }
        public DtoIntPropertiesUnflattened GroupIntProperties { get; set; }
        public DtoDecimalPropertiesUnflattened GroupDecimalProperties { get; set; }
        public DtoDateTimePropertiesUnflattened GroupDateTimeProperties { get; set; }
    }

    // 50 decimal fields
    public class DtoDecimalPropertiesUnflattened
    {
        public decimal Prop101 { get; set; }
        ...
        public decimal Prop150 { get; set; }

    }

    // 50 int fields
    public class DtoIntPropertiesUnflattened
    {       
        public int Prop51 { get; set; }
        ...
        public int Prop100 { get; set; }
    }

    // 50 string fields
    public class DtoStringPropertiesUnflattened
    {
        public string Prop1 { get; set; }
        ...
        public string Prop50 { get; set; }
    }

    // 50 datetime fields
    public class DtoDateTimePropertiesUnflattened
    {
        public DateTime Prop151 { get; set; }
        ...
        public DateTime Prop200 { get; set; }
    }

```


## BenchmarkDotNet results
Now let us go to run the benchmarks for these cases by using ```AutoMapper``` and ```Mapster```.

The benchmark considers a list of portfolios of ````10```, ```100``` and ```1000``` size. How to do that?

By adding an annotation on the size property, we can parameterize the benchmark. So for each type of benchmark we will consider a list portfolios with length ```10```, ```100``` or ```1000```.

```cs
    [Params(10, 100, 1000)]
    public int numElements { get; set; }
```

<strong>Simple Portfolio - No Adapter </strong>
|      Method      | numElements |  Mean (μs)  | Allocated |
| :---             | ----------- | ----------- | ---------- |
|   AutoMapper     |       100   | 10.688      | 10.98 KB  |
|   Mapster        |       100   | 4.997       | 10.98 KB  | 
|   MapsterCodeGen |       100   | <span style="color:yellow"> 4.471</span>    | 1.7929  | 0.0644 |  10.98 KB   |

In the mapping one-to-one for a list of ```100``` portfolios with the same allocation memory <strong>Mapster CodeGen</strong> is more performing.



<strong>Simple Portfolio - With Adapter</strong>

|   Method   | numElements |  Mean (μs)| Allocated |
|----------- |------------ |----------:|---------: |
| AutoMapper |         100 |  9.761    | 10.98 KB   |
| Mapster    |         100 | 4.622     | 10.98 KB |
| MapsterCodeGen |         100 | <span style="color:yellow">4.407</span> |10.98 KB |

Also in this case in the mapping one-to-one for a list of ```100``` portfolios with the same allocation memory <strong>Mapster CodeGen</strong> is more performing.
Futhermore, as we can see, there is no much difference between ```Adapter``` and ```No Adapter``` scenario.
The use of Adapter then is clearly suggested only for situations where the ```Dto``` is already defined and we cannot create from scratch.


<strong>Unflattened Portfolio - No Adapter</strong>

|                     Method | numElements |        Mean |  Allocated |
|--------------------------- |------------ |------------:|-----------:|
|                AutoMapper  |          10 |    109.3 us |   19.11 KB |
|        MapsterUnflattened  |          10 |    111.4 us |   38.17 KB |
| MapsterUnflattenedCodeGen  |          10 |    116.7 us |   38.17 KB |
|                AutoMapper  |         100 |  1,088.4 us |  190.67 KB |
|        MapsterUnflattened  |         100 |  1,113.1 us |   381.3 KB |
| MapsterUnflattenedCodeGen  |         100 |  1,129.9 us |   381.3 KB |
|                AutoMapper  |        1000 | 10,902.5 us | 1906.31 KB |
|        MapsterUnflattened  |        1000 | 11,177.8 us | 3812.56 KB |
| MapsterUnflattenedCodeGen  |        1000 | 11,180.6 us | 3812.56 KB |

<!-- | Method | numElements |       Mean |Allocated |
|--------|------------ |-----------:|----------:|
| AutoMapper |         100 |  1,270.9 μs | 362.55 KB |
| Mapster |         100 |  1,104.4 μs |362.55 KB |
| MapsterCodeGen |         100 |  <span style="color:yellow">1,078.3 μs</span>  |362.55 KB | -->

<!-- Here we are considering a list of ```100``` portfolios where each portfolio contains ```205``` fields.
The results confirm the above considerations.


|    Method      | numElements |     Mean |Allocated |
|--------------- |------------ |---------:|----------:|
| MapsterCodeGen |         100 | 1.114 ms |371.14 KB |
| Mapster        |         100 | 1.142 s |  79.75 MB |
| AutoMapper     |         100 | 1.077 ms |  189.89 KB |
| MapsterCodeGenAndClass |         100 | 1.468 ms | 964.89 KB | -->



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

|                                    Method | numElements |       Mean | Allocated |
|------------------------------------------ |------------ |-----------:|----------:|
| AutoMapper-WithAdapterRecord |        1000 |  <span style="color:yellow">98.373 μs</span> |  56048 B |
|       AutoMapper-WithAdapter |        1000 | 102.138 μs | 112048 B |
|         AutoMapper-NoAdapter |        1000 | 103.403 μs |  112048 B |
|   AutoMapper-NoAdapterRecord |        1000 | 103.480 μs |   56048 B |

# An interesting case
Here we wil now consider a more complex case. Let's suppose we need to do some 
elaborations from our model, for example:

    ```
    int a         =>        int x
    string b                
    string c      =>        string  y = b + c + d
    string d              
    date e        =>        date z
    ```
We will see that in this case the performance are not good and we will explain why.
In particular starting from the second simple case (205 fields) we will take in consideration the following elaborations in the mapping:
- ```StringProperties``` is a concatenation of strings operation by using the strings props
- ```IntProperties```: calculates min(), max() and avg() from a list in integers props
- ```DecimalProperties```: calculates min(), max() and avg() from a list in decimals props
- ```GroupDateTimeProperties```: calculates min() and max() date from a list of dates from the dates props

In this case the ```Dto``` will be:

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


## Automapper configuration

When a more complex mapping is needed (because you know, life is not easy sometimes :-)), Automapper helps us on this by using a ```resolver```. A custom resolver is created by implementing ```IValueResolver<in TSource, in TDestination, TDestMember>``` for each operation we need, with:

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

Then adding to the existing profile:

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

For the complex case we can map the elaboration into the mapping,  ```ElaborationInMapping``` or outside the mapping, ```ElaborationOutsideMapping```.

### Elaboration-In-Mapping
We need to extend the ```Adapt``` instruction with a ```TypeAdapterConfig``` parameter in this way:

```cs
    var pDto = p.Adapt<DtoPortfolio>(GetTypeAdapterConfig());
```

where ```GetTypeAdapterConfig()``` define our custom mapping in a similar way it has been done for ```PortfolioResolver``` for AutoMapper


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

### Elaboration-Outside-Mapping
This is just a different way where the elaboration is done in the ```classical way``` without using any mapping. This we will see has a different performance that makes it useful to add in out tests:

```cs
    var pDto = p.Adapt<DtoPortfolio>();
    pDto.GroupDateTimeProperties = CalculateDateTimeOperation(...);
    pDto.GroupDecimalProperties = CalculateDecimalOperation(p);
    pDto.GroupIntProperties = CalculateIntOperation(...);
    pDto.GroupStringProperties = CalculateStringOperation(...);
```

## Benchmarks
The benchmarks will show results for 10, 100 and 500 iterations:

|                Method | numElements |           Mean |    Allocated |
|---------------------- |------------ |---------------:|-------------:|
| MapsterOutsideMapping |          10 |       139.3 us |     78.41 KB |
| AutoMapperPortfolio   |          10 |       140.6 us |     79.35 KB |
| MapsterInMapping      |          10 |   117,229.9 us |   8173.44 KB |

|                Method | numElements |           Mean |    Allocated |
|---------------------- |------------ |---------------:|-------------:|
| MapsterOutsideMapping |         100 |     1,384.0 us |    783.64 KB |
| AutoMapperPortfolio   |         100 |     1,417.8 us |    793.04 KB |
| MapsterInMapping      |         100 | 1,136,756.6 us |  81724.42 KB |

|                Method | numElements |           Mean |    Allocated |
|---------------------- |------------ |---------------:|-------------:|
| MapsterOutsideMapping |         500 |     6,898.0 us |   3918.02 KB |
| AutoMapperPortfolio   |         500 |     7,035.1 us |   3965.02 KB |
| MapsterInMapping      |         500 | 5,701,285.5 us | 408468.32 KB |

There is an interesting point to put in evidence here. Even if the ```mapster-outside-mapping``` has the best performance, this means that the mapping is not useful at all in this case. This is not because the mapping does not work but we are not using the tool in the right way. 
We are using the mapping to resolve a problem where mapping does not fits for this.
In order to obtain some ```calculated``` values this is to be done at <strong>model</strong> level, before the mapping level. Probably in this case we need to do some changes in the model, not in the Dto.




## WebApi

## Benchmark WebApi