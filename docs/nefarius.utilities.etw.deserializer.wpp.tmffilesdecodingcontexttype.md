# TmfFilesDecodingContextType

Namespace: Nefarius.Utilities.ETW.Deserializer.WPP

A [TDH_CONTEXT_TYPE.TDH_CONTEXT_WPP_TMFSEARCHPATH](./windows.win32.system.diagnostics.etw.tdh_context_type.md#tdh_context_wpp_tmfsearchpath) wrapper for use with
 [DecodingContext](./nefarius.utilities.etw.deserializer.wpp.decodingcontext.md).

```csharp
public sealed class TmfFilesDecodingContextType : DecodingContextType
```

Inheritance [Object](https://docs.microsoft.com/en-us/dotnet/api/system.object) → [DecodingContextType](./nefarius.utilities.etw.deserializer.wpp.decodingcontexttype.md) → [TmfFilesDecodingContextType](./nefarius.utilities.etw.deserializer.wpp.tmffilesdecodingcontexttype.md)

## Constructors

### <a id="constructors-.ctor"/>**TmfFilesDecodingContextType()**

A [TDH_CONTEXT_TYPE.TDH_CONTEXT_WPP_TMFSEARCHPATH](./windows.win32.system.diagnostics.etw.tdh_context_type.md#tdh_context_wpp_tmfsearchpath) wrapper for use with
 [DecodingContext](./nefarius.utilities.etw.deserializer.wpp.decodingcontext.md).

```csharp
public TmfFilesDecodingContextType()
```

### <a id="constructors-.ctor"/>**TmfFilesDecodingContextType(IList&lt;String&gt;)**

Gets decoding info from multiple paths containing `.TMF` files.

```csharp
public TmfFilesDecodingContextType(IList<String> pathList)
```

#### Parameters

`pathList` [IList&lt;String&gt;](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1)<br>
Null-terminated Unicode string that contains the path to the .tmf file. You do not have to
 specify this path if the search path contains the file. Only specify this context information if you also specify
 the TDH_CONTEXT_WPP_TMFFILE context type. If the file is not found, TDH searches the following locations in the
 given order:
 The path specified in the TRACE_FORMAT_SEARCH_PATH environment variableThe current folder