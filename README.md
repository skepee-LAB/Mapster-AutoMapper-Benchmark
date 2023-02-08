# Mapster - AutoMapper

## Introduction
Scope of this project is to show the use of the two most famous mapping tools: [Automapper](#https://github.com/AutoMapper/AutoMapper) and [Mapster](#https://github.com/MapsterMapper/Mapster) and then showing some benchmarks.

The base code has been tested by using [BenchmarkDotNet](#https://github.com/dotnet/BenchmarkDotNet).

Then a real use case with a WebApi endpoint is provided. In this case the endpoint is tested by using [Benchmark Rest](https://github.com/skepee/Benchmark-Rest-Api-Get). 

## Mapping scenarios to test
The benchmarks will consider two case: a simple case and a complex case.

- The <em>simple case</em> is a one-to-one mapping fields with a small and a great number of fields as subcases. We should also consider the case: 
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